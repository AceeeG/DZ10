using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class BankFactory
    {
        static private Hashtable bank_table = new Hashtable(9999);
        public Hashtable Bank_table 
        { 
            get 
            { 
                return bank_table; 
            } 
        }

        public void CreateAccount(int balance, BankType type)
        {
            BankAccount account = new BankAccount(type, balance);
            bank_table.Add(account.Id, account);
        }
        public void CreateAccount(int balance)
        {
            BankAccount account = new BankAccount(balance);
            bank_table.Add(account.Id, account);

        }
        public void CreateAccount(BankType type)
        {
            BankAccount account = new BankAccount(type);
            bank_table.Add(account.Id, account);
        }
        public void CreateAccount()
        {
            BankAccount account = new BankAccount();
            bank_table.Add(account.Id, account);
        }


        public void DeleteAccount(uint id)
        {
            bank_table.Remove(id);
        }

        public void Print()
        {
            Console.WriteLine("В таблице хранятся следующие банковские счета:");
            for (uint i = 0; i < 1000; i++)
            {
                if (bank_table.ContainsKey(i))
                {
                    BankAccount account = bank_table[i] as BankAccount;
                    Console.WriteLine($"Id: {account.Id}, тип: {account.Type}, баланс: {account.Balance}\n");
                }
            }
        }

        public BankAccount GetAccount(uint id)
        {
            if (bank_table.ContainsKey(id))
            {
                return (BankAccount)bank_table[id];
            }
            else
            {
                Console.WriteLine("Нету такого пользователя\n");
                return (BankAccount)bank_table[1];
            }

        }

    }
}
