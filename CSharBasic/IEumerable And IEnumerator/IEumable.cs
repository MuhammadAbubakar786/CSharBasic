using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.IEumerable_And_IEnumerator
{
    class IEumable
    {
        public void getNintees(IEnumerable<int> enumrable)
        {
            foreach (var item in enumrable)
            {
                if (item > 2000)
                {
                    getTwentees(enumrable);
                }
                Console.WriteLine("Using Enumrator :: " + item);
            }
        }
        public void getTwentees(IEnumerable<int> enumrable)
        {
            foreach (var item in enumrable)
            {
                Console.WriteLine("Using Enumrator :: " + item);
            }
        }
    }

}
