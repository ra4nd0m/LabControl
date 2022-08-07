using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControl
{
    public partial class LabEditor : Form
    {
        BindingList<Lab> Labs;
        public int Counter { get; set; }
        public int OrigCounter { get; set; }

        //данная форма работает аналогично основной форме
        //все функции идентичны
        //адаптированы для другого набора данных
        //также добвалена проверка поля Номер на наличие корректного символа посредством int.TryPrase
        public LabEditor(BindingList<Lab> labs,string name,int lab_count)
        {
            InitializeComponent();
            dataGridView1.DataSource = labs;
            dataGridView1.Columns["Name"].HeaderText = "Название";
            dataGridView1.Columns["Number"].HeaderText = "Номер";
            dataGridView1.Columns["Status"].HeaderText = "Выполнено?";
            dataGridView1.Columns["LabId"].Visible = false;
            buttonEditByNumberDone.Hide();
            Labs = labs;
            OrigCounter = lab_count;
            Counter = lab_count;
            labelName.Text = name;
            labelLabCount.Text = Counter.ToString();
            buttonEditByNumberDone.Hide();
            buttonEditRowDone.Hide();
            buttonCancelEdit.Hide();
        }

        //простая функция отчистки полей 
        private void textBoxClear()
        {
            textBoxLabName.Clear();
            textBoxLabNumber.Clear();
        }
        BindingList<Lab> checkDoublesLabs(Lab lab,out List<int>index)
        {
            index = new List<int>();
            BindingList<Lab> labs = new BindingList<Lab>();  
                for (int i = 0; i < Labs.Count(); i++)
                {
                    if (Labs[i].Number == lab.Number )
                    {
                        labs.Add(Labs[i]);
                    index.Add(i);
                    }
                }
            return labs;
        }
        List<int> index;

        //кнопка Добавить
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxLabName.TextLength!=0&&textBoxLabNumber.TextLength!=0&&int.TryParse(textBoxLabNumber.Text,out int result))
            {
                Lab newLab = new Lab { Name = textBoxLabName.Text, Number = result };
                while (Labs.Any(Lab => Lab.LabId == newLab.LabId) == true)
                {
                    newLab.LabId++;
                }
                if (checkDoublesLabs(newLab,out index).Count()==0)
                {
                    Labs.Add(newLab);
                    Counter++;
                    labelLabCount.Text = Counter.ToString();
                    textBoxClear();
                }
                else
                {
                    DialogResult Result = MessageBox.Show("Обнаружен дубликат! Продолжить?", "Ошибка!", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {

                        Labs.Add(newLab);
                        Counter++;
                        labelLabCount.Text = Counter.ToString();
                        textBoxClear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не заполнены требуемые поля, либо в поле Номер введен некорректный символ", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        //Кнопка Удалить по номеру
        private void buttonDeleteByNumber_Click(object sender, EventArgs e)
        {
            if (textBoxLabNumber.TextLength != 0&&int.TryParse(textBoxLabNumber.Text,out int result))
            {
                Lab removeLab=new Lab { Number = result };
                BindingList<Lab> labs = checkDoublesLabs(removeLab,out index);
                if (labs.Count() == 0)
                {
                    MessageBox.Show("Не найдена лаба!", "Ошибка!", MessageBoxButtons.OK);
                }
                if (labs.Count() == 1)
                {
                    Labs.Remove(labs[0]);
                    Counter--;
                }
                if (labs.Count() > 1)
                {
                    Lab[] orig = new Lab[labs.Count];
                    for (int i = 0; i < labs.Count(); i++)
                    {
                        orig[i] = labs[i];
                        Labs.Remove(labs[i]);
                    }
                    Delete chooseLab = new Delete(labs);
                    chooseLab.ShowDialog();
                    if (chooseLab.DialogResult == DialogResult.OK)
                    {
                        for (int i = 0; i < labs.Count(); i++)
                        {
                            Labs.Add(labs[i]);
                        }
                        Counter -= chooseLab.LabsRemoved;
                    }
                    if (chooseLab.DialogResult == DialogResult.Cancel)
                    {
                        for (int i = 0; i < orig.Count(); i++)
                        {
                            Labs.Add(orig[i]);
                        }
                    }
                }
                labelLabCount.Text = Counter.ToString();
                textBoxClear();
            }
            else
            {
                MessageBox.Show("Не заполнены требуемые поля, либо в поле Номер введен некорректный символ", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        //кнопка Удалить строку
        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            if (Labs.Count() != 0)
            {
                int selectedRowsCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowsCount > 0) { 
                    DialogResult Result = MessageBox.Show("Удалить выбранные строки?", "Внимание!", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {

                        for (int i = 0; i < selectedRowsCount; i++)
                        {
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        }
                        Counter -= selectedRowsCount;
                    }
                }
            }
        }
        int selectedIndex;

        //кнопка Редактировать по номеру
        private void buttonEditByNumber_Click(object sender, EventArgs e)
        {
            if (textBoxLabNumber.TextLength != 0 && int.TryParse(textBoxLabNumber.Text, out int result))
            {
                Lab editLab = new Lab { Number = result };
                BindingList<Lab> labs = checkDoublesLabs(editLab,out index);
                if (labs.Count() == 0)
                {
                    MessageBox.Show("Не найдена лаба!", "Ошибка!", MessageBoxButtons.OK);
                }
                if (labs.Count() == 1)
                {
                    for (int i = 0; i < index.Count(); i++)
                    {
                        if (Labs[index[i]].Number == editLab.Number)
                        {
                            textBoxClear();
                            selectedIndex = i;
                            textBoxLabName.Text = Labs[index[i]].Name;
                            textBoxLabNumber.Text = Labs[index[i]].Number.ToString();
                            buttonAdd.Hide();
                            buttonDeleteByNumber.Hide();
                            buttonDeleteRow.Hide();
                            buttonEditByNumberDone.Show();
                            buttonEditRow.Hide();
                            buttonChangeStatus.Hide();
                            buttonClearTextBoxes.Hide();
                            buttonCancelEdit.Show();
                            break;
                        }
                    }
                }
                if (labs.Count() > 1)
                {
                    Editor editor = new Editor(labs);
                    editor.ShowDialog();
                    if (editor.DialogResult == DialogResult.OK)
                    {
                        editLab = editor.Lab;
                        for (int i = 0; i < index.Count(); i++)
                        {
                            if (Labs[i].Number == editLab.Number)
                            {
                                textBoxClear();
                                selectedIndex = i;
                                textBoxLabName.Text = Labs[index[i]].Name;
                                textBoxLabNumber.Text = Labs[index[i]].Number.ToString();
                                buttonEditByNumber.Hide();
                                buttonAdd.Hide();
                                buttonDeleteByNumber.Hide();
                                buttonDeleteRow.Hide();
                                buttonEditByNumberDone.Show();
                                buttonCancelEdit.Show();
                                buttonEditRow.Hide();
                                buttonChangeStatus.Hide();
                                break;
                            }
                        }
                    }
                    else
                    {
                        textBoxClear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не заполнены требуемые поля!", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        //кнопка Редактировать строку
        private void buttonEditRow_Click(object sender, EventArgs e)
        {
            if (Labs.Count() != 0)
            {
                if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
                {
                    selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    textBoxLabName.Text = Labs[selectedIndex].Name;
                    textBoxLabNumber.Text = Labs[selectedIndex].Number.ToString();
                    
                    buttonAdd.Hide();
                    textBoxLabName.Text = Labs[selectedIndex].Name;
                    textBoxLabNumber.Text = Labs[selectedIndex].Number.ToString();
                    buttonAdd.Hide();
                    buttonEditRow.Hide();
                    buttonDeleteByNumber.Hide();
                    buttonEditByNumber.Hide();
                    buttonDeleteRow.Hide();
                    buttonChangeStatus.Hide();
                    buttonClearTextBoxes.Hide();
                    buttonEditRowDone.Show();
                    buttonCancelEdit.Show();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберете одну строку для редактирования.", "Ошибка!", MessageBoxButtons.OK);
                }
            }
        }

        //Кнопка заершения редактирования по номеру 
        private void buttonEditByNumberDone_Click(object sender, EventArgs e)
        {
            if (textBoxLabName.TextLength != 0)
            {
                Labs[selectedIndex].Name = textBoxLabName.Text;
            }
            if(textBoxLabNumber.TextLength!=0&&int.TryParse(textBoxLabNumber.Text,out int result))
            {
                Labs[selectedIndex].Number = result;
            }
            buttonEditByNumberDone.Hide();
            buttonEditRow.Show();
            buttonCancelEdit.Hide();
            buttonAdd.Show();
            buttonDeleteByNumber.Show();
            buttonDeleteRow.Show();
            buttonChangeStatus.Show();
            textBoxClear();
            dataGridView1.Refresh();
        }

        //кнопка завершения редактирования строки
        private void buttonEditRowDone_Click(object sender, EventArgs e)
        {
            if (textBoxLabName.TextLength != 0)
            {
                Labs[selectedIndex].Name = textBoxLabName.Text;
            }
            if (textBoxLabNumber.TextLength != 0 && int.TryParse(textBoxLabNumber.Text, out int result))
            {
                Labs[selectedIndex].Number = result;
            }
            buttonEditByNumberDone.Hide();
            buttonEditRow.Show();
            buttonCancelEdit.Hide();
            buttonEditRowDone.Hide();
            buttonAdd.Show();
            buttonDeleteByNumber.Show();
            buttonDeleteRow.Show();
            buttonEditByNumber.Show();
            buttonClearTextBoxes.Show();
            buttonChangeStatus.Show();
            textBoxClear();
            dataGridView1.Refresh();
        }

        //кнопка Отмены редактирования
        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            buttonEditByNumberDone.Hide();
            buttonCancelEdit.Hide();
            buttonAdd.Show();
            buttonDeleteByNumber.Show();
            buttonDeleteRow.Show();
            buttonEditRow.Show();
            buttonChangeStatus.Show();
            textBoxClear();
        }

        //кнопка смены статуса выполнения лабы
        //по сути эта кнопка-единственный новый элемент управления относительно основоной формы
        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            //проверяем количество данных в списке
            if (Labs.Count != 0)
            {
                //если список не пуст
                //получаем индекс выбранной строки
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                //изменяем статус выполнения
                Labs[rowIndex].Status = !Labs[rowIndex].Status;
                //обновляем таблицу
                dataGridView1.Refresh();
            }
        }
        //кнопка Сохранить
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //возвращаем OK
            DialogResult = DialogResult.OK;
            //закрываем форму
            Close();
        }

        //кнопка Отмена
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //возвращаем Cancel
            DialogResult = DialogResult.Cancel;
            //закрываем форму
            Close();
        }

        //кнопка Отчистить поля
        private void buttonClearTextBoxes_Click(object sender, EventArgs e)
        {
            textBoxClear();
        }
        //кнопка "Справка"
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"HelpLabs.docx");
            }
            catch
            {
                MessageBox.Show("Не найден файл HelpLabs.docx!", "Ошибка!", MessageBoxButtons.OK);
            }
 
        }
    }   
}
