using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecifiersLibrary
{
    //public----->If the assembly(class library) code  is to be used across another(console app) assembly then the access specifiers to use the class must be public (classes and methods of classes)

    //private---- will only be accessible to that particular class only.
    //protected---allowed only for a child class
    //internal---- accessible only to the containing assembly
    //protected internal---allowed only for a child class and 
    //accessible only to the containing assembly
    public class Employee
    {
        public int Empid { get; set; }
        private string Password { get; set; }
        protected int Salary { get; set; }
        internal string NickName { get; set; }
        protected internal string City { get; set; }
    }

    public class Manager:Employee
    {
        private void UseOfProtected()
        {
            base.Salary = 1000;
            base.City = "Pune";
        }
   }

    class Supervisor
    {

        public void MethodToInternalCall()
        {
            Employee emp = new Employee();
            emp.
        
        
        }
    }
}
