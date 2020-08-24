using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Getter_Setter
{
    class Student
    {
        
        private int ID;
        private string Name;
        private int Marks;
        #region GetterSetter
        public void setId(int id)
        {
            if(id > 0)
                ID = id;
            else
            {
                throw new Exception("ID cannot be a Negative number or equal to 0!!");
            }
        }
        public int GetID()
        {
            return ID;
        }

        public void setName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Name cannot be a Null ");
            else
                this.Name = Name;
        }
        public string getName()
        {
            return Name;
        }

        public void setMarks(int marks)
        {
            if (marks >= 0)
                Marks = marks;

            else
                throw new Exception("Marks cannot be a Negative Number !!!!");
        }
        public int getMarks()
        {
            return Marks;
        }
        #endregion
    }
}
