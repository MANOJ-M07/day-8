using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructorExample
{
    internal class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("Constructor of Employee");
            id = -1;
            name = "not given";

        }

        public void Register()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("Id : \t"+id);
            Console.WriteLine("Name : \t"+name);
        }
    }
}
