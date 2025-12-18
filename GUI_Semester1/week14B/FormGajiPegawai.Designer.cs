namespace GUI_Semester1.week14B
{
    partial class FormGajiPegawai
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
            groupBox1 = new GroupBox();
            buttonSaveData = new Button();
            textBoxBasicSalary = new TextBox();
            numericUpDownNumberOfChildren = new NumericUpDown();
            dateTimePickerStartWork = new DateTimePicker();
            checkBoxOutsource = new CheckBox();
            comboBoxPosition = new ComboBox();
            radioButtonGenderFemale = new RadioButton();
            radioButtonGenderMale = new RadioButton();
            textBoxEmployeeID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonClose = new Button();
            buttonDisplayAll = new Button();
            buttonClear = new Button();
            listBoxOutput = new ListBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfChildren).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSaveData);
            groupBox1.Controls.Add(textBoxBasicSalary);
            groupBox1.Controls.Add(numericUpDownNumberOfChildren);
            groupBox1.Controls.Add(dateTimePickerStartWork);
            groupBox1.Controls.Add(checkBoxOutsource);
            groupBox1.Controls.Add(comboBoxPosition);
            groupBox1.Controls.Add(radioButtonGenderFemale);
            groupBox1.Controls.Add(radioButtonGenderMale);
            groupBox1.Controls.Add(textBoxEmployeeID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 50);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(333, 398);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Data";
            // 
            // buttonSaveData
            // 
            buttonSaveData.Location = new Point(166, 324);
            buttonSaveData.Name = "buttonSaveData";
            buttonSaveData.Size = new Size(156, 29);
            buttonSaveData.TabIndex = 14;
            buttonSaveData.Text = "SAVE DATA";
            buttonSaveData.UseVisualStyleBackColor = true;
            buttonSaveData.Click += buttonSaveData_Click;
            // 
            // textBoxBasicSalary
            // 
            textBoxBasicSalary.Location = new Point(166, 259);
            textBoxBasicSalary.Name = "textBoxBasicSalary";
            textBoxBasicSalary.Size = new Size(156, 28);
            textBoxBasicSalary.TabIndex = 13;
            // 
            // numericUpDownNumberOfChildren
            // 
            numericUpDownNumberOfChildren.Location = new Point(166, 218);
            numericUpDownNumberOfChildren.Name = "numericUpDownNumberOfChildren";
            numericUpDownNumberOfChildren.Size = new Size(156, 28);
            numericUpDownNumberOfChildren.TabIndex = 12;
            // 
            // dateTimePickerStartWork
            // 
            dateTimePickerStartWork.Format = DateTimePickerFormat.Short;
            dateTimePickerStartWork.Location = new Point(166, 177);
            dateTimePickerStartWork.Name = "dateTimePickerStartWork";
            dateTimePickerStartWork.Size = new Size(156, 28);
            dateTimePickerStartWork.TabIndex = 11;
            dateTimePickerStartWork.Value = new DateTime(2025, 12, 18, 0, 0, 0, 0);
            // 
            // checkBoxOutsource
            // 
            checkBoxOutsource.AutoSize = true;
            checkBoxOutsource.Location = new Point(166, 146);
            checkBoxOutsource.Name = "checkBoxOutsource";
            checkBoxOutsource.Size = new Size(106, 25);
            checkBoxOutsource.TabIndex = 10;
            checkBoxOutsource.Text = "Outsource";
            checkBoxOutsource.UseVisualStyleBackColor = true;
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Staff", "Supervisor", "Manager" });
            comboBoxPosition.Location = new Point(166, 111);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(156, 29);
            comboBoxPosition.TabIndex = 9;
            comboBoxPosition.Text = "(Empty)";
            // 
            // radioButtonGenderFemale
            // 
            radioButtonGenderFemale.AutoSize = true;
            radioButtonGenderFemale.Location = new Point(234, 77);
            radioButtonGenderFemale.Name = "radioButtonGenderFemale";
            radioButtonGenderFemale.Size = new Size(83, 25);
            radioButtonGenderFemale.TabIndex = 8;
            radioButtonGenderFemale.TabStop = true;
            radioButtonGenderFemale.Text = "Female";
            radioButtonGenderFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderMale
            // 
            radioButtonGenderMale.AutoSize = true;
            radioButtonGenderMale.Location = new Point(166, 77);
            radioButtonGenderMale.Name = "radioButtonGenderMale";
            radioButtonGenderMale.Size = new Size(67, 25);
            radioButtonGenderMale.TabIndex = 7;
            radioButtonGenderMale.TabStop = true;
            radioButtonGenderMale.Text = "Male";
            radioButtonGenderMale.UseVisualStyleBackColor = true;
            // 
            // textBoxEmployeeID
            // 
            textBoxEmployeeID.Location = new Point(166, 40);
            textBoxEmployeeID.Name = "textBoxEmployeeID";
            textBoxEmployeeID.Size = new Size(156, 28);
            textBoxEmployeeID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 262);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 5;
            label6.Text = "Basic Salary:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 225);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 4;
            label5.Text = "Number of Children:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 177);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 3;
            label4.Text = "Start Work:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 111);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 2;
            label3.Text = "Position:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 1;
            label2.Text = "Gender:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Employee ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonClose);
            groupBox2.Controls.Add(buttonDisplayAll);
            groupBox2.Controls.Add(buttonClear);
            groupBox2.Controls.Add(listBoxOutput);
            groupBox2.Location = new Point(368, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(446, 398);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salary Report";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(336, 324);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(101, 29);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "CLOSE";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonDisplayAll
            // 
            buttonDisplayAll.Location = new Point(114, 324);
            buttonDisplayAll.Name = "buttonDisplayAll";
            buttonDisplayAll.Size = new Size(216, 29);
            buttonDisplayAll.TabIndex = 2;
            buttonDisplayAll.Text = "DISPLAY ALL";
            buttonDisplayAll.UseVisualStyleBackColor = true;
            buttonDisplayAll.Click += buttonDisplayAll_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(7, 324);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(101, 29);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(6, 27);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(425, 277);
            listBoxOutput.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(263, 9);
            label7.Name = "label7";
            label7.Size = new Size(253, 37);
            label7.TabIndex = 2;
            label7.Text = "EMPLOYEE SALARY";
            // 
            // FormGajiPegawai
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 472);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGajiPegawai";
            Text = "FormGajiPegawai";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfChildren).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxPosition;
        private RadioButton radioButtonGenderFemale;
        private RadioButton radioButtonGenderMale;
        private TextBox textBoxEmployeeID;
        private Button buttonSaveData;
        private TextBox textBoxBasicSalary;
        private NumericUpDown numericUpDownNumberOfChildren;
        private DateTimePicker dateTimePickerStartWork;
        private CheckBox checkBoxOutsource;
        private GroupBox groupBox2;
        private Button buttonClose;
        private Button buttonDisplayAll;
        private Button buttonClear;
        private ListBox listBoxOutput;
        private Label label7;
    }
}