namespace LabControl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьСпракуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSubgroup = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDeleteByName = new System.Windows.Forms.Button();
            this.buttonEditRow = new System.Windows.Forms.Button();
            this.buttonLabs = new System.Windows.Forms.Button();
            this.buttonClearBoxes = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonEditByName = new System.Windows.Forms.Button();
            this.buttonEditComplete = new System.Windows.Forms.Button();
            this.buttonEditRowComplete = new System.Windows.Forms.Button();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьОтчетToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьОтчетToolStripMenuItem
            // 
            this.сохранитьОтчетToolStripMenuItem.Name = "сохранитьОтчетToolStripMenuItem";
            this.сохранитьОтчетToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.сохранитьОтчетToolStripMenuItem.Text = "Сохранить отчет";
            this.сохранитьОтчетToolStripMenuItem.Click += new System.EventHandler(this.сохранитьОтчетToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьСпракуToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // показатьСпракуToolStripMenuItem
            // 
            this.показатьСпракуToolStripMenuItem.Name = "показатьСпракуToolStripMenuItem";
            this.показатьСпракуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.показатьСпракуToolStripMenuItem.Text = "Показать спраку";
            this.показатьСпракуToolStripMenuItem.Click += new System.EventHandler(this.показатьСпракуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(411, 377);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 236);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Группа";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(102, 283);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(138, 20);
            this.textBoxGroup.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Подгруппа";
            // 
            // textBoxSubgroup
            // 
            this.textBoxSubgroup.Location = new System.Drawing.Point(102, 328);
            this.textBoxSubgroup.Name = "textBoxSubgroup";
            this.textBoxSubgroup.Size = new System.Drawing.Size(138, 20);
            this.textBoxSubgroup.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 361);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 34);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonDeleteByName
            // 
            this.buttonDeleteByName.Location = new System.Drawing.Point(136, 401);
            this.buttonDeleteByName.Name = "buttonDeleteByName";
            this.buttonDeleteByName.Size = new System.Drawing.Size(95, 34);
            this.buttonDeleteByName.TabIndex = 13;
            this.buttonDeleteByName.Text = "Удалить По ФИО";
            this.buttonDeleteByName.UseVisualStyleBackColor = true;
            this.buttonDeleteByName.Click += new System.EventHandler(this.buttonDeleteByName_Click);
            // 
            // buttonEditRow
            // 
            this.buttonEditRow.Location = new System.Drawing.Point(258, 361);
            this.buttonEditRow.Name = "buttonEditRow";
            this.buttonEditRow.Size = new System.Drawing.Size(95, 34);
            this.buttonEditRow.TabIndex = 14;
            this.buttonEditRow.Text = "Редактировать Строку";
            this.buttonEditRow.UseVisualStyleBackColor = true;
            this.buttonEditRow.Click += new System.EventHandler(this.buttonEditRow_Click);
            // 
            // buttonLabs
            // 
            this.buttonLabs.Location = new System.Drawing.Point(102, 80);
            this.buttonLabs.Name = "buttonLabs";
            this.buttonLabs.Size = new System.Drawing.Size(109, 53);
            this.buttonLabs.TabIndex = 15;
            this.buttonLabs.Text = "Лабораторные работы студента";
            this.buttonLabs.UseVisualStyleBackColor = true;
            this.buttonLabs.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonClearBoxes
            // 
            this.buttonClearBoxes.Location = new System.Drawing.Point(15, 401);
            this.buttonClearBoxes.Name = "buttonClearBoxes";
            this.buttonClearBoxes.Size = new System.Drawing.Size(95, 34);
            this.buttonClearBoxes.TabIndex = 17;
            this.buttonClearBoxes.Text = "Отчистить поля";
            this.buttonClearBoxes.UseVisualStyleBackColor = true;
            this.buttonClearBoxes.Click += new System.EventHandler(this.buttonClearBoxes_Click_1);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.Location = new System.Drawing.Point(136, 361);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(95, 34);
            this.buttonDeleteRow.TabIndex = 18;
            this.buttonDeleteRow.Text = "Удалить Строку";
            this.buttonDeleteRow.UseVisualStyleBackColor = true;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // buttonEditByName
            // 
            this.buttonEditByName.Location = new System.Drawing.Point(258, 401);
            this.buttonEditByName.Name = "buttonEditByName";
            this.buttonEditByName.Size = new System.Drawing.Size(95, 34);
            this.buttonEditByName.TabIndex = 19;
            this.buttonEditByName.Text = "Редактировать По ФИО";
            this.buttonEditByName.UseVisualStyleBackColor = true;
            this.buttonEditByName.Click += new System.EventHandler(this.buttonEditByName_Click);
            // 
            // buttonEditComplete
            // 
            this.buttonEditComplete.Location = new System.Drawing.Point(258, 401);
            this.buttonEditComplete.Name = "buttonEditComplete";
            this.buttonEditComplete.Size = new System.Drawing.Size(95, 34);
            this.buttonEditComplete.TabIndex = 20;
            this.buttonEditComplete.Text = "Готово";
            this.buttonEditComplete.UseVisualStyleBackColor = true;
            this.buttonEditComplete.Click += new System.EventHandler(this.buttonEditComplete_Click);
            // 
            // buttonEditRowComplete
            // 
            this.buttonEditRowComplete.Location = new System.Drawing.Point(258, 361);
            this.buttonEditRowComplete.Name = "buttonEditRowComplete";
            this.buttonEditRowComplete.Size = new System.Drawing.Size(95, 34);
            this.buttonEditRowComplete.TabIndex = 21;
            this.buttonEditRowComplete.Text = "Готово";
            this.buttonEditRowComplete.UseVisualStyleBackColor = true;
            this.buttonEditRowComplete.Click += new System.EventHandler(this.buttonEditRowComplete_Click);
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Location = new System.Drawing.Point(258, 441);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(95, 34);
            this.buttonCancelEdit.TabIndex = 22;
            this.buttonCancelEdit.Text = "Отмена";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Click += new System.EventHandler(this.buttonCancelEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 499);
            this.Controls.Add(this.buttonCancelEdit);
            this.Controls.Add(this.buttonEditRowComplete);
            this.Controls.Add(this.buttonEditComplete);
            this.Controls.Add(this.buttonEditByName);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.buttonClearBoxes);
            this.Controls.Add(this.buttonLabs);
            this.Controls.Add(this.buttonEditRow);
            this.Controls.Add(this.buttonDeleteByName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSubgroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(859, 538);
            this.MinimumSize = new System.Drawing.Size(859, 538);
            this.Name = "Form1";
            this.Text = "LabControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьСпракуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSubgroup;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDeleteByName;
        private System.Windows.Forms.Button buttonEditRow;
        private System.Windows.Forms.Button buttonLabs;
        private System.Windows.Forms.Button buttonClearBoxes;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Button buttonEditByName;
        private System.Windows.Forms.Button buttonEditComplete;
        private System.Windows.Forms.Button buttonEditRowComplete;
        private System.Windows.Forms.Button buttonCancelEdit;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

