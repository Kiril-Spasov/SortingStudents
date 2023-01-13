using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingStudents
{
    public partial class FormSorting : Form
    {
        public FormSorting()
        {
            InitializeComponent();
        }

        private void BtnSortStudents_Click(object sender, EventArgs e)
        {
            int clases;
            int studentsCount;
            string[] students = new string[100];

            string path = Application.StartupPath + @"\sorting.txt";
            StreamReader streamReader = new StreamReader(path);

            clases = Convert.ToInt32(streamReader.ReadLine());
            studentsCount = Convert.ToInt32(streamReader.ReadLine());

            for (int i = 0; i < clases; i++)
            {
                for (int j = 0; j < studentsCount; j++)
                {
                    students[j] = streamReader.ReadLine();
                }

                SortStudents(students, studentsCount);

                TxtResult.Text += "Class #" + (i + 1) + " ordering: " + Environment.NewLine;

                for (int j = 0; j < studentsCount; j++)
                {
                    TxtResult.Text += students[j] + Environment.NewLine;
                }

                studentsCount = Convert.ToInt32(streamReader.ReadLine());
            }
        }

        private void SortStudents(string[] students, int studentsCount)
        {
            int minLocation;

            for (int i = 0; i < studentsCount - 1; i++)
            {
                minLocation = i;

                for (int j = i + 1; j < studentsCount; j++)
                {
                    if (!NameIsGreater(students[minLocation], students[j]))
                    {
                        minLocation = j;
                    }
                }
                SwapStudents(students, i, minLocation);
            }
        }

        private bool NameIsGreater(string student1, string student2)
        {
            bool isGreater = false;

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] student1Letters = new int[26];
            int[] student2Letters = new int[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < student1.Length; j++)
                {
                    if (student1[j] == alphabet[i])
                    {
                        student1Letters[i]++;
                    }
                }

                for (int j = 0; j < student2.Length; j++)
                {
                    if (student2[j] == alphabet[i])
                    {
                        student2Letters[i]++;
                    }
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (student1Letters[i] > student2Letters[i])
                {
                    isGreater = true;
                    break;
                }
                else if (student2Letters[i] > student1Letters[i])
                {
                    isGreater = false;
                    break;
                }
            }

            return isGreater;
        }

        private void SwapStudents(string[] students, int student1Index, int student2Index)
        {
            string temp = "";
            temp = students[student1Index];
            students[student1Index] = students[student2Index];
            students[student2Index] = temp;
        }
    }
}
