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
            Console.WriteLine("Упражнение: Структура для банковских счетов");
            Console.WriteLine("===========================================\n");
     
            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();

             BankAccount myAccount = new BankAccount(
                 817810500012345678L,
                 150000.75m,
                 AccountType.Deposit
             );
         myAccount.DisplayAccountInfo();



        }
    }
}
