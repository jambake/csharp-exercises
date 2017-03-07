using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Student
    {
        private string name;
        private int studentID;
        private int numberOfCredits = 0;
        private double gpa = 0.0;
        private string gradeLevel;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Name must be a valid string.");
                }
                name = value;
            }
        }
        public int StudentID
        {
            get { return studentID; }
            set
            {
                if (studentID < 1)
                {
                    throw new ArgumentException("Student ID must be a positive number.");
                }
                studentID = value;
            }
        }
        public int NumberOfCredits
        {
            get { return numberOfCredits; }
            set { numberOfCredits = value; }
        }
        public double GPA
        {
            get { return gpa; }
            internal set { gpa = value; }
        }
        public string GradeLevel
        {
            get { return gradeLevel; }
            set { gradeLevel = value; }
        }
    }

    public class Course
    {
        private string courseName;
        private int credits;
        private Dictionary<Student, string> numOfStudents;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public int Credits
        {
            get { return credits; }
            internal set { credits = value; }
        }
        public Dictionary<Student, string> NumOfStudents
        {
            get { return numOfStudents; }
            set { numOfStudents = value; }
        }
    }
}
