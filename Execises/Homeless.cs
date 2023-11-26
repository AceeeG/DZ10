using System;

namespace Execises
{
    internal class Homeless : Person
    {
        public event EventHandler home_event;
        public Homeless(string name, Hobbies favorite_hobbie = Hobbies.Бомжевать) : base(name, favorite_hobbie)
        { 
        }
        public override void MakeEvent()
        {
            if (home_event != null)
            {
                home_event(this, new EventArgs());
            }
        }
    }
}
