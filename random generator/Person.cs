using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace random_generator
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string _name, string _surname)
        {
            Name = _name;
            Surname = _surname;
        }
    }    
} 