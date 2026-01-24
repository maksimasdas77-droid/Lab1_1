using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    enum DayWeek
    {
        Monday,
        Sunday,
        Thursday,
        Saturday,
        Friday,
        Tuesday,
        Wednesday
    }
    enum Monts
    {
        janyary,
        febryary,
        mart
    }
class Human
    {
        public string Name { get; set; };
        public string FirstName { get; set; };
        public int Age { };

    }
    internal class Enum
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(DayWeek.Friday);

        }
    }
}

