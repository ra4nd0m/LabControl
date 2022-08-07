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
    public partial class Delete : Form
    {
        //создаем списки, необхадимые для работы 
        BindingList<Student> selectedStudents;
        BindingList<Lab> selectedLabs;
        //счётчик удаленных лаб
        public int LabsRemoved { get; set; }

        //конструктор для удаления записей типа Student
        public Delete(BindingList<Student>students)
        {
            InitializeComponent();
            selectedStudents = students;
            dataGridView1.DataSource = selectedStudents;
            dataGridView1.AllowUserToAddRows = false;
            LabsRemoved = 0;
            dataGridView1.Columns["name"].HeaderText = "ФИО";
            dataGridView1.Columns["group"].HeaderText = "Группа";
            dataGridView1.Columns["subgroup"].HeaderText = "Подгруппа";
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["lab_count"].HeaderText = "Колличество лабораторных работ";
        }

        //конструктор для удаления записей типа Lab
        public Delete(BindingList<Lab>labs)
        {
            InitializeComponent();
            selectedLabs = labs;
            dataGridView1.DataSource = selectedLabs;
            dataGridView1.AllowUserToAddRows = false;
            LabsRemoved = 0;
            dataGridView1.DataSource = labs;
            dataGridView1.Columns["Name"].HeaderText = "Название";
            dataGridView1.Columns["Number"].HeaderText = "Номер";
            dataGridView1.Columns["Status"].HeaderText = "Выполнено?";
            dataGridView1.Columns["LabId"].Visible = false;
        }

        //кнопка удаления выбранных строк 
        //аналогично основной форме
        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowsCount > 0)
            {
                for(int i = 0; i < selectedRowsCount; i++)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    LabsRemoved++;
                }
            }
        }
        //кнопка подтверждения
        private void buttonDone_Click(object sender, EventArgs e)
        {
            //вовращаем OK и закрываем форму
           DialogResult = DialogResult.OK;
           Close();
        }
        //кнопка отмены
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //возвращаем Cancel и закрываем форму
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
