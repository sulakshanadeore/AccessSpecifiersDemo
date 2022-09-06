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
            ATMMachine machine = new ATMMachine();
            machine.ShowMenu();
            Console.Read();
        }
    }
}
