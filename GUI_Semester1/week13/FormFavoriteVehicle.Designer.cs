namespace GUI_Semester1.week13
{
    partial class FormFavoriteVehicle
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
            labelSummary1 = new Label();
            labelSummary2 = new Label();
            textBoxInputTypesOfVehicle = new TextBox();
            textBoxInputVehicleColor = new TextBox();
            textBoxInputPartName = new TextBox();
            textBoxInputFavoriteNumber = new TextBox();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(85, 14);
            label1.TabIndex = 0;
            label1.Text = "Type of vehicle:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 70);
            label2.Name = "label2";
            label2.Size = new Size(72, 14);
            label2.TabIndex = 1;
            label2.Text = "Vehicle color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 96);
            label3.Name = "label3";
            label3.Size = new Size(63, 14);
            label3.TabIndex = 2;
            label3.Text = "Part Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 122);
            label4.Name = "label4";
            label4.Size = new Size(94, 14);
            label4.TabIndex = 3;
            label4.Text = "Favorite Number:";
            // 
            // labelSummary1
            // 
            labelSummary1.AutoSize = true;
            labelSummary1.Location = new Point(38, 191);
            labelSummary1.Name = "labelSummary1";
            labelSummary1.Size = new Size(61, 14);
            labelSummary1.TabIndex = 4;
            labelSummary1.Text = "Summary1";
            // 
            // labelSummary2
            // 
            labelSummary2.AutoSize = true;
            labelSummary2.Location = new Point(38, 213);
            labelSummary2.Name = "labelSummary2";
            labelSummary2.Size = new Size(61, 14);
            labelSummary2.TabIndex = 5;
            labelSummary2.Text = "Summary2";
            // 
            // textBoxInputTypesOfVehicle
            // 
            textBoxInputTypesOfVehicle.Location = new Point(136, 38);
            textBoxInputTypesOfVehicle.Name = "textBoxInputTypesOfVehicle";
            textBoxInputTypesOfVehicle.Size = new Size(86, 22);
            textBoxInputTypesOfVehicle.TabIndex = 6;
            // 
            // textBoxInputVehicleColor
            // 
            textBoxInputVehicleColor.Location = new Point(136, 66);
            textBoxInputVehicleColor.Name = "textBoxInputVehicleColor";
            textBoxInputVehicleColor.Size = new Size(86, 22);
            textBoxInputVehicleColor.TabIndex = 7;
            // 
            // textBoxInputPartName
            // 
            textBoxInputPartName.Location = new Point(136, 94);
            textBoxInputPartName.Name = "textBoxInputPartName";
            textBoxInputPartName.Size = new Size(86, 22);
            textBoxInputPartName.TabIndex = 8;
            // 
            // textBoxInputFavoriteNumber
            // 
            textBoxInputFavoriteNumber.Location = new Point(136, 122);
            textBoxInputFavoriteNumber.Name = "textBoxInputFavoriteNumber";
            textBoxInputFavoriteNumber.Size = new Size(86, 22);
            textBoxInputFavoriteNumber.TabIndex = 9;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(158, 158);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(64, 22);
            buttonOK.TabIndex = 10;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormFavoriteVehicle
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 260);
            Controls.Add(buttonOK);
            Controls.Add(textBoxInputFavoriteNumber);
            Controls.Add(textBoxInputPartName);
            Controls.Add(textBoxInputVehicleColor);
            Controls.Add(textBoxInputTypesOfVehicle);
            Controls.Add(labelSummary2);
            Controls.Add(labelSummary1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormFavoriteVehicle";
            Text = "FormFavoriteVehicle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelSummary1;
        private Label labelSummary2;
        private TextBox textBoxInputTypesOfVehicle;
        private TextBox textBoxInputVehicleColor;
        private TextBox textBoxInputPartName;
        private TextBox textBoxInputFavoriteNumber;
        private Button buttonOK;
    }
}