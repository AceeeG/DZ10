using System;

namespace Lab
{
    internal class Book
    {
        private string name;
        public string Name 
        { 
            get 
            { 
                return name; 
            } 
        }
        private string author;
        public string Author
        {
            get
            {
                return author;
            }
        }
        private string publisher;
        public string Publisher
        {
            get
            {
                return publisher;
            }
        }
        /// <summary>
        /// Конструктор, заполняющий все поля
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="publisher"></param>
        /// <param name="lib"></param>
        public Book(string name, string author, string publisher, Library lib)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            lib.Add(this);
        }
        /// <summary>
        /// Метод, возвращающий строку с инф-ей о книге
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"Название: {name}, Автор: {author}, Издательство: {publisher}\n";
        }
        /// <summary>
        /// Метод сравнивающий по имени
        /// </summary>
        /// <param name="book1"></param>
        /// <param name="book2"></param>
        /// <returns></returns>
        public static int CompareByName(Book book1, Book book2)
        {
            return String.Compare(book1.name, book2.name);
        }
        /// <summary>
        /// Метод сравнивающий по автору
        /// </summary>
        /// <param name="book1"></param>
        /// <param name="book2"></param>
        /// <returns></returns>
        public static int CompareByAuthor(Book book1, Book book2)
        {
            return String.Compare(book1.author, book2.author);
        }
        /// <summary>
        /// Метод сравнивающий по издательству
        /// </summary>
        /// <param name="book1"></param>
        /// <param name="book2"></param>
        /// <returns></returns>
        public static int CompareByPublisher(Book book1, Book book2)
        {
            return String.Compare(book1.publisher, book2.publisher);
        }
    }
}
