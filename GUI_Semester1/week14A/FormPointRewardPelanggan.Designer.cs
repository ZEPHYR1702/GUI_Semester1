namespace GUI_Semester1.week14A
{
    partial class FormPointRewardPelanggan
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelRewardInfo = new Label();
            label5 = new Label();
            textBoxInputNama = new TextBox();
            dateTimePickerOrderDate = new DateTimePicker();
            numericUpDownTotalOrder = new NumericUpDown();
            checkBoxMember = new CheckBox();
            buttonSave = new Button();
            pictureBoxReward = new PictureBox();
            buttonReport = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            listBoxOutput = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReward).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 57);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Order Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Total Order:";
            // 
            // labelRewardInfo
            // 
            labelRewardInfo.AutoSize = true;
            labelRewardInfo.Location = new Point(33, 203);
            labelRewardInfo.Name = "labelRewardInfo";
            labelRewardInfo.Size = new Size(89, 20);
            labelRewardInfo.TabIndex = 3;
            labelRewardInfo.Text = "Reward Info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 243);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Reward";
            // 
            // textBoxInputNama
            // 
            textBoxInputNama.Location = new Point(159, 18);
            textBoxInputNama.Name = "textBoxInputNama";
            textBoxInputNama.Size = new Size(125, 27);
            textBoxInputNama.TabIndex = 5;
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.Location = new Point(159, 60);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(250, 27);
            dateTimePickerOrderDate.TabIndex = 6;
            // 
            // numericUpDownTotalOrder
            // 
            numericUpDownTotalOrder.Location = new Point(159, 93);
            numericUpDownTotalOrder.Maximum = new decimal(new int[] { -1304428545, 434162106, 542, 0 });
            numericUpDownTotalOrder.Name = "numericUpDownTotalOrder";
            numericUpDownTotalOrder.Size = new Size(150, 27);
            numericUpDownTotalOrder.TabIndex = 7;
            numericUpDownTotalOrder.ThousandsSeparator = true;
            // 
            // checkBoxMember
            // 
            checkBoxMember.AutoSize = true;
            checkBoxMember.Location = new Point(32, 150);
            checkBoxMember.Name = "checkBoxMember";
            checkBoxMember.Size = new Size(87, 24);
            checkBoxMember.TabIndex = 8;
            checkBoxMember.Text = "Member";
            checkBoxMember.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(159, 150);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // pictureBoxReward
            // 
            pictureBoxReward.Location = new Point(105, 253);
            pictureBoxReward.Name = "pictureBoxReward";
            pictureBoxReward.Size = new Size(125, 62);
            pictureBoxReward.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxReward.TabIndex = 10;
            pictureBoxReward.TabStop = false;
            // 
            // buttonReport
            // 
            buttonReport.Location = new Point(59, 409);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(94, 29);
            buttonReport.TabIndex = 11;
            buttonReport.Text = "Report";
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(159, 409);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 12;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(259, 409);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(461, 57);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(327, 344);
            listBoxOutput.TabIndex = 14;
            listBoxOutput.SelectedIndexChanged += listBoxOutput_SelectedIndexChanged;
            // 
            // FormPointRewardPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxOutput);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonReport);
            Controls.Add(pictureBoxReward);
            Controls.Add(buttonSave);
            Controls.Add(checkBoxMember);
            Controls.Add(numericUpDownTotalOrder);
            Controls.Add(dateTimePickerOrderDate);
            Controls.Add(textBoxInputNama);
            Controls.Add(label5);
            Controls.Add(labelRewardInfo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPointRewardPelanggan";
            Text = "FormPointRewardPelanggan";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReward).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelRewardInfo;
        private Label label5;
        private TextBox textBoxInputNama;
        private DateTimePicker dateTimePickerOrderDate;
        private NumericUpDown numericUpDownTotalOrder;
        private CheckBox checkBoxMember;
        private Button buttonSave;
        private PictureBox pictureBoxReward;
        private Button buttonReport;
        private Button buttonReset;
        private Button buttonExit;
        private ListBox listBoxOutput;
    }
}