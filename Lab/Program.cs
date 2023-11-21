using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        static void DoExercises()
        {
            Console.WriteLine("Упражнения 1 - 2\n");

            BankType type = BankType.Сберегательный;
            BankFactory factory = new BankFactory();
            factory.CreateAccount(type);
            factory.CreateAccount(800);
            factory.CreateAccount(850, type);
            factory.CreateAccount();
            factory.DeleteAccount(3);
            factory.Print();

        }
        static void Main(string[] args)
        {
            DoExercises();


            Console.ReadKey();
        }
    }
}
