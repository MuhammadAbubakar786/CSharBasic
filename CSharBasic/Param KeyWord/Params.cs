using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpBasic.Param_KeyWord
{
    class Params
    {
        public int CalculateTotalMarks(string status, params int[] args)
        {
            int totalMarks = 0;
                foreach (var item in args)
                {
                    totalMarks += item;
                }

            Console.WriteLine("Status :: "+status);
            return totalMarks;
        }
    }
}
