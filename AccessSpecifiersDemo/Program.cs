using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecifiersLibrary;
namespace AccessSpecifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.Empid = 101;
            //emp.Password = "abc@123";
            //ATMMachine machine = new ATMMachine();
            //machine.ShowMenu();

            Person p = new Person();
            p[0] = "CH";
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
            Console.WriteLine(p[2]);
            Console.WriteLine(p[3]);
            Console.WriteLine(p[4]);



            Console.Read();
        }
    }
}
