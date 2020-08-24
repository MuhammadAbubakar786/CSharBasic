using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.DateTimeManipulation
{
    class Manipulation
    {
        public static DateTime dt = DateTime.Now;
        public static void showDate()
        {
            Console.WriteLine("{0:dd/MM/yyyy}",Manipulation.dt);
        }
    }
}
