using System;

namespace Execises
{
    internal class Sportsman : Person
    {
        public event EventHandler sport_event;

        
        public Sportsman(string name, Hobbies favorite_hobbie = Hobbies.Спорт) : base(name, favorite_hobbie)
        {
        }
        public override void MakeEvent()
        {
            if (sport_event != null)
            {
                sport_event(this, new EventArgs());
            }
        }
    }
}
