using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human
    {

        public int Age = 18;
        public string Name = "Jamie";
        public string Surname = "Surname";

        public Human (int age)
        {
            Age = age;
        }

        public Human ( int age, string name, string surname)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }

    }
}
