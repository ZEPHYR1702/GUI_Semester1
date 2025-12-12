using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Semester1.week13
{
    public partial class FormFavoriteVehicle : Form
    {
        public FormFavoriteVehicle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelSummary1.Text = $"Your favorite is {textBoxInputVehicleColor.Text} {textBoxInputTypesOfVehicle.Text}";
            labelSummary2.Text = $"With {textBoxInputFavoriteNumber.Text} {textBoxInputPartName.Text}";
        }
    }
}
