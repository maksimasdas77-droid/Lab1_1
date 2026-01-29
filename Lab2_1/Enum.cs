using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
   enum AccountType
    {
        checking,
        deposit,
        savings,
        credit
    }
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
        january,
        february,
        march,
        april,
        may,
        june,
        july,
        august,
        september,
        october,
        november,
        december
    }
    internal class Enum
    {
       
        static void Main(string[] args)
        {
            //while (true) {
            //    Console.Clear();
            //    Console.WriteLine("Введи число месяца (или 0 для выхода):");
            //string input = Console.ReadLine();
            //    int i;
            //    if (!int.TryParse(input, out i))
            //    {
            //        Console.WriteLine("Ошибка: нужно ввести число!"); continue; // возвращаемся в начало цикла }
            //    }
            //    if (i == 0) { Console.WriteLine("Выход из программы..."); break; }
            //    i = i - 1;
            //    if (i >= 0 && i < 12)
            //    {
            //        Console.WriteLine((Monts)i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Нет такого месяца у тебя, либо добавь, либо напиши другой вариант");

            //    }
            //    Console.WriteLine("Нажми любую клавишу..."); 
            //    Console.ReadKey();
            //}
            AccountType account1 = AccountType.checking;
            AccountType account2 = AccountType.deposit;

            Console.WriteLine("Тип первого счета: " + account1);
            Console.WriteLine($"Тип второго счета: {account2}");

            Console.WriteLine("\n Дополнительная информация:");
            Console.WriteLine("Первый счет (как строка): " + account1.ToString());
            Console.WriteLine("Второй счет (числовое значение): " + (int)account2);

     

        }
    }
}

