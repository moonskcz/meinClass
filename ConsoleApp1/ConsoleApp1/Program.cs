using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            SchoolClass TITA = new SchoolClass("2ITA");

            for ( int x = 0; x < 30; x++)
            {
                TITA.Humans.Add(new Human(x));
            }

            foreach (Human human in TITA.Humans)
            {
                Console.WriteLine(human.Age);
            }

        }
    }
}
