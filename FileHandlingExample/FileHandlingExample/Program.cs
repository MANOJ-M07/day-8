using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string path = "D:\\simplilearn\\day-8\\";
             string fName;
             Console.WriteLine("enter file name");
             fName = Console.ReadLine();
             string fPath = path + fName;

             if(File.Exists(fPath))
             {
                 Console.WriteLine("the file is already existt");
             }
             else
             {
                 File.Create(fPath);
                 Console.WriteLine("file created");
             }
             Console.ReadKey();*/


            //example-2


            /*Console.WriteLine("enter file name");
             string fPath = Console.ReadLine();



             if (File.Exists(fPath))
             {
                 Console.WriteLine("file already there");
             }
             else
             {
                 StreamWriter sw = File.AppendText(fPath);

                 sw.WriteLine("Welcomme to stream writting exaample");
                 sw.Dispose();
                 sw.Close();
                 Console.WriteLine("Created and text is written");
             }
             Console.ReadKey();*/


            //exampe-3

            /* StreamReader sr;
              try
              {
                  string fPath = "D:\\simplilearn\\day-8\\sample.txt";
                  sr = new StreamReader(fPath);
                  string text = "";
                  while ((text = sr.ReadLine()) != null)
                  {
                      Console.WriteLine(text);
                  }
                  sr.Close();     
              }
              catch (Exception ex)
              {
                  Console.WriteLine("Error!!!"+ex.Message);
              }
              finally { Console.ReadKey(); }*/


            //example-4

     
           /* try
            {
                string Path = "D:\\";
                Console.WriteLine("enter the file name ");
                string fName = Console.ReadLine();
                string fPath = Path + fName;
                if (File.Exists(fPath))
                {
                    string[] lines = File.ReadAllLines(fPath);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else { Console.WriteLine("file does not exist"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally { Console.ReadKey(); }*/

            //example-5

            try
            {
                string path = "D:\\";
                Console.WriteLine("Enter file Name to Delete");
                string fName = Console.ReadLine();
                string fpath = path + fName;
                if (File.Exists(fpath))
                {
                    File.Delete(fpath);
                    Console.WriteLine("file delete permanently");
                }
                else { Console.WriteLine("file does not exist"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error"+ex.Message);
            }
            finally { Console.ReadKey(); }

        }
    }
}
