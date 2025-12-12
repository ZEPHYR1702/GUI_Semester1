namespace GUI_Semester1.week13B
{
    partial class FormDataResponden
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
            textBoxInputNama = new TextBox();
            textBoxInputUmur = new TextBox();
            comboBoxInputDomisili = new ComboBox();
            groupBox1 = new GroupBox();
            radioButtonMahasiswa = new RadioButton();
            radioButtonTidakBekerja = new RadioButton();
            radioButtonWiraswasta = new RadioButton();
            radioButtonBekerja = new RadioButton();
            buttonProses = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            listBoxOutput = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Umur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Domisili";
            // 
            // textBoxInputNama
            // 
            textBoxInputNama.Location = new Point(124, 45);
            textBoxInputNama.Margin = new Padding(4);
            textBoxInputNama.Name = "textBoxInputNama";
            textBoxInputNama.Size = new Size(178, 27);
            textBoxInputNama.TabIndex = 3;
            // 
            // textBoxInputUmur
            // 
            textBoxInputUmur.Location = new Point(124, 91);
            textBoxInputUmur.Margin = new Padding(4);
            textBoxInputUmur.Name = "textBoxInputUmur";
            textBoxInputUmur.Size = new Size(178, 27);
            textBoxInputUmur.TabIndex = 4;
            // 
            // comboBoxInputDomisili
            // 
            comboBoxInputDomisili.FormattingEnabled = true;
            comboBoxInputDomisili.Items.AddRange(new object[] { "Surabaya", "Malang", "Jakarta", "Yogyakarta", "Medan", "Makassar" });
            comboBoxInputDomisili.Location = new Point(124, 133);
            comboBoxInputDomisili.Margin = new Padding(4);
            comboBoxInputDomisili.Name = "comboBoxInputDomisili";
            comboBoxInputDomisili.Size = new Size(178, 28);
            comboBoxInputDomisili.TabIndex = 5;
            comboBoxInputDomisili.Text = "(Empty)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonMahasiswa);
            groupBox1.Controls.Add(radioButtonTidakBekerja);
            groupBox1.Controls.Add(radioButtonWiraswasta);
            groupBox1.Controls.Add(radioButtonBekerja);
            groupBox1.Location = new Point(41, 169);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(261, 182);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status Pekerjaan";
            // 
            // radioButtonMahasiswa
            // 
            radioButtonMahasiswa.AutoSize = true;
            radioButtonMahasiswa.Location = new Point(4, 92);
            radioButtonMahasiswa.Margin = new Padding(4);
            radioButtonMahasiswa.Name = "radioButtonMahasiswa";
            radioButtonMahasiswa.Size = new Size(101, 24);
            radioButtonMahasiswa.TabIndex = 3;
            radioButtonMahasiswa.TabStop = true;
            radioButtonMahasiswa.Text = "Mahasiswa";
            radioButtonMahasiswa.UseVisualStyleBackColor = true;
            // 
            // radioButtonTidakBekerja
            // 
            radioButtonTidakBekerja.AutoSize = true;
            radioButtonTidakBekerja.Location = new Point(4, 59);
            radioButtonTidakBekerja.Margin = new Padding(4);
            radioButtonTidakBekerja.Name = "radioButtonTidakBekerja";
            radioButtonTidakBekerja.Size = new Size(119, 24);
            radioButtonTidakBekerja.TabIndex = 2;
            radioButtonTidakBekerja.TabStop = true;
            radioButtonTidakBekerja.Text = "Tidak Bekerja";
            radioButtonTidakBekerja.UseVisualStyleBackColor = true;
            // 
            // radioButtonWiraswasta
            // 
            radioButtonWiraswasta.AutoSize = true;
            radioButtonWiraswasta.Location = new Point(4, 125);
            radioButtonWiraswasta.Margin = new Padding(4);
            radioButtonWiraswasta.Name = "radioButtonWiraswasta";
            radioButtonWiraswasta.Size = new Size(103, 24);
            radioButtonWiraswasta.TabIndex = 1;
            radioButtonWiraswasta.TabStop = true;
            radioButtonWiraswasta.Text = "Wiraswasta";
            radioButtonWiraswasta.UseVisualStyleBackColor = true;
            // 
            // radioButtonBekerja
            // 
            radioButtonBekerja.AutoSize = true;
            radioButtonBekerja.Location = new Point(4, 25);
            radioButtonBekerja.Margin = new Padding(4);
            radioButtonBekerja.Name = "radioButtonBekerja";
            radioButtonBekerja.Size = new Size(78, 24);
            radioButtonBekerja.TabIndex = 0;
            radioButtonBekerja.TabStop = true;
            radioButtonBekerja.Text = "Bekerja";
            radioButtonBekerja.UseVisualStyleBackColor = true;
            // 
            // buttonProses
            // 
            buttonProses.Location = new Point(39, 359);
            buttonProses.Margin = new Padding(4);
            buttonProses.Name = "buttonProses";
            buttonProses.Size = new Size(84, 31);
            buttonProses.TabIndex = 7;
            buttonProses.Text = "Proses";
            buttonProses.UseVisualStyleBackColor = true;
            buttonProses.Click += buttonProses_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(130, 359);
            buttonReset.Margin = new Padding(4);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(82, 31);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(220, 359);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(82, 31);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(310, 45);
            listBoxOutput.Margin = new Padding(4);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(406, 304);
            listBoxOutput.TabIndex = 10;
            // 
            // FormDataResponden
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 426);
            Controls.Add(listBoxOutput);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonProses);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxInputDomisili);
            Controls.Add(textBoxInputUmur);
            Controls.Add(textBoxInputNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormDataResponden";
            Text = "FormDataResponden";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxInputNama;
        private TextBox textBoxInputUmur;
        private ComboBox comboBoxInputDomisili;
        private GroupBox groupBox1;
        private RadioButton radioButtonMahasiswa;
        private RadioButton radioButtonTidakBekerja;
        private RadioButton radioButtonWiraswasta;
        private RadioButton radioButtonBekerja;
        private Button buttonProses;
        private Button buttonReset;
        private Button buttonExit;
        private ListBox listBoxOutput;
    }
}