using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.IEumerable_And_IEnumerator
{
    class IEnumrator
    {
        public void getNintees(IEnumerator<int> values)
        {
           
            while (values.MoveNext())
            {
                if(values.Current >= 2000)
                {
                    getTweenties(values);
                }

                Console.WriteLine("Using Enumrator Values :: "+ values.Current);
            }
        }

        private void getTweenties(IEnumerator<int> values)
        {
            
            Console.WriteLine("--------------------Get Twentees Values-------------------------");
            while (values.MoveNext())
            {
                Console.WriteLine("Using Enumrator Values :: " + values.Current);
            }
        }
    }
}
