using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    internal class Group
    {
        public string GroupNo { get; set; }
        public double StudentLimit { get; set; }
        private Student[] students;

        public Group(string groupNo, double studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
        public Group(double limit)
        {
            students = new Student[0];
            StudentLimit = limit;
        }

        public void AddStudent(Student student)
        {

            if (StudentLimit > students.Length)
            {
                Array.Resize(ref students, students.Length);
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Yer yoxdur");
            }
        }
        public void GetStudent(int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Id == id)
                {
                    Console.WriteLine("Adi:" + students[i].FullName);
                    Console.WriteLine("Bali:" + students[i].Point);

                }
            }


        }
        public bool CheckGroupNo(string group)
        {
            bool group_name;
            if (group.Length ==4)
            {
                group_name = true;
            }
            else
            {
                group_name = false;
            }
            return group_name;
        }


        public void GetAllStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Id:{students[i].Id},Name:{students[i].FullName},Point:{students[i].Point}");
            }
        }


    }
}
