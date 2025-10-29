using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_oop
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public char Gender { get; set; }

        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddName(string surname)
        {
            Name = Name + " " + surname;
        }
        public string GetInfo()
        {
            return $" Name: {Name}\n Age: {Age}\n Gender : {Gender}\n Adress : {Adress}\n";
        }
    }
}
