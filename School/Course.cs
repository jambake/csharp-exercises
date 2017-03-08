using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
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
