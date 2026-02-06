using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountWithStructure
{
    internal enum AccountType
    {
        Checking,
        Deposit,
        Savings,
        Credit,
        Investment,
        FixedTermDeposit,
        SavingsAccount,
        PensionDeposit,
        StudentDeposit
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8; 
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            //Console.WriteLine("Упражнение: Структура для банковских счетов");
            //Console.WriteLine("===========================================\n");

            //Console.WriteLine("\nНажмите любую клавишу для завершения...");
            //Console.ReadKey();

            //BankAccount myAccount = new BankAccount(
            //    817810500012345678L,
            //    150000.75m,
            //    AccountType.Deposit
            //);
            //myAccount.DisplayAccountInfo();

            List<BankAccount> accounts = new List<BankAccount>();
            bool running = true; 
            while (running)
            {
                Console.Clear();
                Console.WriteLine("\n Меню:");
                Console.WriteLine("1 - создать новый счет");
                Console.WriteLine("2 - показать все счета");
                Console.WriteLine("3 - выход");
                Console.WriteLine("выберите пункт:");
                int choice = int.Parse(Console.ReadLine());
                if (choice <= 0 || choice > 3)
                {
                    Console.WriteLine("несущесвтующий пункт меню");
                    Console.ReadLine();
                }
                else {
                    switch ((choice))
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n выберите тип счета");
                            int index = 1;
                            foreach (var type in Enum.GetValues(typeof(AccountType)))
                            {
                                Console.WriteLine($"{index} - {type}");
                                index++;
                            }
                            Console.Write("Введите номер типа: ");
                            int typeNumber = int.Parse(Console.ReadLine());
                            typeNumber--;
                            AccountType selectedType = (AccountType)typeNumber;
                            Console.Write("Введите номер счёта: ");
                            long number = long.Parse(Console.ReadLine());
                            Console.Write("Введите сумму: ");
                            decimal money = decimal.Parse(Console.ReadLine());
                            accounts.Add(new BankAccount(number, money, selectedType));
                            Console.WriteLine("Счёт успешно создан!");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n=== Все счета ===");
                            if (accounts.Count == 0)
                            {
                                Console.WriteLine("Счетов пока нет.");

                            }
                            else
                            {
                                foreach (var acc in accounts)
                                {
                                    acc.DisplayAccountInfo();
                                    Console.WriteLine();

                                }

                            }
                            Console.ReadLine();
                            break;
                        case 3:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Неверный пункт меню.");
                            break;
                    }
                    }

            }



        }
    }
}
