namespace GUI_Semester1.week13B
{
    partial class FormSistemAdministrasiHRD
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
            groupBox1 = new GroupBox();
            radioButtonProgrammer = new RadioButton();
            radioButtonWarehousing = new RadioButton();
            radioButtonPurchasing = new RadioButton();
            radioButtonAccounting = new RadioButton();
            groupBoxJaminan = new GroupBox();
            checkBoxJaminanHariTua = new CheckBox();
            checkBoxBPJSKetenagakerjaan = new CheckBox();
            checkBoxBPJSKesehatan = new CheckBox();
            checkBoxAsuransiPihak3 = new CheckBox();
            listBoxOutput = new ListBox();
            textBoxInputNama = new TextBox();
            textBoxInputUmur = new TextBox();
            comboBoxInputGaji = new ComboBox();
            buttonProses = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            groupBox1.SuspendLayout();
            groupBoxJaminan.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 72);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 1;
            label2.Text = "Umur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 111);
            label3.Name = "label3";
            label3.Size = new Size(30, 17);
            label3.TabIndex = 2;
            label3.Text = "Gaji";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonProgrammer);
            groupBox1.Controls.Add(radioButtonWarehousing);
            groupBox1.Controls.Add(radioButtonPurchasing);
            groupBox1.Controls.Add(radioButtonAccounting);
            groupBox1.Location = new Point(56, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 133);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Divisi";
            // 
            // radioButtonProgrammer
            // 
            radioButtonProgrammer.AutoSize = true;
            radioButtonProgrammer.Location = new Point(7, 99);
            radioButtonProgrammer.Name = "radioButtonProgrammer";
            radioButtonProgrammer.Size = new Size(103, 21);
            radioButtonProgrammer.TabIndex = 3;
            radioButtonProgrammer.TabStop = true;
            radioButtonProgrammer.Text = "Programmer";
            radioButtonProgrammer.UseVisualStyleBackColor = true;
            // 
            // radioButtonWarehousing
            // 
            radioButtonWarehousing.AutoSize = true;
            radioButtonWarehousing.Location = new Point(7, 72);
            radioButtonWarehousing.Name = "radioButtonWarehousing";
            radioButtonWarehousing.Size = new Size(106, 21);
            radioButtonWarehousing.TabIndex = 2;
            radioButtonWarehousing.TabStop = true;
            radioButtonWarehousing.Text = "Warehousing";
            radioButtonWarehousing.UseVisualStyleBackColor = true;
            // 
            // radioButtonPurchasing
            // 
            radioButtonPurchasing.AutoSize = true;
            radioButtonPurchasing.Location = new Point(7, 45);
            radioButtonPurchasing.Name = "radioButtonPurchasing";
            radioButtonPurchasing.Size = new Size(93, 21);
            radioButtonPurchasing.TabIndex = 1;
            radioButtonPurchasing.TabStop = true;
            radioButtonPurchasing.Text = "Purchasing";
            radioButtonPurchasing.UseVisualStyleBackColor = true;
            // 
            // radioButtonAccounting
            // 
            radioButtonAccounting.AutoSize = true;
            radioButtonAccounting.Location = new Point(7, 18);
            radioButtonAccounting.Name = "radioButtonAccounting";
            radioButtonAccounting.Size = new Size(95, 21);
            radioButtonAccounting.TabIndex = 0;
            radioButtonAccounting.TabStop = true;
            radioButtonAccounting.Text = "Accounting";
            radioButtonAccounting.UseVisualStyleBackColor = true;
            // 
            // groupBoxJaminan
            // 
            groupBoxJaminan.Controls.Add(checkBoxJaminanHariTua);
            groupBoxJaminan.Controls.Add(checkBoxBPJSKetenagakerjaan);
            groupBoxJaminan.Controls.Add(checkBoxBPJSKesehatan);
            groupBoxJaminan.Controls.Add(checkBoxAsuransiPihak3);
            groupBoxJaminan.Location = new Point(239, 157);
            groupBoxJaminan.Name = "groupBoxJaminan";
            groupBoxJaminan.Size = new Size(187, 133);
            groupBoxJaminan.TabIndex = 4;
            groupBoxJaminan.TabStop = false;
            groupBoxJaminan.Text = "Jaminan Tenaga Kerja";
            // 
            // checkBoxJaminanHariTua
            // 
            checkBoxJaminanHariTua.AutoSize = true;
            checkBoxJaminanHariTua.Location = new Point(13, 105);
            checkBoxJaminanHariTua.Name = "checkBoxJaminanHariTua";
            checkBoxJaminanHariTua.Size = new Size(131, 21);
            checkBoxJaminanHariTua.TabIndex = 3;
            checkBoxJaminanHariTua.Text = "Jaminan Hari Tua";
            checkBoxJaminanHariTua.UseVisualStyleBackColor = true;
            // 
            // checkBoxBPJSKetenagakerjaan
            // 
            checkBoxBPJSKetenagakerjaan.AutoSize = true;
            checkBoxBPJSKetenagakerjaan.Location = new Point(13, 78);
            checkBoxBPJSKetenagakerjaan.Name = "checkBoxBPJSKetenagakerjaan";
            checkBoxBPJSKetenagakerjaan.Size = new Size(159, 21);
            checkBoxBPJSKetenagakerjaan.TabIndex = 2;
            checkBoxBPJSKetenagakerjaan.Text = "BPJS Ketenagakerjaan";
            checkBoxBPJSKetenagakerjaan.UseVisualStyleBackColor = true;
            // 
            // checkBoxBPJSKesehatan
            // 
            checkBoxBPJSKesehatan.AutoSize = true;
            checkBoxBPJSKesehatan.Location = new Point(13, 45);
            checkBoxBPJSKesehatan.Name = "checkBoxBPJSKesehatan";
            checkBoxBPJSKesehatan.Size = new Size(121, 21);
            checkBoxBPJSKesehatan.TabIndex = 1;
            checkBoxBPJSKesehatan.Text = "BPJS Kesehatan";
            checkBoxBPJSKesehatan.UseVisualStyleBackColor = true;
            // 
            // checkBoxAsuransiPihak3
            // 
            checkBoxAsuransiPihak3.AutoSize = true;
            checkBoxAsuransiPihak3.Location = new Point(13, 18);
            checkBoxAsuransiPihak3.Name = "checkBoxAsuransiPihak3";
            checkBoxAsuransiPihak3.Size = new Size(147, 21);
            checkBoxAsuransiPihak3.TabIndex = 0;
            checkBoxAsuransiPihak3.Text = "Asuransi Pihak Ke-3";
            checkBoxAsuransiPihak3.UseVisualStyleBackColor = true;
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(437, 33);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(329, 259);
            listBoxOutput.TabIndex = 5;
            // 
            // textBoxInputNama
            // 
            textBoxInputNama.Location = new Point(130, 33);
            textBoxInputNama.Name = "textBoxInputNama";
            textBoxInputNama.Size = new Size(121, 25);
            textBoxInputNama.TabIndex = 6;
            // 
            // textBoxInputUmur
            // 
            textBoxInputUmur.Location = new Point(130, 69);
            textBoxInputUmur.Name = "textBoxInputUmur";
            textBoxInputUmur.Size = new Size(121, 25);
            textBoxInputUmur.TabIndex = 7;
            // 
            // comboBoxInputGaji
            // 
            comboBoxInputGaji.FormattingEnabled = true;
            comboBoxInputGaji.Items.AddRange(new object[] { "1500000", "2000000", "2500000" });
            comboBoxInputGaji.Location = new Point(130, 103);
            comboBoxInputGaji.Name = "comboBoxInputGaji";
            comboBoxInputGaji.Size = new Size(121, 25);
            comboBoxInputGaji.TabIndex = 8;
            comboBoxInputGaji.Text = "(Empty)";
            // 
            // buttonProses
            // 
            buttonProses.Location = new Point(298, 36);
            buttonProses.Name = "buttonProses";
            buttonProses.Size = new Size(75, 23);
            buttonProses.TabIndex = 9;
            buttonProses.Text = "Proses";
            buttonProses.UseVisualStyleBackColor = true;
            buttonProses.Click += buttonProses_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(298, 72);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 10;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(298, 108);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormSistemAdministrasiHRD
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 331);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonProses);
            Controls.Add(comboBoxInputGaji);
            Controls.Add(textBoxInputUmur);
            Controls.Add(textBoxInputNama);
            Controls.Add(listBoxOutput);
            Controls.Add(groupBoxJaminan);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "FormSistemAdministrasiHRD";
            Text = "FormSistemAdministrasiHRD";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxJaminan.ResumeLayout(false);
            groupBoxJaminan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radioButtonProgrammer;
        private RadioButton radioButtonWarehousing;
        private RadioButton radioButtonPurchasing;
        private RadioButton radioButtonAccounting;
        private GroupBox groupBoxJaminan;
        private CheckBox checkBoxJaminanHariTua;
        private CheckBox checkBoxBPJSKetenagakerjaan;
        private CheckBox checkBoxBPJSKesehatan;
        private CheckBox checkBoxAsuransiPihak3;
        private ListBox listBoxOutput;
        private TextBox textBoxInputNama;
        private TextBox textBoxInputUmur;
        private ComboBox comboBoxInputGaji;
        private Button buttonProses;
        private Button buttonReset;
        private Button buttonExit;
    }
}