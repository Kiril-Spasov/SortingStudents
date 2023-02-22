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

            //Read total classes
            clases = Convert.ToInt32(streamReader.ReadLine());

            //Read how many students in each class
            studentsCount = Convert.ToInt32(streamReader.ReadLine());

            //Go through all classes
            for (int i = 0; i < clases; i++)
            {
                //Go through all students
                for (int j = 0; j < studentsCount; j++)
                {
                    //Store each student in the array
                    students[j] = streamReader.ReadLine();
                }

                SortStudents(students, studentsCount);

                //Display result
                TxtResult.Text += "Class #" + (i + 1) + " ordering: " + Environment.NewLine;

                for (int j = 0; j < studentsCount; j++)
                {
                    TxtResult.Text += students[j] + Environment.NewLine;
                }

                //Write the new value for the number of students for the next class
                studentsCount = Convert.ToInt32(streamReader.ReadLine());
            }
        }

        private void SortStudents(string[] students, int studentsCount)
        {
            //Apply exchange sort - we go through all students and put the correct student in front
            //then start from pos 2 in the array and do the same
            //repeat until we reach the end of the array
            //for better performance - we store the location and we swap the item only when we check all
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

            //Array counters
            int[] student1Letters = new int[26];
            int[] student2Letters = new int[26];

            //We count how many of each letter in the alphabet the students names contains
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

            //Starting from 'A' compare each counter for both students and set the flag accordingly
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

        //Implementing the swap routine
        private void SwapStudents(string[] students, int student1Index, int student2Index)
        {
            string temp = "";
            temp = students[student1Index];
            students[student1Index] = students[student2Index];
            students[student2Index] = temp;
        }
    }
}
