using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT_RPS
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Attendance { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Mid { get; set; }
        public string Final { get; set; }
        public string Viva { get; set; }
        public double QuizTotal { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }
        public string Grade { get; set; }
        public void CalcBestThree()
        {
            double q1 = Convert.ToDouble(this.Q1);
            double q2 = Convert.ToDouble(this.Q2);
            double q3 = Convert.ToDouble(this.Q3);
            double q4 = Convert.ToDouble(this.Q4);
            double[] quizzes = { q1, q2, q3, q4 };
            Array.Sort(quizzes);
            this.QuizTotal= quizzes[1]+quizzes[2]+quizzes[3];
        }
        public void CalcTotal()
        {
            this.Total = Convert.ToDouble(this.Mid)+Convert.ToDouble(this.Viva)+Convert.ToDouble(this.Final)+this.QuizTotal;
        }
        public void CalcPercentage()
        {
            this.Percentage = this.Total/3;
        }
        public void CalcGrade()
        {
            if ((this.Percentage >= 80) && (this.Percentage <= 100))
                this.Grade = "A+";
            else if ((this.Percentage >= 75) && (this.Percentage < 80))
                this.Grade = "A";
            else if ((this.Percentage >= 70) && (this.Percentage < 75))
                this.Grade = "A-";
            else if ((this.Percentage >= 65) && (this.Percentage < 70))
                this.Grade = "B+";
            else if ((this.Percentage >= 60) && (this.Percentage < 65))
                this.Grade = "B";
            else if ((this.Percentage >= 55) && (this.Percentage < 60))
                this.Grade = "B-";
            else if ((this.Percentage >= 50) && (this.Percentage < 55))
                this.Grade = "C";
            else if ((this.Percentage >= 45) && (this.Percentage < 50))
                this.Grade = "C-";
            else if ((this.Percentage >= 40) && (this.Percentage < 45))
                this.Grade = "D";
            else
                this.Grade = "F";
        }
        public string GetInfo()
        {
            return this.Id +"\t"+this.Name+"\t"+Convert.ToString(Math.Round(this.Percentage,2))+"\t"+this.Grade;
        }
    }
}
