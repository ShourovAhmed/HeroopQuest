using src_HeroopQuest.GameClasses; //om heldklasse te kunnen gebruiken
using src_HeroopQuest.Properties;
using System;
using System.Collections.Generic;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Resources.barbaartekst);//resources bij properties van project aangemaakt en dan er tekst in gezet (zie vid)
            Held held1 = new Held(Heldtype.Barbaar, "Conan");
            Held held2 = new Held(Heldtype.Tovenaar, "Bart");
            Held held3 = new Held(Heldtype.Dwerg, "Dwerg");

            /*Console.WriteLine(held1.AanvalsDobbelstenen);
            Console.WriteLine(held2.Heldtype);*/

           // held1.Toonfiche();
           //held2.Toonfiche();

            List<Held> deHelden = new List<Held>();
            //Allemaal eigenschappen van List getest hieronder
            deHelden.Add(held1);
            deHelden.Add(held2);
            deHelden.Insert(0, held3);
            // deHelden.RemoveAt(1);


            //Soort van betere en leesbare loop dan een 'for' (gelijkend op Bash)
            foreach (var heldje in deHelden)
            {
                heldje.Toonfiche();
            }

            for (int i = 0; i < deHelden.Count; i++)
            {
                deHelden[i].Toonfiche();
            }

        }
    }
}
