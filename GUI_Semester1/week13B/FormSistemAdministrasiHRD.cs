using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Semester1.week13B
{
    public partial class FormSistemAdministrasiHRD : Form
    {
        public FormSistemAdministrasiHRD()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            string nama = textBoxInputNama.Text;
            int umur = int.Parse(textBoxInputUmur.Text);
            string gaji = comboBoxInputGaji.SelectedItem.ToString();
            string divisi;
            if (radioButtonAccounting.Checked == true)
            {
                divisi = "Accounting";
            }
            else if (radioButtonPurchasing.Checked == true)
            {
                divisi = "Purchasing";
            }
            else if (radioButtonWarehousing.Checked == true)
            {
                divisi = "Warehousing";
            }
            else
            {
                divisi = "Programmer";
            }

            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add("Nama: " + nama);
            listBoxOutput.Items.Add("Umur: " + umur + " tahun");
            listBoxOutput.Items.Add("Gaji: " + gaji);
            listBoxOutput.Items.Add("Divisi: " + divisi);
            listBoxOutput.Items.Add("Jaminan Tenaga Kerja: ");
            foreach (Control ctrl in groupBoxJaminan.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    listBoxOutput.Items.Add(" - " + cb.Text);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            textBoxInputNama.Clear();
            textBoxInputUmur.Clear();
            comboBoxInputGaji.Text = "(Empty)";
            radioButtonAccounting.Checked = false;
            radioButtonPurchasing.Checked = false;
            radioButtonWarehousing.Checked = false;
            radioButtonProgrammer.Checked = false;
            foreach (Control ctrl in groupBoxJaminan.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
