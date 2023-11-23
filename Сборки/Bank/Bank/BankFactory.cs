using System;
using System.Collections;

namespace Bank
{
    public class BankFactory
    {
        static private Hashtable bank_table = new Hashtable(9999);
        public Hashtable Bank_table
        {
            get
            {
                return bank_table;
            }
        }
        /// <summary>
        /// Создает банковский аккаунт и добаляет его в таблицу
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="type"></param>
        public void CreateAccount(int balance, BankType type)
        {
            BankAccount account = new BankAccount(type, balance);
            bank_table.Add(account.Id, account);
        }
        /// <summary>
        /// Создает банковский аккаунт и добаляет его в таблицу
        /// </summary>
        /// <param name="balance"></param>
        public void CreateAccount(int balance)
        {
            BankAccount account = new BankAccount(balance);
            bank_table.Add(account.Id, account);

        }
        /// <summary>
        /// Создает банковский аккаунт и добаляет его в таблицу
        /// </summary>
        /// <param name="type"></param>
        public void CreateAccount(BankType type)
        {
            BankAccount account = new BankAccount(type);
            bank_table.Add(account.Id, account);
        }
        /// <summary>
        /// Создает банковский аккаунт и добаляет его в таблицу
        /// </summary>
        public void CreateAccount()
        {
            BankAccount account = new BankAccount();
            bank_table.Add(account.Id, account);
        }

        /// <summary>
        /// Удаляет банковский аккаунт из таблицы
        /// </summary>
        /// <param name="id"></param>
        public void DeleteAccount(uint id)
        {
            bank_table.Remove(id);
        }

        /// <summary>
        /// Выводит каждый элемент таблицы
        /// </summary>
        public void Print()
        {
            Console.WriteLine("В таблице хранятся следующие банковские счета:");
            for (uint i = 0; i < bank_table.Count; i++)
            {
                if (bank_table.ContainsKey(i))
                {
                    BankAccount account = bank_table[i] as BankAccount;
                    Console.WriteLine($"Id: {account.Id}, тип: {account.Type}, баланс: {account.Balance}\n");
                }
            }
        }

        /// <summary>
        /// Дает доступ к определенному банковскому счёту
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
