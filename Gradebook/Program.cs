using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Gradebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students:");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in students)
            {
                Console.Write("Grade for " + student + ": ");
                double aGrade = double.Parse(Console.ReadLine());
                grades.Add(aGrade);
            }

            // print roster
            StringBuilder myString = new StringBuilder();

            Console.WriteLine("Student roster:");
            for (int i = 0; i < students.Count; i++)
            {
                myString.Append(students[i] + " (" + grades[i] + ")\n");
            }
            Console.WriteLine(myString);

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);
            
            Console.ReadLine();
        }
    }
}
