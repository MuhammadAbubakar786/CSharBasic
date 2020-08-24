using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.HashSets
{
    static class Hash
    {
        public static void CreateHashSet()
        {
            HashSet<int> Hashsets = new HashSet<int>();
            HashSet<int> Hashsets1 = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                Hashsets1.Add(2 * i + 2);
            }
            for (int i = 0; i < 10; i++)
            {
                Hashsets.Add(i * 2 + 1);
            }
            HashSet<int> Union = new HashSet<int>(Hashsets1);
            Union.UnionWith(Hashsets);
            Console.WriteLine("Union Of Two Sets");
            foreach (var item in Union)
            {
                Console.WriteLine(item);
            }
            Union.IntersectWith(Hashsets1);
            Console.WriteLine("Intersection Of Two Sets");
            foreach (var item in Union)
            {
                Console.WriteLine(item);
            }
            HashSet<int> Distinct = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
                Distinct.Add(2);
            }
            foreach (var item in Distinct)
            {
                Console.WriteLine("Distinct Values :: " + item);
            }

        }
        
    }
    class Yield
    {
         public static int[] array = new int[] { 1 , 2 ,3 , 4 , 5 };
        public static IEnumerable<int> getYieldResults()
        {
            foreach (var item in array)
            {
                yield return item;

            }
        }
    
    }

}
