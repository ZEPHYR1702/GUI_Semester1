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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxInputProductName = new TextBox();
            numericUpDownInputPrice = new NumericUpDown();
            numericUpDownInputStock = new NumericUpDown();
            dateTimeInputPickerPurchaseDate = new DateTimePicker();
            buttonBrowse = new Button();
            pictureBoxProductImage = new PictureBox();
            buttonSaveData = new Button();
            groupBox2 = new GroupBox();
            buttonDisplayAll = new Button();
            buttonClearData = new Button();
            buttonOutOfStock = new Button();
            buttonNewProduct = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Size = new Size(335, 349);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Data";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 64);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 1;
            label2.Text = "Price: Rp.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 102);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
            label3.Click += this.label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 145);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 3;
            label4.Text = "Purchase Date:";
            label4.Click += this.label4_Click;
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
            // textBoxInputProductName
            // 
            textBoxInputProductName.Location = new Point(162, 24);
            textBoxInputProductName.Name = "textBoxInputProductName";
            textBoxInputProductName.Size = new Size(149, 28);
            textBoxInputProductName.TabIndex = 5;
            // 
            // numericUpDownInputPrice
            // 
            numericUpDownInputPrice.Location = new Point(162, 62);
            numericUpDownInputPrice.Name = "numericUpDownInputPrice";
            numericUpDownInputPrice.Size = new Size(150, 28);
            numericUpDownInputPrice.TabIndex = 6;
            // 
            // numericUpDownInputStock
            // 
            numericUpDownInputStock.Location = new Point(161, 100);
            numericUpDownInputStock.Name = "numericUpDownInputStock";
            numericUpDownInputStock.Size = new Size(150, 28);
            numericUpDownInputStock.TabIndex = 7;
            numericUpDownInputStock.ValueChanged += this.numericUpDownInputStock_ValueChanged;
            // 
            // dateTimeInputPickerPurchaseDate
            // 
            dateTimeInputPickerPurchaseDate.Location = new Point(157, 145);
            dateTimeInputPickerPurchaseDate.Name = "dateTimeInputPickerPurchaseDate";
            dateTimeInputPickerPurchaseDate.Size = new Size(155, 28);
            dateTimeInputPickerPurchaseDate.TabIndex = 8;
            dateTimeInputPickerPurchaseDate.ValueChanged += this.dateTimeInputPickerPurchaseDate_ValueChanged;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(157, 182);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(94, 29);
            buttonBrowse.TabIndex = 9;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProductImage
            // 
            pictureBoxProductImage.Location = new Point(157, 217);
            pictureBoxProductImage.Name = "pictureBoxProductImage";
            pictureBoxProductImage.Size = new Size(125, 62);
            pictureBoxProductImage.TabIndex = 10;
            pictureBoxProductImage.TabStop = false;
            // 
            // buttonSaveData
            // 
            buttonSaveData.Location = new Point(157, 285);
            buttonSaveData.Name = "buttonSaveData";
            buttonSaveData.Size = new Size(94, 29);
            buttonSaveData.TabIndex = 11;
            buttonSaveData.Text = "Save Data";
            buttonSaveData.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(buttonNewProduct);
            groupBox2.Controls.Add(buttonOutOfStock);
            groupBox2.Controls.Add(buttonClearData);
            groupBox2.Controls.Add(buttonDisplayAll);
            groupBox2.Location = new Point(353, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 337);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // buttonDisplayAll
            // 
            buttonDisplayAll.Location = new Point(6, 27);
            buttonDisplayAll.Name = "buttonDisplayAll";
            buttonDisplayAll.Size = new Size(128, 29);
            buttonDisplayAll.TabIndex = 0;
            buttonDisplayAll.Text = "Display All";
            buttonDisplayAll.UseVisualStyleBackColor = true;
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
            // buttonOutOfStock
            // 
            buttonOutOfStock.Location = new Point(6, 62);
            buttonOutOfStock.Name = "buttonOutOfStock";
            buttonOutOfStock.Size = new Size(128, 29);
            buttonOutOfStock.TabIndex = 2;
            buttonOutOfStock.Text = "Out of Stock";
            buttonOutOfStock.UseVisualStyleBackColor = true;
            // 
            // buttonNewProduct
            // 
            buttonNewProduct.Location = new Point(140, 62);
            buttonNewProduct.Name = "buttonNewProduct";
            buttonNewProduct.Size = new Size(128, 29);
            buttonNewProduct.TabIndex = 3;
            buttonNewProduct.Text = "New Product";
            buttonNewProduct.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(262, 214);
            listBox1.TabIndex = 4;
            // 
            // FormDataProduk
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 380);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormDataProduk";
            Text = "FormDataProduk";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInputStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).EndInit();
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
        private ListBox listBox1;
        private Button buttonNewProduct;
        private Button buttonOutOfStock;
        private Button buttonClearData;
        private Button buttonDisplayAll;
    }
}