namespace GUI_Semester1
{
    partial class FormTest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonProses = new Button();
            textBoxInput = new TextBox();
            labelOutput = new Label();
            buttonReset = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter Name";
            // 
            // buttonProses
            // 
            buttonProses.Location = new Point(314, 32);
            buttonProses.Margin = new Padding(4, 5, 4, 5);
            buttonProses.Name = "buttonProses";
            buttonProses.Size = new Size(107, 35);
            buttonProses.TabIndex = 1;
            buttonProses.Text = "Proses";
            buttonProses.UseVisualStyleBackColor = true;
            buttonProses.Click += buttonProses_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(144, 32);
            textBoxInput.Margin = new Padding(4, 5, 4, 5);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(141, 29);
            textBoxInput.TabIndex = 2;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(22, 89);
            labelOutput.Margin = new Padding(4, 0, 4, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 23);
            labelOutput.TabIndex = 3;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(314, 77);
            buttonReset.Margin = new Padding(4, 5, 4, 5);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(107, 35);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(314, 121);
            buttonExit.Margin = new Padding(4, 5, 4, 5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(107, 35);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 181);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(labelOutput);
            Controls.Add(textBoxInput);
            Controls.Add(buttonProses);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormTest";
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonProses;
        private TextBox textBoxInput;
        private Label labelOutput;
        private Button buttonReset;
        private Button buttonExit;
    }
}
