using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountWithStructure
{
    internal struct BankAccount
    {
        public long accNo;
        public decimal accBalance;
        public AccountType accType;
        public BankAccount(long accountNumber, decimal balance, AccountType type)
        {
            accNo = accountNumber;
            accBalance = balance;
            accType = type;
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine("=== Информация о банковском счете ===");
            Console.WriteLine($"Номер счета: {accNo}");
            Console.WriteLine($"Баланс: {accBalance:C}"); // :C - формат валюты
            Console.WriteLine($"Тип счета: {accType}");
            Console.WriteLine($"Числовой код типа: {(int)accType}");
        }

    }

}
