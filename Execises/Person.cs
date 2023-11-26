namespace Execises
{
    enum Hobbies
    {
        Спорт,
        Музыка,
        Бомжевать
    }
    internal abstract class Person
    {
        private string name;
        public string Name 
        {
            get 
            { 
                return name; 
            } 
        }
        private Hobbies favorite_hobbie;
        public Hobbies Favorite_hobbie
        {
            get
            {
                return favorite_hobbie;
            }
        }
        public Person(string name, Hobbies favorite_hobbie)
        {
            this.name = name;
            this.favorite_hobbie = favorite_hobbie;
        }
        public abstract void MakeEvent();

    }
}
