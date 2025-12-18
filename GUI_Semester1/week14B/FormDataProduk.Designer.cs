namespace GUI_Semester1.week14B
{
    partial class FormDataProduk
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
            groupBox1 = new GroupBox();
            labelFilePath = new Label();
            buttonSaveData = new Button();
            pictureBoxProductImage = new PictureBox();
            buttonBrowse = new Button();
            dateTimeInputPickerPurchaseDate = new DateTimePicker();
            numericUpDownInputStock = new NumericUpDown();
            numericUpDownInputPrice = new NumericUpDown();
            textBoxInputProductName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBoxOutput = new ListBox();
            buttonNewProduct = new Button();
            buttonOutOfStock = new Button();
            buttonClearData = new Button();
            buttonDisplayAll = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputPrice).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelFilePath);
            groupBox1.Controls.Add(buttonSaveData);
            groupBox1.Controls.Add(pictureBoxProductImage);
            groupBox1.Controls.Add(buttonBrowse);
            groupBox1.Controls.Add(dateTimeInputPickerPurchaseDate);
            groupBox1.Controls.Add(numericUpDownInputStock);
            groupBox1.Controls.Add(numericUpDownInputPrice);
            groupBox1.Controls.Add(textBoxInputProductName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 404);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Data";
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFilePath.Location = new Point(6, 325);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(119, 18);
            labelFilePath.TabIndex = 12;
            labelFilePath.Text = "(No File Selected)";
            // 
            // buttonSaveData
            // 
            buttonSaveData.Location = new Point(157, 357);
            buttonSaveData.Name = "buttonSaveData";
            buttonSaveData.Size = new Size(94, 29);
            buttonSaveData.TabIndex = 11;
            buttonSaveData.Text = "Save Data";
            buttonSaveData.UseVisualStyleBackColor = true;
            buttonSaveData.Click += buttonSaveData_Click;
            // 
            // pictureBoxProductImage
            // 
            pictureBoxProductImage.Location = new Point(157, 217);
            pictureBoxProductImage.Name = "pictureBoxProductImage";
            pictureBoxProductImage.Size = new Size(125, 106);
            pictureBoxProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProductImage.TabIndex = 10;
            pictureBoxProductImage.TabStop = false;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(157, 182);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(94, 29);
            buttonBrowse.TabIndex = 9;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // dateTimeInputPickerPurchaseDate
            // 
            dateTimeInputPickerPurchaseDate.Format = DateTimePickerFormat.Short;
            dateTimeInputPickerPurchaseDate.Location = new Point(157, 145);
            dateTimeInputPickerPurchaseDate.Name = "dateTimeInputPickerPurchaseDate";
            dateTimeInputPickerPurchaseDate.Size = new Size(155, 28);
            dateTimeInputPickerPurchaseDate.TabIndex = 8;
            // 
            // numericUpDownInputStock
            // 
            numericUpDownInputStock.Location = new Point(161, 100);
            numericUpDownInputStock.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownInputStock.Name = "numericUpDownInputStock";
            numericUpDownInputStock.Size = new Size(150, 28);
            numericUpDownInputStock.TabIndex = 7;
            // 
            // numericUpDownInputPrice
            // 
            numericUpDownInputPrice.Location = new Point(162, 62);
            numericUpDownInputPrice.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDownInputPrice.Name = "numericUpDownInputPrice";
            numericUpDownInputPrice.Size = new Size(150, 28);
            numericUpDownInputPrice.TabIndex = 6;
            // 
            // textBoxInputProductName
            // 
            textBoxInputProductName.Location = new Point(162, 24);
            textBoxInputProductName.Name = "textBoxInputProductName";
            textBoxInputProductName.Size = new Size(149, 28);
            textBoxInputProductName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 186);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 4;
            label5.Text = "Product Image:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 145);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 3;
            label4.Text = "Purchase Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 102);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 64);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 1;
            label2.Text = "Price: Rp.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxOutput);
            groupBox2.Controls.Add(buttonNewProduct);
            groupBox2.Controls.Add(buttonOutOfStock);
            groupBox2.Controls.Add(buttonClearData);
            groupBox2.Controls.Add(buttonDisplayAll);
            groupBox2.Location = new Point(353, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 404);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(6, 97);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(262, 298);
            listBoxOutput.TabIndex = 4;
            // 
            // buttonNewProduct
            // 
            buttonNewProduct.Location = new Point(140, 62);
            buttonNewProduct.Name = "buttonNewProduct";
            buttonNewProduct.Size = new Size(128, 29);
            buttonNewProduct.TabIndex = 3;
            buttonNewProduct.Text = "New Product";
            buttonNewProduct.UseVisualStyleBackColor = true;
            buttonNewProduct.Click += buttonNewProduct_Click;
            // 
            // buttonOutOfStock
            // 
            buttonOutOfStock.Location = new Point(6, 62);
            buttonOutOfStock.Name = "buttonOutOfStock";
            buttonOutOfStock.Size = new Size(128, 29);
            buttonOutOfStock.TabIndex = 2;
            buttonOutOfStock.Text = "Out of Stock";
            buttonOutOfStock.UseVisualStyleBackColor = true;
            buttonOutOfStock.Click += buttonOutOfStock_Click;
            // 
            // buttonClearData
            // 
            buttonClearData.Location = new Point(140, 27);
            buttonClearData.Name = "buttonClearData";
            buttonClearData.Size = new Size(128, 29);
            buttonClearData.TabIndex = 1;
            buttonClearData.Text = "Clear Data";
            buttonClearData.UseVisualStyleBackColor = true;
            buttonClearData.Click += buttonClearData_Click;
            // 
            // buttonDisplayAll
            // 
            buttonDisplayAll.Location = new Point(6, 27);
            buttonDisplayAll.Name = "buttonDisplayAll";
            buttonDisplayAll.Size = new Size(128, 29);
            buttonDisplayAll.TabIndex = 0;
            buttonDisplayAll.Text = "Display All";
            buttonDisplayAll.UseVisualStyleBackColor = true;
            buttonDisplayAll.Click += buttonDisplayAll_Click;
            // 
            // FormDataProduk
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 437);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormDataProduk";
            Text = "FormDataProduk";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputPrice).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSaveData;
        private PictureBox pictureBoxProductImage;
        private Button buttonBrowse;
        private DateTimePicker dateTimeInputPickerPurchaseDate;
        private NumericUpDown numericUpDownInputStock;
        private NumericUpDown numericUpDownInputPrice;
        private TextBox textBoxInputProductName;
        private GroupBox groupBox2;
        private ListBox listBoxOutput;
        private Button buttonNewProduct;
        private Button buttonOutOfStock;
        private Button buttonClearData;
        private Button buttonDisplayAll;
        private Label labelFilePath;
    }
}