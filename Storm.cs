// Storm.cs
using System;

namespace MagicalInheritance
{
    public class Storm : Spell
    {
        

        // Constructor
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        public override string Announce()
        {
            {
                if (IsStrong == false)
                {
                    return $"{Caster} cast a weak {Essence} storm!";
                }
                else
                {
                    return $"{Caster} cast a strong {Essence} storm!";
                }

            }
        }
    }
}
