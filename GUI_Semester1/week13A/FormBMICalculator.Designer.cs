namespace GUI_Semester1.week13
{
    partial class FormBMICalculator
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
            label4 = new Label();
            textBoxInputNama = new TextBox();
            textBoxInputUmur = new TextBox();
            textBoxInputTinggiBadan = new TextBox();
            textBoxInputBeratBadan = new TextBox();
            buttonProses = new Button();
            buttonReset = new Button();
            labelHasil1 = new Label();
            labelHasil2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 70);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Umur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 99);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Tinggi Badan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 128);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Berat Badan";
            // 
            // textBoxInputNama
            // 
            textBoxInputNama.Location = new Point(149, 38);
            textBoxInputNama.Name = "textBoxInputNama";
            textBoxInputNama.Size = new Size(100, 23);
            textBoxInputNama.TabIndex = 4;
            // 
            // textBoxInputUmur
            // 
            textBoxInputUmur.Location = new Point(149, 67);
            textBoxInputUmur.Name = "textBoxInputUmur";
            textBoxInputUmur.Size = new Size(100, 23);
            textBoxInputUmur.TabIndex = 5;
            // 
            // textBoxInputTinggiBadan
            // 
            textBoxInputTinggiBadan.Location = new Point(149, 96);
            textBoxInputTinggiBadan.Name = "textBoxInputTinggiBadan";
            textBoxInputTinggiBadan.Size = new Size(100, 23);
            textBoxInputTinggiBadan.TabIndex = 6;
            // 
            // textBoxInputBeratBadan
            // 
            textBoxInputBeratBadan.Location = new Point(149, 125);
            textBoxInputBeratBadan.Name = "textBoxInputBeratBadan";
            textBoxInputBeratBadan.Size = new Size(100, 23);
            textBoxInputBeratBadan.TabIndex = 7;
            // 
            // buttonProses
            // 
            buttonProses.Location = new Point(45, 154);
            buttonProses.Name = "buttonProses";
            buttonProses.Size = new Size(75, 23);
            buttonProses.TabIndex = 8;
            buttonProses.Text = "Proses";
            buttonProses.UseVisualStyleBackColor = true;
            buttonProses.Click += buttonProses_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(174, 154);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 9;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelHasil1
            // 
            labelHasil1.AutoSize = true;
            labelHasil1.Location = new Point(50, 190);
            labelHasil1.Name = "labelHasil1";
            labelHasil1.Size = new Size(42, 15);
            labelHasil1.TabIndex = 10;
            labelHasil1.Text = "Hasil 1";
            // 
            // labelHasil2
            // 
            labelHasil2.AutoSize = true;
            labelHasil2.Location = new Point(50, 205);
            labelHasil2.Name = "labelHasil2";
            labelHasil2.Size = new Size(42, 15);
            labelHasil2.TabIndex = 11;
            labelHasil2.Text = "Hasil 2";
            // 
            // FormBMICalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 251);
            Controls.Add(labelHasil2);
            Controls.Add(labelHasil1);
            Controls.Add(buttonReset);
            Controls.Add(buttonProses);
            Controls.Add(textBoxInputBeratBadan);
            Controls.Add(textBoxInputTinggiBadan);
            Controls.Add(textBoxInputUmur);
            Controls.Add(textBoxInputNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBMICalculator";
            Text = "Form_BMI_Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxInputNama;
        private TextBox textBoxInputUmur;
        private TextBox textBoxInputTinggiBadan;
        private TextBox textBoxInputBeratBadan;
        private Button buttonProses;
        private Button buttonReset;
        private Label labelHasil1;
        private Label labelHasil2;
    }
}