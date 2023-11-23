using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class BankTransaction
    {
        DateTime transaction_time { get; set; }

        readonly double money;

        internal BankTransaction(double money)
        {
            transaction_time = DateTime.Now;
            this.money = money;
        }
        /// <summary>
        /// Возрвращает строку с инфой о транзакиции
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return ($"{transaction_time} произошла операция на сумму {money} рублей\n");
        }
    }
}
