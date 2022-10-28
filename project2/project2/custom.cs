using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project2
{
    internal class custom
    {





        class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
        }

        [Serializable]
        class InvalidStudentNameException : Exception
        {
            public InvalidStudentNameException() { }

            public InvalidStudentNameException(string name)
                : base(String.Format("Invalid Student Name: {0}", name))
            {

            }
        }


    }
}