using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
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
        StudentDeposit,
        newelement,
        ouirghiufdbjfkdb
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                Console.WriteLine("\n=== Выбор типа депозита ===");
                Console.WriteLine("Доступные типы счетов:");
                int index = 1;
                foreach (AccountType type in Enum.GetValues(typeof(AccountType)))
                {
                    Console.WriteLine($"{index}. {type}");
                    index++;
                }
                Console.WriteLine("0. Выход"); 
                Console.Write("\nВыберите номер типа счета для нового депозита: \n");
                try
                {

                    int choise = int.Parse(Console.ReadLine());
                    if (choise == 0) 
                    {
                        Console.WriteLine("\nВыход из программы...");
                        break; 
                    }
                    if (choise >= 1 && choise <= Enum.GetValues(typeof(AccountType)).Length)
                    {
                        AccountType selectedType = (AccountType)(choise - 1);
                        Console.WriteLine($"\n Вы выбрали: {selectedType}");
                        Console.WriteLine($"Числовое значение: {(int)selectedType}");
                        switch (selectedType)
                        {
                            case AccountType.Checking:
                                Console.WriteLine("Описание: " +
                                    "Текущий счет для ежедневных операций");
                                break;
                            case AccountType.Deposit: Console.WriteLine("Описание: " +
                        "Срочный вклад с фиксированной ставкой");
                                break;
                            case AccountType.Savings:
                                Console.WriteLine("Описание: " +
                        "Накопительный счет с процентами");
                                break;
                            case AccountType.Credit:
                                Console.WriteLine("Описание: " +
                        "Кредитный счет с установленным лимитом");
                                break;
                            case AccountType.Investment:
                                Console.WriteLine("Описание: " +
                                    "Инвестиционный счет для ценных бумаг");
                                break;
                            case AccountType.FixedTermDeposit:
                                Console.WriteLine("Описание: " + "Срочный депозит");
                                break;
                            case AccountType.SavingsAccount:
                                Console.WriteLine("Описание: " + "накопительный счет");
                                break;
                            case AccountType.PensionDeposit:
                                Console.WriteLine("Описание: " + "Пенсионный депозит");
                                break;
                            case AccountType.StudentDeposit:
                                Console.WriteLine("Описание: Студенческий депозит");
                                break;
                            case AccountType.newelement:
                                Console.WriteLine("Описание: новый элемент 1");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: выбран неверный номер!");
                    }
                }
            catch(FormatException)
            {
                    Console.WriteLine("Ошибка: введите корректное число!");
                }
                Console.WriteLine("\nНажмите любую клавишу для закрытия...");
                Console.ReadKey();

            }
        }
    } 
    
}


