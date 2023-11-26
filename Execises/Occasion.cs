using System;


namespace Execises
{
    internal class Occasion
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private Hobbies hobbie;
        public Hobbies Hobbie
        {
            get
            {
                return hobbie;
            }
        }
        public Occasion(string name, Hobbies hobbie)
        {
            this.name = name;
            this.hobbie = hobbie;
        }
        public void Print()
        {
            Console.WriteLine($"Событие: {name}, Категория: {hobbie}\n");
        }
    }
}
