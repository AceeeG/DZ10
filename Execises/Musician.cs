using System;

namespace Execises
{
    internal class Musician : Person
    {
        public event EventHandler music_event;
        public Musician(string name, Hobbies favorite_hobbie = Hobbies.Музыка) : base(name, favorite_hobbie)
        {
        }
        public override void MakeEvent()
        {
            if (music_event != null)
            {
                music_event(this, new EventArgs());
            }
        }

    }
}
