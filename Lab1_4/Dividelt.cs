using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_4
{
    internal class Dividelt
    {
        static void Main(string[] args)
        {
            try
            {
                //string temp;
                Console.WriteLine("Введите первое целое число");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);
                Console.WriteLine("Введите второе целое число");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                int k = i / j;
                Console.WriteLine($"деление i на j равно: {k}"); // Используйте этот вариант
                Console.WriteLine($"деление i на j равно (с точностью): {k:F3}");
                Console.WriteLine("Press any key.");
                Console.ReadKey();//Console.WriteLine("деление i на j равно: ", k);
            }
            catch (Exception e)
            {
                Console.WriteLine("деление на ноль: {0}", e);
            }
        }
    }
}
