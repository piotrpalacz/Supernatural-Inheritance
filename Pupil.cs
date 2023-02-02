// Pupil.cs
using System;

namespace MagicalInheritance
{
    public class Pupil : Spell
    {
        

        public Pupil(string title)
        {
            Title = title;
        }

        public Pupil(string title, string origin)
        {
            Title = title;
            Origin = origin;
        }

        public virtual Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);

        }

        public override string Announce()
        {
            return $"{Title} comes from {Origin} land...";
        }
    }
}
