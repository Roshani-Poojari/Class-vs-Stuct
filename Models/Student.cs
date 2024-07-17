using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStrucDiff.Models
{
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public Student(int rollNo, string name)
        {
            RollNo = rollNo;
            Name = name;
        }
    }
}
