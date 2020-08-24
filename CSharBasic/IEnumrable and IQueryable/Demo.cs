using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.IEnumrable_and_IQueryable
{
    public class Demo1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    class Database
    {
        public static List<Demo1> Data()
        {
            List<Demo1> demo = new List<Demo1>();
            demo.Add(new Demo1 { ID = 101, Name = "Abubakar", Marks = 100 });
            demo.Add(new Demo1 { ID = 102, Name = "Ali", Marks = 50 });
            demo.Add(new Demo1 { ID = 103, Name = "Ahmed", Marks = 60 });
            demo.Add(new Demo1 { ID = 104, Name = "Hassan", Marks = 40 });
            demo.Add(new Demo1 { ID = 105, Name = "Umar", Marks = 30 });
            demo.Add(new Demo1 { ID = 106, Name = "Ahmer", Marks = 80 });
            return demo;
        }

    }
}
