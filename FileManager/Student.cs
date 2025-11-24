using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    internal class Student
    {
        public string lastName;
        public string firstName;
        public int age;
        public int point;

        public Student(string lastName, string firstName, int age, int point)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
            this.point = point;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{lastName}{firstName} : {age} => 점수 {point}");
        }

        public override string ToString()
        {
            return $"{lastName},{firstName},{age},{point}";
        }
    }
}
