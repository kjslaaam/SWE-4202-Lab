using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IUT_RPS
{
    public partial class Form1 : Form
    {
        List<string> listA = new List<string>();
        List<string> listB = new List<string>();
        List<string> listC = new List<string>();
        List<string> listD = new List<string>();
        List<string> listE = new List<string>();
        List<string> listF = new List<string>();
        List<string> listG = new List<string>();
        List<string> listH = new List<string>();
        List<string> listI = new List<string>();
        List<string> listJ = new List<string>();
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Student> students = new List<Student>();
            using(var reader = new StreamReader(@"C:\Users\kazij\Google Drive (jawadulislam2@iut-dhaka.edu)\IUT\2nd Semester\SWE_4202 Object Oriented Concepts 1 Lab\Sessional Final\IUT RPS\SWE4201MarkSheet.csv"))
            {
                int i = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(values[0]);
                    listB.Add(values[1]);
                    listC.Add(values[2]);
                    listD.Add(values[3]);
                    listE.Add(values[4]);
                    listF.Add(values[5]);
                    listG.Add(values[6]);
                    listH.Add(values[7]);
                    listI.Add(values[8]);
                    listJ.Add(values[9]);
                    
                    Student student = new Student();
                    student.Id = listA[i];
                    student.Name = listB[i];
                    student.Attendance = listC[i];
                    student.Q1 = listD[i];
                    student.Q2 = listE[i];
                    student.Q3 = listF[i];
                    student.Q4 = listG[i];
                    student.Mid = listH[i];
                    student.Final = listI[i];
                    student.Viva = listJ[i];
                    students.Add(student);
                    i++;
                }
            }
            StudentListBox.Items.Add("ID\tName\tPercentage\tGrade");
            foreach (Student student in students)
            {
                student.CalcBestThree();
                student.CalcTotal();
                student.CalcPercentage();
                student.CalcGrade();
                StudentListBox.Items.Add(student.GetInfo());
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var selected = from student in students
                           where student.Id == IDTextBox.Text
                           select student;
            foreach (Student student in selected)
            {
                AttendanceLabel.Text = "Attendance: " + student.Attendance;
                Q1Label.Text = "Quiz 1: " + student.Q1;
                Q2Label.Text = "Quiz 2: " + student.Q2;
                Q3Label.Text = "Quiz 3: " + student.Q3;
                Q4Label.Text = "Quiz 4: " + student.Q4;
                QTLabel.Text ="Quiz Total (Best of 3): "+ Convert.ToString(Math.Round(student.QuizTotal,2));
                MidLabel.Text="Mid: "+ student.Mid;
                FinalLabel.Text = "Final: " + student.Final;
                VivaLabel.Text = "Viva: "+ student.Viva;
                TotalLabel.Text="Total (Out of 300): "+ Convert.ToString(Math.Round(student.Total,2));
                PercentageLabel.Text="Percentage: " + Convert.ToString(Math.Round(student.Percentage, 2));
                GradeLabel.Text= "Grade: "+student.Grade;
            }
        }
    }
}
