using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lab1_1
    {
        static void Main(string[] args)
        {
            string myName;
            //string myValue;
            //string myValue2;
            Console.WriteLine("Введите вваше имя");
            Console.WriteLine("Ну можно и не вводить, просто напиши что-нибудь для выполнения задания");
            myName = Console.ReadLine();// как я понимаю, это мы ситываем строку
            //myValue = Console.ReadLine();
            //myValue2 = Console.ReadLine(); // короче, эти строки вводятся, но на выводе надо писать {0} для первой строки {1} второй строки {2} третьей строки и дописывать их наименования в конце через запятую
            Console.WriteLine("Привет, {0}, как дела?", myName); //а тут выводим эту строку, но почему она ноль, а не название переменной я в душе не знаю
            Console.WriteLine("Press any key.");
            Console.ReadKey();

        }
    }
}
//namespace ConsoleApp2
//{

//}