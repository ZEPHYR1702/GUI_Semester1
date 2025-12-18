using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Semester1.week14B
{
    public partial class FormGajiPegawai : Form
    {
        public FormGajiPegawai()
        {
            InitializeComponent();
        }

        //global variable
        List<string> listEmployeeId = new List<string>();
        List<string> listSalary = new List<string>();

        private int CalculateChildrenAllowance(string gender, int numOfChildren, int basicSalary)
        {
            int childrenAllowance;

            if (numOfChildren >= 3)
            {
                numOfChildren = 3;
            }

            if (gender.ToLower() == "female")
            {
                childrenAllowance = 0;
            }
            else
            {
                childrenAllowance = (int)(basicSalary * 0.10) * numOfChildren;
            }
            return childrenAllowance;
        }

        private int CalculateBonus(bool outsource, DateTime startWork, string jobPosition, int basicSalary)
        {
            int bonus;
            DateTime limitDate = new DateTime(2025, 12, 1);
            if ((outsource == true && startWork < limitDate) || jobPosition.ToLower() == "staff")
            {
                bonus = 0;
            }
            else if (jobPosition.ToLower() == "supervisor")
            {
                bonus = (int)(basicSalary * 0.20);
            }
            else
            {
                bonus = (int)(basicSalary * 0.25);
                if (bonus > 1000000)
                {
                    bonus = 1000000;
                }
            }
            return bonus;
        }

        private int CalculatePPH(string gender, int numOfChildren, int totalSalary)
        {
            int PTKP;
            if (gender.ToLower() == "female")
            {
                PTKP = 4000000;
            }
            else
            {
                if (numOfChildren == 0)
                {
                    PTKP = 5000000;
                }
                else if (numOfChildren == 1)
                {
                    PTKP = 5500000;
                }
                else if (numOfChildren == 2)
                {
                    PTKP = 6000000;
                }
                else
                {
                    PTKP = 6750000;
                }
            }

            double PPH = 0.10 * (totalSalary - PTKP);

            if (totalSalary < 5000000)
            {
                PPH = 0;
            }
            return (int)PPH;
        }

        private void CalculateTakeHomePay(string gender, int numOfChildren, int basicSalary, bool outsource, DateTime startWork, string jobPosition, out int childAllowance, out int bonus, out int pph, out int takeHomePay)
        {
            bonus = CalculateBonus(outsource, startWork, jobPosition, basicSalary);
            childAllowance = CalculateChildrenAllowance(gender, numOfChildren, basicSalary);
            int totalSalary = basicSalary + childAllowance + bonus;
            pph = CalculatePPH(gender, numOfChildren, totalSalary);
            takeHomePay = basicSalary + childAllowance + bonus - pph;
        }

        private void DisplaySalaryReport(string emplyoyeeId, int takeHomePay)
        {
            DateTime now = DateTime.Now;
            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add("EMPLOYEE SALARY REPORT");
            listBoxOutput.Items.Add("===================================");
            listBoxOutput.Items.Add($"Date: {now.ToString()}");
            listBoxOutput.Items.Add($"Employee ID: {emplyoyeeId}");
            listBoxOutput.Items.Add($"Take Home Pay: Rp.{takeHomePay.ToString("N0")}");
            listBoxOutput.Items.Add("===================================");
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            string employeeId = textBoxEmployeeID.Text;
            string gender;
            if (radioButtonGenderMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string jobPosition = comboBoxPosition.SelectedItem.ToString();
            bool outsource = checkBoxOutsource.Checked;
            DateTime startWork = dateTimePickerStartWork.Value;
            int numOfChildren = (int)numericUpDownNumberOfChildren.Value;
            int basicSalary = int.Parse(textBoxBasicSalary.Text);
            int takeHomePay, bonus, pph, childAllowance;

            CalculateTakeHomePay(gender, numOfChildren, basicSalary, outsource, startWork, jobPosition, out childAllowance, out bonus, out pph, out takeHomePay);
            DisplaySalaryReport(employeeId, takeHomePay);

            MessageBox.Show($"Save data success {Environment.NewLine}Employee ID: {employeeId} {Environment.NewLine}Child Allowance: Rp.{childAllowance.ToString("N0")} {Environment.NewLine}Bonus: Rp.{bonus.ToString("N0")} {Environment.NewLine}PPH: Rp.{pph.ToString("N0")} {Environment.NewLine}Take Home Pay: Rp.{takeHomePay.ToString("N0")}");

            listEmployeeId.Add(employeeId);
            listSalary.Add(takeHomePay.ToString("N0"));
        }

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            for (int i = 0; i < listEmployeeId.Count; i++)
            {
                DateTime now = DateTime.Now;
                listBoxOutput.Items.Add("EMPLOYEE SALARY REPORT");
                listBoxOutput.Items.Add("===================================");
                listBoxOutput.Items.Add($"Date: {now.ToString()}");
                listBoxOutput.Items.Add($"Employee ID: {listEmployeeId[i]}");
                listBoxOutput.Items.Add($"Salary (Take Home Pay): Rp.{listSalary[i]}");
                listBoxOutput.Items.Add("===================================");
                listBoxOutput.Items.Add("");
            }
        }
    }
}
