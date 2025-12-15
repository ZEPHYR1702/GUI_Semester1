namespace GUI_Semester1.Tambahan
{
    partial class FormStudentMark
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
            buttonInitializeArray = new Button();
            textBoxInputAssestment = new TextBox();
            textBoxInputStudent = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonInputMark = new Button();
            numericUpDownInputMark = new NumericUpDown();
            comboBoxInputColumn = new ComboBox();
            comboBoxInputRow = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            listBoxOutput = new ListBox();
            groupBox3 = new GroupBox();
            radioButtonAverageMark = new RadioButton();
            radioButtonHighestMark = new RadioButton();
            groupBox4 = new GroupBox();
            radioButtonAllAssessment = new RadioButton();
            radioButtonAllStudents = new RadioButton();
            buttonCalculate = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputMark).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonInitializeArray);
            groupBox1.Controls.Add(textBoxInputAssestment);
            groupBox1.Controls.Add(textBoxInputStudent);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(54, 32);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(212, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Array Initialization";
            // 
            // buttonInitializeArray
            // 
            buttonInitializeArray.Location = new Point(8, 221);
            buttonInitializeArray.Margin = new Padding(4, 3, 4, 3);
            buttonInitializeArray.Name = "buttonInitializeArray";
            buttonInitializeArray.Size = new Size(118, 33);
            buttonInitializeArray.TabIndex = 4;
            buttonInitializeArray.Text = "Initialize Array";
            buttonInitializeArray.UseVisualStyleBackColor = true;
            buttonInitializeArray.Click += buttonInitializeArray_Click;
            // 
            // textBoxInputAssestment
            // 
            textBoxInputAssestment.Location = new Point(8, 144);
            textBoxInputAssestment.Margin = new Padding(4, 3, 4, 3);
            textBoxInputAssestment.Name = "textBoxInputAssestment";
            textBoxInputAssestment.Size = new Size(155, 30);
            textBoxInputAssestment.TabIndex = 3;
            // 
            // textBoxInputStudent
            // 
            textBoxInputStudent.Location = new Point(8, 71);
            textBoxInputStudent.Margin = new Padding(4, 3, 4, 3);
            textBoxInputStudent.Name = "textBoxInputStudent";
            textBoxInputStudent.Size = new Size(155, 30);
            textBoxInputStudent.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 23);
            label2.TabIndex = 1;
            label2.Text = "Number of Assesment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 0;
            label1.Text = "Number of Students";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonInputMark);
            groupBox2.Controls.Add(numericUpDownInputMark);
            groupBox2.Controls.Add(comboBoxInputColumn);
            groupBox2.Controls.Add(comboBoxInputRow);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(274, 32);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(211, 271);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input";
            // 
            // buttonInputMark
            // 
            buttonInputMark.Location = new Point(7, 225);
            buttonInputMark.Name = "buttonInputMark";
            buttonInputMark.Size = new Size(138, 29);
            buttonInputMark.TabIndex = 6;
            buttonInputMark.Text = "Input Mark";
            buttonInputMark.UseVisualStyleBackColor = true;
            buttonInputMark.Click += buttonInputMark_Click;
            // 
            // numericUpDownInputMark
            // 
            numericUpDownInputMark.Location = new Point(84, 182);
            numericUpDownInputMark.Margin = new Padding(4, 3, 4, 3);
            numericUpDownInputMark.Name = "numericUpDownInputMark";
            numericUpDownInputMark.Size = new Size(61, 30);
            numericUpDownInputMark.TabIndex = 5;
            // 
            // comboBoxInputColumn
            // 
            comboBoxInputColumn.FormattingEnabled = true;
            comboBoxInputColumn.Location = new Point(8, 139);
            comboBoxInputColumn.Margin = new Padding(4, 3, 4, 3);
            comboBoxInputColumn.Name = "comboBoxInputColumn";
            comboBoxInputColumn.Size = new Size(137, 31);
            comboBoxInputColumn.TabIndex = 4;
            // 
            // comboBoxInputRow
            // 
            comboBoxInputRow.FormattingEnabled = true;
            comboBoxInputRow.Location = new Point(8, 75);
            comboBoxInputRow.Margin = new Padding(4, 3, 4, 3);
            comboBoxInputRow.Name = "comboBoxInputRow";
            comboBoxInputRow.Size = new Size(137, 31);
            comboBoxInputRow.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 184);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 2;
            label5.Text = "Mark:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 105);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(185, 23);
            label4.TabIndex = 1;
            label4.Text = "Assessment #(Column)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 0;
            label3.Text = "Student #(Row)";
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(54, 316);
            listBoxOutput.Margin = new Padding(4, 3, 4, 3);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(624, 165);
            listBoxOutput.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonAverageMark);
            groupBox3.Controls.Add(radioButtonHighestMark);
            groupBox3.Location = new Point(492, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(186, 101);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search for Value";
            // 
            // radioButtonAverageMark
            // 
            radioButtonAverageMark.AutoSize = true;
            radioButtonAverageMark.Location = new Point(6, 62);
            radioButtonAverageMark.Name = "radioButtonAverageMark";
            radioButtonAverageMark.Size = new Size(139, 27);
            radioButtonAverageMark.TabIndex = 1;
            radioButtonAverageMark.TabStop = true;
            radioButtonAverageMark.Text = "Average Mark";
            radioButtonAverageMark.UseVisualStyleBackColor = true;
            // 
            // radioButtonHighestMark
            // 
            radioButtonHighestMark.AutoSize = true;
            radioButtonHighestMark.Location = new Point(6, 29);
            radioButtonHighestMark.Name = "radioButtonHighestMark";
            radioButtonHighestMark.Size = new Size(135, 27);
            radioButtonHighestMark.TabIndex = 0;
            radioButtonHighestMark.TabStop = true;
            radioButtonHighestMark.Text = "Highest Mark";
            radioButtonHighestMark.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonAllAssessment);
            groupBox4.Controls.Add(radioButtonAllStudents);
            groupBox4.Location = new Point(492, 139);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(186, 105);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "From";
            // 
            // radioButtonAllAssessment
            // 
            radioButtonAllAssessment.AutoSize = true;
            radioButtonAllAssessment.Location = new Point(6, 62);
            radioButtonAllAssessment.Name = "radioButtonAllAssessment";
            radioButtonAllAssessment.Size = new Size(143, 27);
            radioButtonAllAssessment.TabIndex = 1;
            radioButtonAllAssessment.TabStop = true;
            radioButtonAllAssessment.Text = "All Assessment";
            radioButtonAllAssessment.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllStudents
            // 
            radioButtonAllStudents.AutoSize = true;
            radioButtonAllStudents.Location = new Point(6, 29);
            radioButtonAllStudents.Name = "radioButtonAllStudents";
            radioButtonAllStudents.Size = new Size(122, 27);
            radioButtonAllStudents.TabIndex = 0;
            radioButtonAllStudents.TabStop = true;
            radioButtonAllStudents.Text = "All Students";
            radioButtonAllStudents.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(492, 257);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(180, 29);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // FormStudentMark
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 518);
            Controls.Add(buttonCalculate);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(listBoxOutput);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormStudentMark";
            Text = "FormStudentMark";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputMark).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button buttonInitializeArray;
        private TextBox textBoxInputAssestment;
        private TextBox textBoxInputStudent;
        private NumericUpDown numericUpDownInputMark;
        private ComboBox comboBoxInputColumn;
        private ComboBox comboBoxInputRow;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonInputMark;
        private ListBox listBoxOutput;
        private GroupBox groupBox3;
        private RadioButton radioButtonAverageMark;
        private RadioButton radioButtonHighestMark;
        private GroupBox groupBox4;
        private RadioButton radioButtonAllAssessment;
        private RadioButton radioButtonAllStudents;
        private Button buttonCalculate;
    }
}