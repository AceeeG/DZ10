using System;
using Bank;
using Building4R;

namespace Lab
{
    internal class Program
    {
        /// <summary>
        /// Выполняет упражнения 11 главы
        /// </summary>
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

        /// <summary>
        /// Выполняет домашнее задание упражнение 11 главы
        /// </summary>
        static void DoHomework11()
        {
            Console.WriteLine("Домашнее задание\n");
            Building4 building1 = CreatorR.CreateBuilding();
            Building4 building2 = CreatorR.CreateBuilding();
            CreatorR.DeleteBuilding(building2.Id);
            Console.WriteLine("Было создано 2 здания, после удалено второе\n");
        }
        /// <summary>
        /// Выполняет 1 упражнение 12 главы
        /// </summary>
        static void DoExercises12() 
        {
            Console.WriteLine("Задание 1\n");
            BankFactory factory = new BankFactory();
            factory.CreateAccount(1);
            factory.CreateAccount(2);
            BankAccount account1 = factory.GetAccount(1);
            BankAccount account2 = factory.GetAccount(2);
            Console.WriteLine(account1 == account2 ? ("Аккаунты равны") : ("Аккаунты не равны"));
            Console.WriteLine(account1.Equals(account2) ? ("Аккаунты равны") : ("Аккаунты не равны"));
            Console.WriteLine(account1.GetHashCode());
            Console.WriteLine(account1 != account2 ? ("Аккаунты не равны") : ("Аккаунты равны"));
        }
        static void DoHomework12()
        {
            Console.WriteLine("Домашнее задание 1\n");
            ComplexNumber num1 = new ComplexNumber(1, 2);
            ComplexNumber num2 = new ComplexNumber(2, 3);
            string result = num1 == num2 ? ("Числа равны") : ("Числа не равны");
            Console.WriteLine($"Сумма: {num1 + num2}, Разность: {num1 - num2}\n" +
                $"{result}");
            Console.WriteLine("Домашнее задание 2\n");
            Library library = new Library();
            Book book1 = new Book("A", "C", "B", library);
            Book book2 = new Book("B", "A", "C", library);
            Book book3 = new Book("C", "B", "A", library);
            Console.WriteLine("Сортировка по имени\n");
            library.Sort(Book.CompareByName);
            library.Print();
            Console.WriteLine("Сортировка по автору\n");
            library.Sort(Book.CompareByAuthor);
            library.Print();
            Console.WriteLine("Сортировка по издательству\n");
            library.Sort(Book.CompareByPublisher);
            library.Print();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 11\n");
            DoExercises11();
            DoHomework11();
            Console.WriteLine("Лабороторная 12\n");
            DoExercises12();
            DoHomework12();
            Console.ReadKey();
        }
    }
}
