using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Interface
{
    interface ICustomer
    {
        void Print();
    }
    interface ICustomer2:ICustomer
    {
        void Print1();
    }

    public class Demo : ICustomer2
    {
        public void Print()
        {
            Console.WriteLine("Print Method of Interfce ICustomer ");
        }
        public void Print1()
        {
            Console.WriteLine("Print Method of Interfce ICustomer2 ");
        }
    }
}
