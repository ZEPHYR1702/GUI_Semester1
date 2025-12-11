namespace GUI_Semester1.Tambahan
{
    partial class FormNilaiUtsMahasiswa
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
            textBoxNamaMahasiswa = new TextBox();
            textBoxNilaiMahasiswa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonProses = new Button();
            buttonTampil = new Button();
            buttonCari = new Button();
            listBoxData = new ListBox();
            SuspendLayout();
            // 
            // textBoxNamaMahasiswa
            // 
            textBoxNamaMahasiswa.Location = new Point(265, 45);
            textBoxNamaMahasiswa.Margin = new Padding(4, 4, 4, 4);
            textBoxNamaMahasiswa.Name = "textBoxNamaMahasiswa";
            textBoxNamaMahasiswa.Size = new Size(183, 27);
            textBoxNamaMahasiswa.TabIndex = 0;
            // 
            // textBoxNilaiMahasiswa
            // 
            textBoxNilaiMahasiswa.Location = new Point(265, 84);
            textBoxNilaiMahasiswa.Margin = new Padding(4, 4, 4, 4);
            textBoxNilaiMahasiswa.Name = "textBoxNilaiMahasiswa";
            textBoxNilaiMahasiswa.Size = new Size(183, 27);
            textBoxNilaiMahasiswa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 2;
            label1.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 3;
            label2.Text = "Nilai Mahasiswa";
            // 
            // buttonProses
            // 
            buttonProses.Location = new Point(89, 147);
            buttonProses.Margin = new Padding(4, 4, 4, 4);
            buttonProses.Name = "buttonProses";
            buttonProses.Size = new Size(96, 31);
            buttonProses.TabIndex = 4;
            buttonProses.Text = "Proses";
            buttonProses.UseVisualStyleBackColor = true;
            buttonProses.Click += buttonProses_Click;
            // 
            // buttonTampil
            // 
            buttonTampil.Location = new Point(219, 147);
            buttonTampil.Margin = new Padding(4, 4, 4, 4);
            buttonTampil.Name = "buttonTampil";
            buttonTampil.Size = new Size(96, 31);
            buttonTampil.TabIndex = 5;
            buttonTampil.Text = "Tampil";
            buttonTampil.UseVisualStyleBackColor = true;
            buttonTampil.Click += buttonTampil_Click;
            // 
            // buttonCari
            // 
            buttonCari.Location = new Point(352, 147);
            buttonCari.Margin = new Padding(4, 4, 4, 4);
            buttonCari.Name = "buttonCari";
            buttonCari.Size = new Size(96, 31);
            buttonCari.TabIndex = 6;
            buttonCari.Text = "Cari";
            buttonCari.UseVisualStyleBackColor = true;
            buttonCari.Click += buttonCari_Click;
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.Location = new Point(89, 199);
            listBoxData.Margin = new Padding(4, 4, 4, 4);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(359, 184);
            listBoxData.TabIndex = 7;
            // 
            // FormNilaiUtsMahasiswa
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 481);
            Controls.Add(listBoxData);
            Controls.Add(buttonCari);
            Controls.Add(buttonTampil);
            Controls.Add(buttonProses);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNilaiMahasiswa);
            Controls.Add(textBoxNamaMahasiswa);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormNilaiUtsMahasiswa";
            Text = "Nilai UTS Mahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNamaMahasiswa;
        private TextBox textBoxNilaiMahasiswa;
        private Label label1;
        private Label label2;
        private Button buttonProses;
        private Button buttonTampil;
        private Button buttonCari;
        private ListBox listBoxData;
    }
}