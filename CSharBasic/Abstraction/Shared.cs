using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Abstraction
{
    abstract class Shared
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string getFullName()
        {
            return FirstName + " " + LastName;
        }
        public abstract int CalculateSalary();
      
    }
}
