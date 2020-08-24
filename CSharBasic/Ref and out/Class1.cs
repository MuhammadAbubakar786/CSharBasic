using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpBasic.Ref_and_out
{
    class Class1
    {
     public int show(ref int outcome)
        {
            return outcome += 20;
        }
        public int show1(out int outcome)
        {
            outcome = 0;
            return outcome += 20;
        }
        public void writeFile()
        {
            string[] arr = new string[] { "My name is Abubakar","I am a software Engineer"};
            using (StreamWriter writer = new StreamWriter(@"F:\Text.txt"))
            {
                foreach (var item in arr)
                {
                    writer.Write(item);
                }
                writer.Dispose();
            }

        }
        public void readFile()
        {
            List<char> File = new List<char>();
            using (StreamReader reader = new StreamReader(@"F:\Text.txt"))
            {
                foreach (var item in reader.ReadLine())
                {
                    File.Add(item);
                }
                foreach (var data in File)
                {
                    Console.WriteLine(data);
                }

            }
        }


    }
    
}
