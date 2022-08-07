namespace LabControl
{
    partial class LabEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLabCount = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDeleteByNumber = new System.Windows.Forms.Button();
            this.buttonEditByNumber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLabNumber = new System.Windows.Forms.TextBox();
            this.textBoxLabName = new System.Windows.Forms.TextBox();
            this.buttonEditByNumberDone = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonEditRowDone = new System.Windows.Forms.Button();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.buttonEditRow = new System.Windows.Forms.Button();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.buttonClearTextBoxes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(358, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 404);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 41);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(600, 404);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 41);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Студент:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(179, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Всего лабораторных работ:";
            // 
            // labelLabCount
            // 
            this.labelLabCount.AutoSize = true;
            this.labelLabCount.Location = new System.Drawing.Point(182, 102);
            this.labelLabCount.Name = "labelLabCount";
            this.labelLabCount.Size = new System.Drawing.Size(35, 13);
            this.labelLabCount.TabIndex = 7;
            this.labelLabCount.Text = "label4";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 309);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 42);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDeleteByNumber
            // 
            this.buttonDeleteByNumber.Location = new System.Drawing.Point(112, 309);
            this.buttonDeleteByNumber.Name = "buttonDeleteByNumber";
            this.buttonDeleteByNumber.Size = new System.Drawing.Size(87, 42);
            this.buttonDeleteByNumber.TabIndex = 10;
            this.buttonDeleteByNumber.Text = "Удалить по номеру";
            this.buttonDeleteByNumber.UseVisualStyleBackColor = true;
            this.buttonDeleteByNumber.Click += new System.EventHandler(this.buttonDeleteByNumber_Click);
            // 
            // buttonEditByNumber
            // 
            this.buttonEditByNumber.Location = new System.Drawing.Point(205, 309);
            this.buttonEditByNumber.Name = "buttonEditByNumber";
            this.buttonEditByNumber.Size = new System.Drawing.Size(95, 42);
            this.buttonEditByNumber.TabIndex = 11;
            this.buttonEditByNumber.Text = "Редактировать по номеру";
            this.buttonEditByNumber.UseVisualStyleBackColor = true;
            this.buttonEditByNumber.Click += new System.EventHandler(this.buttonEditByNumber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер №";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Название";
            // 
            // textBoxLabNumber
            // 
            this.textBoxLabNumber.Location = new System.Drawing.Point(112, 155);
            this.textBoxLabNumber.Name = "textBoxLabNumber";
            this.textBoxLabNumber.Size = new System.Drawing.Size(169, 20);
            this.textBoxLabNumber.TabIndex = 14;
            // 
            // textBoxLabName
            // 
            this.textBoxLabName.Location = new System.Drawing.Point(112, 190);
            this.textBoxLabName.Multiline = true;
            this.textBoxLabName.Name = "textBoxLabName";
            this.textBoxLabName.Size = new System.Drawing.Size(169, 99);
            this.textBoxLabName.TabIndex = 15;
            // 
            // buttonEditByNumberDone
            // 
            this.buttonEditByNumberDone.Location = new System.Drawing.Point(205, 309);
            this.buttonEditByNumberDone.Name = "buttonEditByNumberDone";
            this.buttonEditByNumberDone.Size = new System.Drawing.Size(95, 42);
            this.buttonEditByNumberDone.TabIndex = 16;
            this.buttonEditByNumberDone.Text = "Готово";
            this.buttonEditByNumberDone.UseVisualStyleBackColor = true;
            this.buttonEditByNumberDone.Click += new System.EventHandler(this.buttonEditByNumberDone_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.Location = new System.Drawing.Point(112, 357);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(87, 41);
            this.buttonDeleteRow.TabIndex = 17;
            this.buttonDeleteRow.Text = "Удалить строку";
            this.buttonDeleteRow.UseVisualStyleBackColor = true;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // buttonEditRowDone
            // 
            this.buttonEditRowDone.Location = new System.Drawing.Point(205, 356);
            this.buttonEditRowDone.Name = "buttonEditRowDone";
            this.buttonEditRowDone.Size = new System.Drawing.Size(95, 42);
            this.buttonEditRowDone.TabIndex = 18;
            this.buttonEditRowDone.Text = "Готово";
            this.buttonEditRowDone.UseVisualStyleBackColor = true;
            this.buttonEditRowDone.Click += new System.EventHandler(this.buttonEditRowDone_Click);
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Location = new System.Drawing.Point(205, 404);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(95, 41);
            this.buttonCancelEdit.TabIndex = 19;
            this.buttonCancelEdit.Text = "Отмена";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Click += new System.EventHandler(this.buttonCancelEdit_Click);
            // 
            // buttonEditRow
            // 
            this.buttonEditRow.Location = new System.Drawing.Point(205, 357);
            this.buttonEditRow.Name = "buttonEditRow";
            this.buttonEditRow.Size = new System.Drawing.Size(95, 41);
            this.buttonEditRow.TabIndex = 20;
            this.buttonEditRow.Text = "Редактировать строку";
            this.buttonEditRow.UseVisualStyleBackColor = true;
            this.buttonEditRow.Click += new System.EventHandler(this.buttonEditRow_Click);
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Location = new System.Drawing.Point(12, 356);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(87, 42);
            this.buttonChangeStatus.TabIndex = 21;
            this.buttonChangeStatus.Text = "Изменить статус ";
            this.buttonChangeStatus.UseVisualStyleBackColor = true;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // buttonClearTextBoxes
            // 
            this.buttonClearTextBoxes.Location = new System.Drawing.Point(112, 404);
            this.buttonClearTextBoxes.Name = "buttonClearTextBoxes";
            this.buttonClearTextBoxes.Size = new System.Drawing.Size(87, 41);
            this.buttonClearTextBoxes.TabIndex = 22;
            this.buttonClearTextBoxes.Text = "Отчистить поля";
            this.buttonClearTextBoxes.UseVisualStyleBackColor = true;
            this.buttonClearTextBoxes.Click += new System.EventHandler(this.buttonClearTextBoxes_Click);
            // 
            // LabEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.buttonClearTextBoxes);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.buttonEditRow);
            this.Controls.Add(this.buttonCancelEdit);
            this.Controls.Add(this.buttonEditRowDone);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.buttonEditByNumberDone);
            this.Controls.Add(this.textBoxLabName);
            this.Controls.Add(this.textBoxLabNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEditByNumber);
            this.Controls.Add(this.buttonDeleteByNumber);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelLabCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(721, 489);
            this.MinimumSize = new System.Drawing.Size(721, 489);
            this.Name = "LabEditor";
            this.Text = "Лабораторные работы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLabCount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDeleteByNumber;
        private System.Windows.Forms.Button buttonEditByNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLabNumber;
        private System.Windows.Forms.TextBox textBoxLabName;
        private System.Windows.Forms.Button buttonEditByNumberDone;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Button buttonEditRowDone;
        private System.Windows.Forms.Button buttonCancelEdit;
        private System.Windows.Forms.Button buttonEditRow;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.Button buttonClearTextBoxes;
    }
}