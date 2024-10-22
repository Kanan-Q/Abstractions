using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    internal class Student
    {
        private double _id = 1;
        public double Id { get; set; }
        public string FullName { get; set; }
        public double Point { get; set; }


        public Student(string fullName, double point)
        {
            Id =_id++;
            FullName = fullName;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id},Name:{FullName},Point:{Point}");
        }
    }
}
