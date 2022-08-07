using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using OfficeOpenXml;

namespace LabControl
{
    public partial class Form1 : Form
    {
        BindingList<Student> StudentsDB;
        public Form1()//инициализация формы
        {
            InitializeComponent();
            StudentsDB = new BindingList<Student>();//создаем список 
            dataGridView1.DataSource = StudentsDB;//подключаем к таблице
            //далее идут настройки интерфейса
            //скрываются не нужные кнопки, здаются названия колонок таблицы, а также указываются фильтры для окон сохранения и открытия файла
            buttonEditComplete.Hide();
            buttonEditRowComplete.Hide();
            buttonCancelEdit.Hide();
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dataGridView1.Columns["name"].HeaderText = "ФИО";
            dataGridView1.Columns["group"].HeaderText = "Группа";
            dataGridView1.Columns["subgroup"].HeaderText = "Подгруппа";
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["lab_count"].HeaderText = "Колличество лабораторных работ";

        }
        public void FileRead()//функиця для чтения содержимого файла
        {
            //получаем путь выбранного файла
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            //открываем файл, и пробуем загрузить его
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    //десериализуем файл, и записываем содержимое в StudentsDB
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(BindingList<Student>));
                    StudentsDB = (BindingList<Student>)xmlSerializer.Deserialize(fs);
                    //переподключаем источник данных, и заново задаем форматирование
                    //это требуется для того чтобы привязать к таблице обнавленный список
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = StudentsDB;
                    dataGridView1.Columns["name"].HeaderText = "ФИО";
                    dataGridView1.Columns["group"].HeaderText = "Группа";
                    dataGridView1.Columns["subgroup"].HeaderText = "Подгруппа";
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["lab_count"].HeaderText = "Колличество лабораторных работ";
                    textBoxClear();
                }
            }
            catch
            {
                //в случае ошибки выводим сообщение 
                MessageBox.Show("Ошибка открытия файла", "Ошибка!", MessageBoxButtons.OK);
            }

        }

        public void FileWrite()//функция для сохранения файла
        {
            //получаем путь сохранения файла
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            //создав файл, сериализуем данные в формат .xml
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(BindingList<Student>));
                xmlSerializer.Serialize(fs, StudentsDB);
            }

        }
        //кнопка Сохранить как
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileWrite();
        }
        //кнопка Открыть
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileRead();
        }

        //кнопка Создать
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //предлагаем сохранится
            var result = MessageBox.Show("Сохранить файл?", "Новый файл", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //в случае согласия запускаем функицю сохранения файла
                FileWrite();
                //и отчищаем текущие данные
                StudentsDB.Clear();
            }
            if (result == DialogResult.No)
            {
                //в случае отказа просто отчищаем текущие данные 
                StudentsDB.Clear();
            }
        }
        //кнопка Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //просто закрываем форму
            Close();
        }
        //событие Форма закрывается
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //если файл не пустой
            if (StudentsDB.Count != 0)
            {
                //то предлагаем сохранится
                var result = MessageBox.Show("Сохранить файл?", "Выход", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    FileWrite();

                }
                //в случае отмены закрытия
                if (result == DialogResult.Cancel)
                {
                    //прерываем операцию
                    e.Cancel = true;
                }
            }
        }
        //эта функиця нужна для открытия редактора лабораторных работ студента
        void OpenLabEdit()
        {
            //если таблица не пустая
            if (StudentsDB.Count != 0)
            {
                //то готовим резервную копию данных на случай отмены операции
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int count_orig = StudentsDB[rowIndex].lab_count;
                string[] orig_name = new string[count_orig];
                int[] orig_number = new int[count_orig];
                bool[] orig_status = new bool[count_orig];
                int[] orig_labId = new int[count_orig];
                for (int i = 0; i < count_orig; i++)
                {
                    orig_name[i] = StudentsDB[rowIndex].labs[i].Name;
                    orig_number[i] = StudentsDB[rowIndex].labs[i].Number;
                    orig_status[i] = StudentsDB[rowIndex].labs[i].Status;
                    orig_labId[i] = StudentsDB[rowIndex].labs[i].LabId;

                }
                //вызываем конструктор редактора лаб
                LabEditor labEditor = new LabEditor(StudentsDB[rowIndex].labs, StudentsDB[rowIndex].name, StudentsDB[rowIndex].lab_count);
                //и открываем окно
                labEditor.ShowDialog();
                if (labEditor.DialogResult == DialogResult.OK)
                {
                    //если результат успешен, то загружаем обанвленные данные 
                    StudentsDB[rowIndex].lab_count = labEditor.Counter;
                }
                else
                {
                    //в случае отмены, стираем изменённые данные
                    StudentsDB[rowIndex].labs.Clear();
                    //и загружаем исходные данные из копии
                    for (int i = 0; i < count_orig; i++)
                    {
                        StudentsDB[rowIndex].labs.Add(new Lab() { Name = orig_name[i], Number = orig_number[i], Status = orig_status[i], LabId = orig_labId[i] });
                    }
                    StudentsDB[rowIndex].lab_count = count_orig;
                }
                dataGridView1.Refresh();
            }
        }
        //вызов редактора лаб по двойному клику
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenLabEdit();
        }
        //вызов редактора лаб по нажатию кнопки 
        private void button4_Click(object sender, EventArgs e)
        {
            OpenLabEdit();
        }
        //функция для создания списка дубликатов, и их индексов
        //так как return позволяет вернуть только одну переменную, было зодано поле out для вывода списка индексов
        BindingList<Student> checkDoubles(Student student, bool checkAll, out List<int> index)
        {
            index = new List<int>();
            BindingList<Student> students = new BindingList<Student>();
            if (checkAll == true)
            {
                //случай сверки всех полей
                for (int i = 0; i < StudentsDB.Count; i++)
                {
                    if (StudentsDB[i].group == student.group && StudentsDB[i].name == student.name && StudentsDB[i].subgroup == student.subgroup)
                    {
                        students.Add(StudentsDB[i]);
                        index.Add(i);
                    }
                }
            }
            else
            {
                //сверка только имени
                for (int i = 0; i < StudentsDB.Count; i++)
                {
                    if (StudentsDB[i].name == student.name)
                    {
                        students.Add(StudentsDB[i]);
                        index.Add(i);
                    }
                }
            }
            //возвращаем полученный список
            return students;
        }
        List<int> index;

        //кнопка добавления студента
        private void button1_Click_1(object sender, EventArgs e)
        {
            //проверяем поля 
            if ((textBoxName.TextLength != 0) && (textBoxGroup.TextLength != 0) && (textBoxSubgroup.TextLength != 0))
            {
                //в случае заполненности полей создаем экземпляр класса Student с внесенными данными
                Student addStudent = new Student { name = textBoxName.Text, group = textBoxGroup.Text, subgroup = textBoxSubgroup.Text.ToString(), labs = new BindingList<Lab>(), id = 0 };
                //функция для генерации уникального id студента 
                //используется синткасис LinQ
                while (StudentsDB.Any(Student => Student.id == addStudent.id) == true)
                {
                    addStudent.id++;
                }
                //если дубликаты..
                if (checkDoubles(addStudent, true, out index).Count() == 0)
                {
                    //.. не найдены, то просто добавляем студента
                    StudentsDB.Add(addStudent);
                    textBoxClear();
                }
                else
                {
                    //..найдены, то спрашиваем подверждения
                    DialogResult Result = MessageBox.Show("Обнаружен дубликат! Продолжить?", "Ошибка!", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        //в случе согласия, добавляем студента в StudentsDB
                        StudentsDB.Add(addStudent);
                        textBoxClear();
                    }
                }
            }
            else
            {
                //если поля не заполнены, выводим ошибку
                MessageBox.Show("Не заполнены требуемые поля!", "Ошибка!", MessageBoxButtons.OK);
            }
        }
        // функция удаления по ФИО 
        private void buttonDeleteByName_Click(object sender, EventArgs e)
        {
            //проверяем поля 
            if (textBoxName.TextLength != 0)
            {
                //в случае заполненности полей создаем экземпляр класса Student с внесенными данными
                Student removeStudent = new Student { name = textBoxName.Text };
                //проверяем наличие подобных записей в исходном списке
                BindingList<Student> students = checkDoubles(removeStudent, false, out index);
                //если..
                if (students.Count() == 0)
                {
                    //..дубликаты не найдены, следовательно указанного студента нет в списках
                    //выводим ошибку
                    MessageBox.Show("Не найден студент!", "Ошибка!", MessageBoxButtons.OK);
                }
                if (students.Count() == 1)
                {
                    //..дубликат один то просто удаляем его
                    StudentsDB.Remove(students[0]);
                }
                if (students.Count() > 1)
                {
                    //..дубликатов больше одного
                    //то удаляем посредством специальной формы
                    //для начала создаем резервную копию изначальных данных
                    Student[] orig = new Student[students.Count];
                    for (int i = 0; i < students.Count(); i++)
                    {
                        orig[i] = students[i];
                        //а также удаляем найденные дубликаты
                        StudentsDB.Remove(students[i]);
                    }
                    //наш алгоритм действий таков
                    //мы удаляем найденные дубликаты из изначального списка
                    //и переносим их в специальную форму
                    //в данной форме мы удаляем нужные нам записи
                    //и добавляем оставшиеся назад в основной список
                    //вызываем кноструктор формы
                    Delete chooseStudent = new Delete(students);
                    //и открываем форму
                    chooseStudent.ShowDialog();
                    //если результат..
                    if (chooseStudent.DialogResult == DialogResult.OK)
                    {
                        //..успешен, то вносим оставшиеся записи в изначальный список
                        for (int i = 0; i < students.Count(); i++)
                        {
                            StudentsDB.Add(students[i]);
                        }
                    }
                    if (chooseStudent.DialogResult == DialogResult.Cancel)
                    {
                        //..отмена, то добавляем назад записи из резервной копии
                        for (int i = 0; i < orig.Count(); i++)
                        {
                            StudentsDB.Add(orig[i]);
                        }
                    }
                }
                textBoxClear();
            }
            else
            {
                //если поля не заполнены, то ошибка
                MessageBox.Show("Не заполнены требуемые поля!", "Ошибка!", MessageBoxButtons.OK);
            }
        }
        //функция удаления данных из выбранной строки
        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            //если данные в таблице имеются
            if (StudentsDB.Count() != 0)
            {
                //проверяем, выбрана ли строка
                int selectedRowsCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowsCount > 0)
                {
                    //предупреждаем обо операции
                    DialogResult Result = MessageBox.Show("Удалить выбранные строки?", "Внимание!", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        //при согласии 
                        //удаляем выбранные строки
                        for (int i = 0; i < selectedRowsCount; i++)
                        {
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        }
                    }
                }
            }
        }
        //переменная, нужная для редактирования
        int selectedIndex;
        //в нее мы будем сохранять индекс выбранной записи

        //функция для сокрытия ненужных кнопок во время редактирования
        private void editByNameButtonHide()
        {
            buttonEditByName.Hide();
            buttonAdd.Hide();
            buttonDeleteByName.Hide();
            buttonDeleteRow.Hide();
            buttonClearBoxes.Hide();
            buttonEditRow.Hide();
            buttonEditComplete.Show();
            buttonCancelEdit.Show();
        }

        private void buttonEditByName_Click(object sender, EventArgs e)
        {
            //проверяем, заполены ли поля
            if (textBoxName.TextLength != 0)
            {
                //в случае заполненности полей создаем экземпляр класса Student с внесенными данными
                Student editStudent = new Student { name = textBoxName.Text };
                //проверяем наличие подобных записей в исходном списке
                BindingList<Student> students = checkDoubles(editStudent, false, out index);
                //если..
                if (students.Count() == 0)
                {
                    //..дубликаты не найдены, следовательно такой записи нет 
                    MessageBox.Show("Не найден студент!", "Ошибка!", MessageBoxButtons.OK);
                }
                if (students.Count() == 1)
                {
                    //..дубликат найден
                    textBoxClear();
                    //выводим его содержимое в поля
                    textBoxName.Text = StudentsDB[index[0]].name;
                    textBoxGroup.Text = StudentsDB[index[0]].group;
                    textBoxSubgroup.Text = StudentsDB[index[0]].subgroup;
                    //а также сохраняем индекс записи 
                    selectedIndex = index[0];
                    //изменяем видимость кнопок для комфорта работы
                    editByNameButtonHide();
                }
                if (students.Count() > 1)
                {
                    //если дубликатов больше одного
                    //то вызываем специальную форму для выбора нужной нам записи
                    //вызываем конструктор формы
                    Editor editor = new Editor(students);
                    //выводим форму
                    editor.ShowDialog();
                    if (editor.DialogResult == DialogResult.OK)
                    {
                        //если результат-Ок 
                        //то забираем из формы выбранную строку
                        editStudent = editor.Student;
                        //перебираем список индексов дубликатов, созданный функцией checkDoubles
                        //это нужно, для нахождения выбранной нами в форме записи
                        for (int i = 0; i < index.Count; i++)
                        {
                            if (StudentsDB[index[i]] == editStudent)
                            {
                                //при нахождении выбранной записи
                                //операции идентичны редактированию без дублей 
                                //выводим выбранную запись в поля
                                textBoxClear();
                                textBoxName.Text = StudentsDB[index[i]].name;
                                textBoxGroup.Text = StudentsDB[index[i]].group;
                                textBoxSubgroup.Text = StudentsDB[index[i]].subgroup;
                                //а также сохраняем найденный индекс
                                selectedIndex = index[i];
                                //скрываем кнопки для комфорта работы
                                editByNameButtonHide();
                                break;
                            }
                        }
                    }
                    if (editor.DialogResult == DialogResult.Cancel)
                    {
                        //в случае отмены выбора записи
                        //просто отчищаем поля
                        textBoxClear();
                    }
                }
            }
            else
            {
                //если нужные поля не заполнены, то выводим ошибку
                MessageBox.Show("Не заполнены требуемые поля!", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        //функция для внесения изменений в список
        private void editComplete()
        {
            //проверяем заполенность полей, и запсиываем данные 
            if (textBoxName.TextLength != 0)
            {
                StudentsDB[selectedIndex].name = textBoxName.Text;
            }
            if (textBoxGroup.TextLength != 0)
            {
                StudentsDB[selectedIndex].group = textBoxGroup.Text;
            }
            if (textBoxSubgroup.TextLength != 0)
            {
                StudentsDB[selectedIndex].subgroup = textBoxSubgroup.Text;
            }
        }
        //кнопка завершения редактирования
        private void buttonEditComplete_Click(object sender, EventArgs e)
        {
            editComplete();
            //возвращаем конфигурацию кнопок
            buttonEditComplete.Hide();
            buttonAdd.Show();
            buttonDeleteByName.Show();
            buttonDeleteRow.Show();
            buttonClearBoxes.Show();
            buttonEditRow.Show();
            buttonEditByName.Show();
            buttonCancelEdit.Hide();
            textBoxClear();
            //обновляем таблицу
            dataGridView1.Refresh();
        }

        //функция редактирования выбранной строки
        private void buttonEditRow_Click(object sender, EventArgs e)
        {
            //проверяем наличе данных в списке
            if (StudentsDB.Count() != 0)
            {
                //проверяем, выбрана ли ОДНА  строка
                if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
                {
                    //получаем индекс выбранной записи
                    selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    //выводим данные в поля
                    textBoxName.Text = StudentsDB[selectedIndex].name;
                    textBoxGroup.Text = StudentsDB[selectedIndex].group;
                    textBoxSubgroup.Text = StudentsDB[selectedIndex].subgroup;
                    //скрываем ненужные кнопки
                    buttonEditByName.Hide();
                    buttonAdd.Hide();
                    buttonDeleteByName.Hide();
                    buttonDeleteRow.Hide();
                    buttonClearBoxes.Hide();
                    buttonEditRow.Hide();
                    buttonEditRowComplete.Show();
                    buttonCancelEdit.Show();
                }
                else
                {
                    //если выбрана не ОДНА строка, то выводим ошибку
                    MessageBox.Show("Пожалуйста, выбирете ОДНУ строку для редактирования.", "Ошибка!", MessageBoxButtons.OK);
                }
            }
        }
        private void buttonEditRowComplete_Click(object sender, EventArgs e)
        {
            editComplete();
            //возвращаем видимость кнопок
            buttonEditRowComplete.Hide();
            buttonAdd.Show();
            buttonDeleteByName.Show();
            buttonDeleteRow.Show();
            buttonClearBoxes.Show();
            buttonEditRow.Show();
            buttonEditByName.Show();
            buttonCancelEdit.Hide();
            textBoxClear();
            //обновляем таблицу
            dataGridView1.Refresh();
        }

        //кнопка отмены редактирования
        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            //возвращаем видимость кнопок
            buttonEditRowComplete.Hide();
            buttonAdd.Show();
            buttonDeleteByName.Show();
            buttonDeleteRow.Show();
            buttonClearBoxes.Show();
            buttonEditRow.Show();
            buttonEditByName.Show();
            buttonEditComplete.Hide();
            buttonEditRowComplete.Hide();
            buttonCancelEdit.Hide();
            //отчищаем поля
            textBoxClear();
        }

        //простая функция для быстрой отчистки полей
        private void textBoxClear()
        {
            textBoxName.Clear();
            textBoxGroup.Clear();
            textBoxSubgroup.Clear();
        }

        //кнопка отчистки полей
        private void buttonClearBoxes_Click_1(object sender, EventArgs e)
        {
            textBoxClear();
        }
        //кнопка открытия спраки
        private void показатьСпракуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"Help.docx");
            }
            catch
            {
                MessageBox.Show("Не найден файл Help.docx!", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        //кнопка создания отчёта в формате Excel
        private void сохранитьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //настройка и вызов окна сохранения файла
            saveFileDialog2.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            //полученное имя файла
            string filename = saveFileDialog2.FileName;
            //создаем новый файл Excel
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                //Добавляем новый лист в таблицу
                var worksheet = excelPackage.Workbook.Worksheets.Add("List 1");
                //задаём параметры форматирования
                worksheet.Column(1).Width = 8;
                worksheet.Column(2).Width = 35;
                worksheet.Column(3).Width = 15;
                worksheet.Column(4).Width = 12;
                worksheet.Column(5).Width = 12;
                //данные для счёта адреса ячейки для записи
                int count = 0;
                int count2 = 0;
                int firstRow = 0;
                int lastRow = 0;
                for (int i = 0; i < StudentsDB.Count; i++)
                {
                    //запись информации в таблицу 
                    worksheet.Cells[i + 1 + count + count2, 1].Value = "ФИО:";
                    worksheet.Cells[i + 1 + count + count2, 1].Style.Font.Bold = true;
                    worksheet.Cells[i + 1 + count + count2, 2].Value = StudentsDB[i].name;
                    worksheet.Cells[i + 1 + count + count2, 3].Value = "Группа:";
                    worksheet.Cells[i + 1 + count + count2, 3].Style.Font.Bold = true;
                    worksheet.Cells[i + 1 + count + count2, 4].Value = StudentsDB[i].group;
                    worksheet.Cells[i + 1 + count + count2, 5].Value = "Подгруппа";
                    worksheet.Cells[i + 1 + count + count2, 5].Style.Font.Bold = true;
                    worksheet.Cells[i + 1 + count + count2, 6].Value = StudentsDB[i].subgroup;
                    worksheet.Cells[i + 2 + count + count2, 1].Value = "Номер";
                    worksheet.Cells[i + 2 + count + count2, 1].Style.Font.Bold = true;
                    worksheet.Cells[i + 2 + count + count2, 2].Value = "Название работы";
                    worksheet.Cells[i + 2 + count + count2, 2].Style.Font.Bold = true;
                    worksheet.Cells[i + 2 + count + count2, 3].Value = "Статус";
                    worksheet.Cells[i + 2 + count + count2, 3].Style.Font.Bold = true;
                    for (int j = 0; j < StudentsDB[i].lab_count; j++)
                    {
                        worksheet.Cells[i + 3 + count + count2 + j, 1].Value = StudentsDB[i].labs[j].Number;
                        worksheet.Cells[i + 3 + count + count2 + j, 2].Value = StudentsDB[i].labs[j].Name;
                        if (StudentsDB[i].labs[j].Status == true)
                        {
                            worksheet.Cells[i + 3 + count + count2 + j, 3].Value = "Выполнена";
                        }
                        if (StudentsDB[i].labs[j].Status == false)
                        {
                            worksheet.Cells[i + 3 + count + count2 + j, 3].Value = "Не выполнена";

                        }
                        firstRow = i + 1 + count + count2;
                        lastRow = i + 3 + count + count2 + j;
                    }
                    //очерчивание границы вокруг таблицы
                    if (lastRow != 0)
                    {
                        worksheet.Cells[firstRow, 1, lastRow, 6].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thick);
                        count += StudentsDB[i].lab_count;
                        count2 += 1;
                    }
                    else
                    {
                        worksheet.Cells[firstRow+1, 1, i + 2 + count + count2, 6].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thick);
                    }
                }
                //запись файла
                try 
                {
                    excelPackage.SaveAs(new FileInfo(filename));
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения файла!", "Ошибка!", MessageBoxButtons.OK);
                }
            }
        }

        //кнопка "О программе"
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LabControl\nВерсия: 1.0\nАвтор: Егор Косяков\nЛицензия: MIT", "О программе", MessageBoxButtons.OK);
        }
    }
}


