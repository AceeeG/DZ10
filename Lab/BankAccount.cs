using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Lab
{
    enum BankType
    {
        Сберегательный,
        Зарплатный,
        Кредитный,
    }

    internal class BankAccount
    {
        private static uint id_counter = 0;
        public static uint Id_counter
        {
            get
            { 
                return id_counter;
            }
        }
        private uint id;
        public uint Id
        {
            get
            {
                return id;
            }
        }
        private double balance;
        public double Balance
        {
            get 
            { 
                return balance; 
            }
        }
        private BankType type;
        public BankType Type
        {
            get
            { 
                return type; 
            }
        }
        private Queue<BankTransaction> transactions = new Queue<BankTransaction>();
        private bool is_disposed = false;

        /// <summary>
        /// Делает уникальный ID, увеличивая статическую переменную.
        /// </summary>
        public void MakeUniqeID()
        {
            id_counter++;
        }
        /// <summary>
        /// Конструктор - создаёт банковский счёт
        /// </summary>
        internal BankAccount()
        {
            MakeUniqeID();
            id = id_counter;
        }
        /// <summary>
        /// Конструктор - создаёт банковский счёт
        /// </summary>
        /// <param name="type"></param>
        internal BankAccount(BankType type)
        {
            MakeUniqeID();
            id = id_counter;
            this.type = type;
        }
        /// <summary>
        /// Конструктор - создаёт банковский счёт
        /// </summary>
        /// <param name="balance"></param>
        internal BankAccount(double balance)
        {
            MakeUniqeID();
            id = id_counter;
            this.balance = balance;
        }
        /// <summary>
        /// Конструктор - создаёт банковский счёт
        /// </summary>
        /// <param name="type"></param>
        /// <param name="balance"></param>
        internal BankAccount(BankType type, double balance)
        {
            MakeUniqeID();
            id = id_counter;
            this.balance = balance;
            this.type = type;
        }

        
        /// <summary>
        /// Вносит деньги на счёт
        /// </summary>
        /// <param name="money"></param>
        public void DepositMoney(double money)
        {
            if (money > 0)
            {
                BankTransaction transaction = new BankTransaction(money);
                transactions.Enqueue(transaction);
                balance += money;
                Console.WriteLine($"Счёт пополнен на {money} рублей, текущий баланс {balance}\n");
            }
            else
            {
                Console.WriteLine("Сумма должна быть положительной\n");
            }
        }

        /// <summary>
        /// Снимает деньги со счёта
        /// </summary>
        /// <param name="money"></param>
        public void WithdrawMoney(double money)
        {
            if (money <= balance)
            {
                BankTransaction transaction = new BankTransaction(money);
                transactions.Enqueue(transaction);
                balance -= money;
                Console.WriteLine($"Со счёта снято {money} рублей, текущий баланс {balance}\n");
            }
            else
            {
                Console.WriteLine("На счёте недостаточно средств\n");
            }
        }

        public void GetBalance()
        {
            Console.WriteLine($"Ваш баланс {balance}\n");
        }

        /// <summary>
        /// Выводит информацию о счёте
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Номер вашего счёта: {id}\nБаланс: {balance}\nТип: {type}\n");
        }

        /// <summary>
        /// Переводит деньги на другой счёт
        /// </summary>
        /// <param name="account1"></param>
        /// <param name="money"></param>
        public void TransferMoney(BankAccount account1, double money)
        {
            if (balance < money)
            {
                Console.WriteLine("На счете недостаточно средств\n");
            }
            else
            {
                BankTransaction transaction = new BankTransaction(money);
                transactions.Enqueue(transaction);
                balance -= money;
                account1.balance += money;
                Console.WriteLine($"Вы перевели {money} рублей на счет {account1.id}, ваш баланс {balance}");
            }
        }

        public void Dispose()
        {
            if (!is_disposed)
            {
                foreach (BankTransaction trans in transactions)
                {

                    File.WriteAllText("transactions.txt", trans.Print());
                    //transactions.Dequeue();
                }
                transactions.Clear();
                is_disposed = true;

                GC.SuppressFinalize(this);
            }
        }
    }
}
