using GUI_Semester1.Tambahan;
using GUI_Semester1.week13;
using GUI_Semester1.week13B;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Semester1
{
    public partial class FormMaster : Form
    {
        public FormMaster()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLatihan.Enabled = true;
            comboBoxLatihan.Items.Clear();
            comboBoxLatihan.Text = "(Pilih latihan di sini)";

            if (comboBoxGroup.SelectedItem!.ToString() == "Tambahan")
            {
                comboBoxLatihan.Items.Add("Nilai UTS Mahasiswa");
                comboBoxLatihan.Items.Add("Student Mark");
            }
            else if (comboBoxGroup.SelectedItem.ToString() == "Week 13A")
            {
                comboBoxLatihan.Items.Add("BMI Calculator");
                comboBoxLatihan.Items.Add("Favorite Vehicle");
                comboBoxLatihan.Items.Add("Test");
            }
            else if (comboBoxGroup.SelectedItem.ToString() == "Week 13B")
            {
                comboBoxLatihan.Items.Add("Data Responden");
                comboBoxLatihan.Items.Add("Sistem Administrasi HRD");
            }

            ValidateSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = comboBoxLatihan.SelectedItem?.ToString();
            if (selected == null)
            {
                MessageBox.Show("Please select a latihan first.");
                return;
            }

            switch (selected)
            {
                case "Nilai UTS Mahasiswa":
                    {
                        new FormNilaiUtsMahasiswa().ShowDialog();
                        break;
                    }
                case "BMI Calculator":
                    {
                        new FormBMICalculator().ShowDialog();
                        break;
                    }
                case "Favorite Vehicle":
                    {
                        new FormFavoriteVehicle().ShowDialog();
                        break;
                    }
                case "Test":
                    {
                        new FormTest().ShowDialog();
                        break;
                    }
                case "Data Responden":
                    {
                        new FormDataResponden().ShowDialog();
                        break;
                    }
                case "Sistem Administrasi HRD":
                    {
                        new FormSistemAdministrasiHRD().ShowDialog();
                        break;
                    }
                case "Student Mark":
                    {
                        new FormStudentMark().ShowDialog();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Latihan not found.");
                        break;
                    }
            }
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            comboBoxLatihan.Enabled = false;
            buttonEnter.Enabled = false;
        }

        private void ValidateSelection()
        {
            bool groupselected = comboBoxGroup.SelectedItem != null;
            bool latihanselected = comboBoxLatihan.SelectedItem != null;
            buttonEnter.Enabled = groupselected && latihanselected;
        }

        private void comboBoxLatihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateSelection();
        }
    }
}
