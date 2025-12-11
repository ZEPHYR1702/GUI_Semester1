namespace GUI_Semester1
{
    partial class FormMaster
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
            comboBoxGroup = new ComboBox();
            comboBoxLatihan = new ComboBox();
            buttonEnter = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Items.AddRange(new object[] { "Tambahan", "Week 13A" });
            comboBoxGroup.Location = new Point(58, 79);
            comboBoxGroup.Margin = new Padding(4);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new Size(213, 33);
            comboBoxGroup.TabIndex = 0;
            comboBoxGroup.Text = "(Pilih week di sini)";
            comboBoxGroup.SelectedIndexChanged += comboBoxGroup_SelectedIndexChanged;
            // 
            // comboBoxLatihan
            // 
            comboBoxLatihan.FormattingEnabled = true;
            comboBoxLatihan.Location = new Point(58, 120);
            comboBoxLatihan.Margin = new Padding(4);
            comboBoxLatihan.Name = "comboBoxLatihan";
            comboBoxLatihan.Size = new Size(213, 33);
            comboBoxLatihan.TabIndex = 1;
            comboBoxLatihan.Text = "(Pilih latihan di sini)";
            comboBoxLatihan.SelectedIndexChanged += comboBoxLatihan_SelectedIndexChanged;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(102, 161);
            buttonEnter.Margin = new Padding(4);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(118, 36);
            buttonEnter.TabIndex = 2;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(242, 25);
            label1.TabIndex = 3;
            label1.Text = "All GUI Latihan (Semester 1)";
            // 
            // FormMaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 230);
            Controls.Add(label1);
            Controls.Add(buttonEnter);
            Controls.Add(comboBoxLatihan);
            Controls.Add(comboBoxGroup);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMaster";
            Text = "FormMaster";
            Load += FormMaster_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGroup;
        private ComboBox comboBoxLatihan;
        private Button buttonEnter;
        private Label label1;
    }
}