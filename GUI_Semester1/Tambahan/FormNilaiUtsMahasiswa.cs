using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Semester1.Tambahan
{
    public partial class FormNilaiUtsMahasiswa : Form
    {
        List<string> listNamaMahasiswa = new List<string>();
        List<int> listNilaiUtsMahasiswa = new List<int>();
        public FormNilaiUtsMahasiswa()
        {
            InitializeComponent();
            textBoxNamaMahasiswa.Select();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void SimpanData()
        {
            string nama = textBoxNamaMahasiswa.Text;
            int nilaiUts = int.Parse(textBoxNilaiMahasiswa.Text);

            listNamaMahasiswa.Add(nama);
            listNilaiUtsMahasiswa.Add(nilaiUts);
        }

        private void TampilkanDataTerakhir()
        {
            listBoxData.Items.Clear();
            int last = listNamaMahasiswa.Count - 1;
            listBoxData.Items.Add($"Nama Mahasiswa: {listNamaMahasiswa[last]}, Nilai UTS: {listNilaiUtsMahasiswa[last]}");
        }

        private void ClearTextBox()
        {
            textBoxNamaMahasiswa.Clear();
            textBoxNilaiMahasiswa.Clear();
            textBoxNamaMahasiswa.Focus();
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            SimpanData();
            TampilkanDataTerakhir();
            ClearTextBox();
        }

        private void TampilkanSemuaData()
        {
            listBoxData.Items.Clear();
            for (int i = 0; i < listNamaMahasiswa.Count; i++)
            {
                listBoxData.Items.Add($"Nama Mahasiswa: {listNamaMahasiswa[i]}, Nilai UTS: {listNilaiUtsMahasiswa[i]}");
            }
        }

        private void buttonTampil_Click(object sender, EventArgs e)
        {
            TampilkanSemuaData();
        }

        private int CariNama(string nama)
        {
            return listNamaMahasiswa.IndexOf(nama);
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string namaDicari = textBoxNamaMahasiswa.Text;
            int index = CariNama(namaDicari);

            if (index == -1)
            {
                MessageBox.Show("Data tidak ditemukan", "Pencarian");
            }
            else
            {
                listBoxData.Items.Clear();
                listBoxData.Items.Add($"Ditemukan! Nama Mahasiswa: {listNamaMahasiswa[index]}, Nilai UTS: {listNilaiUtsMahasiswa[index]}");
            }
        }
    }
}
