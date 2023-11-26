using System;
using System.Collections.Generic;

namespace Lab
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        public List<Book> Books 
        { 
            get 
            { 
                return books;
            } 
            set 
            { 
                books = value; 
            }
        }
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public Library()
        {

        }
        /// <summary>
        /// Конструктор, заполняющий список
        /// </summary>
        /// <param name="books"></param>
        public Library(List<Book> books)
        {
            Books = books;
        }

        /// <summary>
        /// Метод, добавлющий книгу в список
        /// </summary>
        /// <param name="book"></param>
        public void Add(Book book)
        {
            books.Add(book);
        }
        /// <summary>
        /// Метод сортирующий по определенному параметру
        /// </summary>
        /// <param name="comparison"></param>
        public void Sort(Comparison<Book> comparison)
        {
            books.Sort(comparison);
        }
        /// <summary>
        /// Метод, выводящий информацию о книгах в списке
        /// </summary>
        public void Print()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.Print());
            }
        }
    }
}
