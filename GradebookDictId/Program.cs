using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradebookDictId
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;
            int studentID = 0;
            Console.WriteLine("Enter your students:");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    studentID += 1;
                    students.Add(studentID, newStudent);
                }
            }
            while (newStudent != "");

            // print roster
            Console.WriteLine("Student roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine("ID: " + student.Key + " Name: " + student.Value + "");
            }

            Console.ReadLine();
        }
    }
}
