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
    public partial class Editor : Form
    {
        public Student Student { get; set; }
        public Lab Lab { get; set; }
        BindingList<Student> students;
        BindingList<Lab> labs;

        //переменная для хранения режима работы
        //с помощью нее мы определяем, работаем мы с Student или с Lab
        string type;

        //конструктор формы для Student
        public Editor(BindingList<Student> students)
        {
            //инициализация формы
            InitializeComponent();
            //создание списка
            this.students = students;
            //подключение данных
            dataGridView1.DataSource = students;
            //задаем режим работы 
            type = "student";
            //форматирование
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["name"].HeaderText = "ФИО";
            dataGridView1.Columns["group"].HeaderText = "Группа";
            dataGridView1.Columns["subgroup"].HeaderText = "Подгруппа";
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["lab_count"].HeaderText = "Колличество лабораторных работ";
        }
        //конструктор формы для Lab
        public Editor(BindingList<Lab> labs)
        {
            //инициализация формы
            InitializeComponent();
            //создание списка
            this.labs = labs;
            //подключение данных
            dataGridView1.DataSource = labs;           
            //задаем режим работы
            type = "lab";
            //форматирование
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["Name"].HeaderText = "Название";
            dataGridView1.Columns["Number"].HeaderText = "Номер";
            dataGridView1.Columns["Status"].HeaderText = "Выполнено?";
            dataGridView1.Columns["LabId"].Visible = false;
        }

        //кнопка Принять
        private void buttonDone_Click(object sender, EventArgs e)
        {
            //проверяем, выбрана ли ОДНА строка
            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
            {
                //для режима работы Student
                if (type == "student")
                {
                    //сохраняем выбранную строку
                    Student = students[dataGridView1.CurrentCell.RowIndex];
                    //возвращаем OK
                    DialogResult = DialogResult.OK;
                    //закрываем форму
                    Close();
                }
                //для режима работы Lab
                if (type == "lab")
                {
                    //сохраняем выбранную строку
                    Lab = labs[dataGridView1.CurrentCell.RowIndex];
                    //возвращаем OK
                    DialogResult = DialogResult.OK;
                    //закрываем форму
                    Close();
                }
            }
            else
            {
                //иначе, выводим ошибку
                MessageBox.Show("Выберете ОДНУ строку!", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        //кнопка Отмена
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //возвращаем Cancel
            DialogResult = DialogResult.Cancel;
            //закрываем форму
            Close();
        }


    }
}
