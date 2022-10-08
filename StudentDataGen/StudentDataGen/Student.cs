using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataGen
{
    internal class Student
    {
        private string firstname;
        private string lastname;
        private double average;
        private int age;

        public Student(string firstname, string lastname, int age, double average)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.average = average;
        }

        public string GetData()
        {
            return $"{firstname},{lastname},{age},{average};\n";
        }
    }
}
