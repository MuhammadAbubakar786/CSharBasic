using System;
using System.Collections.Generic;
using System.Text;
namespace CSharpBasic.AccessModifiers
{
    public class Modifier
    {
        #region Property
        private int ID;
        protected string Name;
        public int id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        #endregion
    }
    public class Child : Modifier
    {
       public void Print()
        {
            Console.WriteLine(base.Name="Abubakar"); 
        }  
    }
    
}
