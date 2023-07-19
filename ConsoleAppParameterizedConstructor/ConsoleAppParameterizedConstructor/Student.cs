/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParameterizedConstructor
{
    public class Student
    {
        readonly int id;
        readonly string name;   
        readonly DateTime dob;

        public Student (int id, string name, DateTime dob)
        {
            Console.WriteLine("Parameterized Constructor of student");
            this.id = id;
            this.name = name;
            this.dob = dob;
        }
        public void Display()
        {
            Console.WriteLine("Student Details as follows");
            Console.WriteLine("ID:->"+id +"\tName:"+name+"\tdob:->"+dob);
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParameterizedConstructor
{
    public class Student
    {
         int id;
         string name;
         DateTime dob;

        public Student()
        {
            Console.WriteLine("Default Constructor");
        }
        public Student(int id, string name, DateTime dob)
        {
            Console.WriteLine("Parameterized Constructor of student");
            this.id = id;
            this.name = name;
            this.dob = dob;
        }
        public void Display()
        {
            Console.WriteLine("Student Details as follows");
            Console.WriteLine("ID:->" + id + "\tName:" + name + "\tdob:->" + dob);
        }
    }
}