using System;
namespace MagicalInheritance
{
    public abstract class Spell
    {
        // Properties
        public string? Essence { get; set; }
        public bool IsStrong { get; set; }
        public string? Caster { get; set; }

        // Pupil Properties
        public string Title { get; protected set; }
        public string Origin { get; protected set; }

        public abstract string Announce();
        
    }
}

