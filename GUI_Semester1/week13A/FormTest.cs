namespace GUI_Semester1
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            textBoxInput.Select();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {

            labelOutput.Text = $"Hello, {textBoxInput.Text}";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            labelOutput.Text = "";
            textBoxInput.Select();
        }
    }
}
