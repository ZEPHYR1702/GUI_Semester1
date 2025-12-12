using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Semester1.week13
{
    public partial class FormBMICalculator : Form
    {
        public FormBMICalculator()
        {
            InitializeComponent();
            textBoxInputNama.Select();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            double inputBeratBadan = double.Parse(textBoxInputBeratBadan.Text);
            double inputTinggiBadan = double.Parse(textBoxInputTinggiBadan.Text) / 100; // Convert cm to m
            double BMI = inputBeratBadan / (inputTinggiBadan * inputTinggiBadan);
            string kategori, catatan;
            if (BMI < 17)
            {
                kategori = "Kurus";
                catatan = "Kekurangan berat badan tingkat berat";
            }
            else if (BMI < 18.5)
            {
                kategori = "Kurus";
                catatan = "Kekurangan berat badan tingkat rendah";
            }
            else if (BMI < 25)
            {
                kategori = "Normal";
                catatan = "";
            }
            else if (BMI < 27)
            {
                kategori = "Gemuk";
                catatan = "Kelebihan berat badan tingat ringan";
            }
            else
            {
                kategori = "Gemuk";
                catatan = "Kelebihan berat badan tingat berat";
            }

            labelHasil1.Text = $"Halo {textBoxInputNama.Text}, Umur anda {textBoxInputUmur.Text} Tahun.";
            labelHasil2.Text = $"Berdasarkan data anda, Status BMI anda adalah: {kategori}\nCatatan: {catatan}";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInputNama.Clear();
            textBoxInputUmur.Clear();
            textBoxInputTinggiBadan.Clear();
            textBoxInputBeratBadan.Clear();
            labelHasil1.Text = "Hasil 1";
            labelHasil2.Text = "Hasil 2";
            textBoxInputNama.Select();
        }
    }
}
