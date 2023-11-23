using System;
using Bank;
using Building4R;

namespace Lab
{
    internal class Program
    {
        static void DoExercises11()
        {
            Console.WriteLine("Упражнения 1 - 2\n");

            BankType type = BankType.Сберегательный;
            BankFactory factory = new BankFactory();
            factory.CreateAccount(type);
            factory.CreateAccount(800);
            factory.CreateAccount(850, type);
            factory.CreateAccount();
            factory.DeleteAccount(5);
            factory.CreateAccount();
            factory.Print();

        }

        static void DoHomework11()
        {
            Console.WriteLine("Домашнее задание\n");
            Building4 building1 = CreatorR.CreateBuilding();
            Building4 building2 = CreatorR.CreateBuilding();
            CreatorR.DeleteBuilding(building2.Id);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 11\n");
            DoExercises11();
            DoHomework11();

            Console.ReadKey();
        }
    }
}
