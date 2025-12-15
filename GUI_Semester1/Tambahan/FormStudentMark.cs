using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_Semester1.Tambahan
{
    public partial class FormStudentMark : Form
    {
        public FormStudentMark()
        {
            InitializeComponent();
        }

        int[,] arrNilaiMahasiswa;

        private void buttonInitializeArray_Click(object sender, EventArgs e)
        {
            int jumlahSiswa = int.Parse(textBoxInputStudent.Text);
            int jumlahAssessment = int.Parse(textBoxInputAssestment.Text);
            arrNilaiMahasiswa = new int[jumlahSiswa, jumlahAssessment];
            for (int i = 0; i < jumlahSiswa; i++)
            {
                string rowNumber = "";
                for (int j = 0; j < jumlahAssessment; j++)
                {
                    rowNumber += $" {arrNilaiMahasiswa[i, j]}\t";
                }
                listBoxOutput.Items.Add(rowNumber);
            }

            for (int i = 0; i < arrNilaiMahasiswa.GetLength(0); i++)
            {
                comboBoxInputRow.Items.Add(i + 1);
            }

            for (int i = 0; i < arrNilaiMahasiswa.GetLength(1); i++)
            {
                comboBoxInputColumn.Items.Add(i + 1);
            }
        }

        private void buttonInputMark_Click(object sender, EventArgs e)
        {
            int row = int.Parse(comboBoxInputRow.SelectedItem.ToString()) - 1;
            int column = int.Parse(comboBoxInputColumn.SelectedItem.ToString()) - 1;
            int mark = (int)numericUpDownInputMark.Value;
            listBoxOutput.Items.Clear();
            for (int i = 0; i < arrNilaiMahasiswa.GetLength(0); i++)
            {
                string rowNumber = "";
                for (int j = 0; j < arrNilaiMahasiswa.GetLength(1); j++)
                {
                    if (i == row && j == column)
                    {
                        arrNilaiMahasiswa[i, j] = mark;
                    }
                    rowNumber += $" {arrNilaiMahasiswa[i, j]}\t";
                }
                listBoxOutput.Items.Add(rowNumber);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (radioButtonHighestMark.Checked == true && radioButtonAllStudents.Checked == true)
            {
                for (int i = 0; i < arrNilaiMahasiswa.GetLength(0); i++)
                {
                    int max = arrNilaiMahasiswa[0, 0];
                    for (int j = 0; j < arrNilaiMahasiswa.GetLength(1); j++)
                    {
                        if (arrNilaiMahasiswa[i, j] > max)
                        {
                            max = arrNilaiMahasiswa[i, j];
                        }
                    }
                    listBoxOutput.Items.Add($"Student {i + 1}: {max}");
                }
            }
            else if (radioButtonHighestMark.Checked == true && radioButtonAllAssessment.Checked == true)
            {
                for (int i = 0; i < arrNilaiMahasiswa.GetLength(1); i++)
                {
                    int max = arrNilaiMahasiswa[0, 0];
                    for (int j = 0; j < arrNilaiMahasiswa.GetLength(0); j++)
                    {
                        if (arrNilaiMahasiswa[i, j] > max)
                        {
                            max = arrNilaiMahasiswa[i, j];
                        }
                    }
                    listBoxOutput.Items.Add($"Assessment {i + 1}: {max}");
                }
            }
            else if (radioButtonAverageMark.Checked == true && radioButtonAllStudents.Checked == true)
            {
                for (int i = 0; i < arrNilaiMahasiswa.GetLength(0); i++)
                {
                    int sum = 0;
                    for (int j = 0; j < arrNilaiMahasiswa.GetLength(1); j++)
                    {
                        sum += arrNilaiMahasiswa[i, j];
                    }
                    double average = (double)sum / arrNilaiMahasiswa.GetLength(1);
                    listBoxOutput.Items.Add($"Student {i + 1}: {average}");
                }
            }
            else if (radioButtonAverageMark.Checked == true && radioButtonAllAssessment.Checked == true)
            {
                for (int i = 0; i < arrNilaiMahasiswa.GetLength(1); i++)
                {
                    int sum = 0;
                    for (int j = 0; j < arrNilaiMahasiswa.GetLength(0); j++)
                    {
                        sum += arrNilaiMahasiswa[j, i];
                    }
                    double average = (double)sum / arrNilaiMahasiswa.GetLength(0);
                    listBoxOutput.Items.Add($"Assessment {i + 1}: {average}");
                }
            }
        }
    }
}
