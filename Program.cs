using System;
using SupernaturalInheritance;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is made with Codecademy tutorial ");
            // Create an array of storms - REFACTORED :)
            Storm[] storms = new Storm[]
            {
                new Storm("wind", false, "Zul'rajas"),
                new Pupil("Mezil-kree").CastWindStorm(),
                new Mage("Gul'dan").CastRainStorm(),
                new Archmage("Nielas Aran").CastRainStorm(),
                new Archmage("Nielas Aran").CastLightningStorm()
            };
            // Adding objects to specified index
            //storms[0] = new Storm("wind", false, "Zul'rajas");
            
            //Pupil pupil = new Pupil("Mezil-kree");
            //storms[1] = pupil.CastWindStorm();

            //Mage mage = new Mage("Gul'dan");
            //storms[2] = mage.CastRainStorm();

            //Archmage archmage = new Archmage("Nielas Aran");
            //storms[3] = archmage.CastRainStorm();
            //storms[4] = archmage.CastLightningStorm();

            foreach (var element in storms)
            {
                if (element != null)
                {
                    Console.WriteLine(element.Announce());
                }
            }

            Pupil p = new Pupil("Mezil-kree", "Icecrown");
            Mage m = new Mage("Gul'dan", "Draenor");
            Archmage a = new Archmage("Nielas Aran", "Stormwind");

            p.CastWindStorm();
            m.CastRainStorm();
            a.CastRainStorm();
            a.CastLightningStorm();

            Console.WriteLine("\n----------------------");
            Console.WriteLine(p.Announce());
            Console.WriteLine(m.Announce());
            Console.WriteLine(a.Announce());
            
            Console.ReadKey();
        }
    }
}