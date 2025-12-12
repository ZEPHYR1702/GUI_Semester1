using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Semester1.week13B
{
    public partial class FormDataResponden : Form
    {
        public FormDataResponden()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();

            string nama = textBoxInputNama.Text;
            int umur = int.Parse(textBoxInputUmur.Text);
            string domisili = comboBoxInputDomisili.SelectedItem.ToString();
            string statusPekerjaan;
            if (radioButtonBekerja.Checked)
            {
                statusPekerjaan = "Bekerja";
            }
            else if (radioButtonTidakBekerja.Checked)
            {
                statusPekerjaan = "Tidak Bekerja";
            }
            else if (radioButtonWiraswasta.Checked)
            {
                statusPekerjaan = "Wiraswasta";
            }
            else
            {
                statusPekerjaan = "Mahasiswa";
            }
            listBoxOutput.Items.Add("Nama: " + nama);
            listBoxOutput.Items.Add("Umur: " + umur + " tahun");
            listBoxOutput.Items.Add("Domisili: " + domisili);
            listBoxOutput.Items.Add("Status Pekerjaan: " + statusPekerjaan);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            textBoxInputNama.Clear();
            textBoxInputUmur.Clear();
            comboBoxInputDomisili.Text = "(Empty)";
            radioButtonBekerja.Checked = false;
            radioButtonTidakBekerja.Checked = false;
            radioButtonWiraswasta.Checked = false;
            radioButtonMahasiswa.Checked = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
