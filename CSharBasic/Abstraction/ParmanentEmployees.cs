using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Abstraction
{
    class ParmanentEmployees:Shared
    {
        public int MonthlySalary { get; set; }

        public override int CalculateSalary()
        {
            return MonthlySalary / 12;
        }
    }
}
