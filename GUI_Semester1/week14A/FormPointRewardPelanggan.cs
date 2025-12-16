using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI_Semester1.week14A
{
    public partial class FormPointRewardPelanggan : Form
    {
        public FormPointRewardPelanggan()
        {
            InitializeComponent();
        }
        //global variable
        List<string> listMember = new List<string> { "Anita", "Budi", "Donni" };
        List<string> listNama = new List<string>();
        List<int> listPoint = new List<int> { 0, 0, 0 };

        private int CalculatePoint(int totalOrder, DateTime orderDate)
        {
            int poin = 0;
            DateTime startDate = new DateTime(2025, 7, 1);
            DateTime endDate = new DateTime(2025, 12, 1);
            if (totalOrder >= 100000 && (orderDate >= startDate && orderDate <= endDate))
            {
                poin = totalOrder / 1000;
            }
            return poin;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string nama = textBoxInputNama.Text;
            DateTime orderDate = dateTimePickerOrderDate.Value;
            int totalOrder = (int)numericUpDownTotalOrder.Value;

            int poin = 0;
            bool ketemu = false;
            if (checkBoxMember.Checked == true)
            {
                for (int i = 0; i < listMember.Count; i++)
                {
                    if (listMember[i] == nama)
                    {
                        poin = CalculatePoint(totalOrder, orderDate);
                        listPoint[i] += poin;
                        ketemu = true;
                        break;
                    }
                }
                if (ketemu == false)
                {
                    MessageBox.Show("Maaf, anda bukan member");
                }
            }
            listNama.Add(nama);
            if (poin > 0)
            {
                labelRewardInfo.Text = $"Selamat {nama},\nAnda mendapatkan {poin} poin";
            }
            else
            {
                labelRewardInfo.Text = $"Sorry {nama},\nAnda mendapatkan 0 poin";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInputNama.Clear();
            dateTimePickerOrderDate.Value = DateTime.Now;
            numericUpDownTotalOrder.Value = numericUpDownTotalOrder.Minimum;
            checkBoxMember.Checked = false;
            pictureBoxReward.Image = null;

            textBoxInputNama.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetRewards(int poin)
        {
            if (poin <= 500)
            {
                return "pen";
            }
            else if (poin <= 1000)
            {
                return "mug";
            }
            else
            {
                return "umbrella";
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();

            for (int i = 0; i < listNama.Count; i++)
            {
                string nama = listNama[i];
                int poin = listPoint[i];
                string reward = GetRewards(poin);

                string result = $"{nama} memperoleh poin = {poin} dan mendapat reward {reward}";
                listBoxOutput.Items.Add(result);
            }
        }

        private void listBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOutput.SelectedIndex != -1)
            {
                string selectedText = listBoxOutput.SelectedItem.ToString();
                string imagePath = "";

                if (selectedText.Contains("Mug"))
                {
                    imagePath = "mug.jpg";
                }
                else if (selectedText.Contains("Umbrella"))
                {
                    imagePath = "umbrella.jpg";
                }
                else if (selectedText.Contains("Pen"))
                {
                    imagePath = "pen.jpg";
                }

                if (imagePath != "")
                {
                    pictureBoxReward.Image = Image.FromFile(imagePath);
                }
            }
        }
    }
}
