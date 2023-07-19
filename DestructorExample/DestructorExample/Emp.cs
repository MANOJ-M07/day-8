using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DestructorExample
{
    public  class Emp
    {
        string name;
        public Emp(string name)
        {
            this.name = name;
            Console.WriteLine("Emplyee constructor call");
            Console.WriteLine("Stored Name: \t" +name);
        }

        Emp()
        {
            Console.WriteLine("destrucftor call & name is \t"+name);
        }

        
          


    }
}
