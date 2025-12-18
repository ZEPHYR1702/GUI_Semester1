using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Semester1.week14B
{
    public partial class FormDataProduk : Form
    {
        public FormDataProduk()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            buttonSaveData.Enabled = false;
        }

        //global variable
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listStock = new List<int>();
        List<DateTime> listPurchaseDate = new List<DateTime>();
        List<string> listImageFile = new List<string>();

        private void DisplayProduct(string name, int price, int stock, DateTime purchaseDate, string imageFile)
        {
            listBoxOutput.Items.Add("================================");
            listBoxOutput.Items.Add($"Product Name: {name}");
            listBoxOutput.Items.Add($"Price: {price.ToString("N0")}");
            listBoxOutput.Items.Add($"Stock: {stock}");
            listBoxOutput.Items.Add($"Purchase Date: {purchaseDate.ToShortDateString()}");
            listBoxOutput.Items.Add($"Image File: {imageFile}");
            listBoxOutput.Items.Add("================================");
            listBoxOutput.Items.Add("");
        }

        private bool IsOutOfStock(int stock, int minStock = 5)
        {
            bool isOutOfStock;
            if (stock < minStock)
            {
                isOutOfStock = true;
            }
            else
            {
                isOutOfStock = false;
            }
            return isOutOfStock;
        }

        private bool IsNewProduct(DateTime purchaseDate)
        {
            bool isNewProduct;
            TimeSpan difference = DateTime.Now - purchaseDate;
            if (difference.TotalDays < 7)
            {
                isNewProduct = true;
            }
            else
            {
                isNewProduct = false;
            }
            return isNewProduct;
        }

        private void ValidateSelection()
        {
            bool isImageValid = pictureBoxProductImage.Image != null;
            buttonSaveData.Enabled = isImageValid;
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            string productName = textBoxInputProductName.Text;
            int price = (int)numericUpDownInputPrice.Value;
            int stock = (int)numericUpDownInputStock.Value;
            DateTime purchaseDate = dateTimeInputPickerPurchaseDate.Value;
            string imageFile = labelFilePath.Text;

            listProductName.Add(productName);
            listPrice.Add(price);
            listStock.Add(stock);
            listPurchaseDate.Add(purchaseDate);
            listImageFile.Add(imageFile);

            MessageBox.Show($"Input Data Success {Environment.NewLine}Product Name: {productName} {Environment.NewLine}Price: {price} {Environment.NewLine}Stock: {stock} {Environment.NewLine}Purchase Date: {purchaseDate} {Environment.NewLine}Image Path: {imageFile}");
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    labelFilePath.Text = openFile.FileName;

                    pictureBoxProductImage.Image?.Dispose();

                    using (Image img = Image.FromFile(openFile.FileName))
                    {
                        pictureBoxProductImage.Image = new Bitmap(img);
                    }
                }
            }
            ValidateSelection();
        }

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add("=== All Product ===");
            for (int i = 0; i < listProductName.Count; i++)
            {
                DisplayProduct(listProductName[i], listPrice[i], listStock[i], listPurchaseDate[i], listImageFile[i]);
            }
        }

        private void buttonOutOfStock_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add("=== Out of Stock Product ===");
            for (int i = 0; i < listProductName.Count; i++)
            {
                if (IsOutOfStock(listStock[i]) == true)
                {
                    DisplayProduct(listProductName[i], listPrice[i], listStock[i], listPurchaseDate[i], listImageFile[i]);
                }
            }
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add("=== New Product ===");
            for (int i = 0; i < listProductName.Count; i++)
            {
                if (IsNewProduct(listPurchaseDate[i]) == true)
                {
                    DisplayProduct(listProductName[i], listPrice[i], listStock[i], listPurchaseDate[i], listImageFile[i]);
                }
            }
        }
    }
}
