using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParameterizedConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Student stud1 = new Student(12, "sam", new DateTime(day: 12, month: 09, year: 2010));
            Student stud2 = new Student(11, "Deep", new DateTime(day: 09, month: 11, year: 2009));
            Console.WriteLine("***student one***");
            stud1.Display();

            Console.WriteLine("***Student two***");
            stud2.Display();
            Console.ReadKey();*/  

            Student student = new Student();
            student.Display();
            Student stud1 = new Student( 12, "sam", new DateTime(day:12, month:09, year:2010));
            stud1.Display();
            Console.ReadKey();  
        }
    }
}
