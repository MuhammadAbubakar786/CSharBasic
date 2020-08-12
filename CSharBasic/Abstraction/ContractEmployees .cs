using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Abstraction
{
    class ContractEmployees:Shared
    {
        public int HourlyPay { get; set; }
        public int TotalWorkingHours { get; set; }
     
        public override int CalculateSalary()
        {
            return  HourlyPay * TotalWorkingHours;
        }
    }
}
