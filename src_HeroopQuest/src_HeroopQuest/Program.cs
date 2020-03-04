using src_HeroopQuest.GameClasses; //om heldklasse te kunnen gebruiken
using src_HeroopQuest.Properties;
using System;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Resources.barbaartekst);//resources bij properties van project aangemaakt en dan er tekst in gezet (zie vid)
            Held held1 = new Held(Heldtype.Barbaar, "Conan");
            Held held2 = new Held(Heldtype.Tovenaar, "Bart");

            /*Console.WriteLine(held1.AanvalsDobbelstenen);
            Console.WriteLine(held2.Heldtype);*/

            held1.Toonfiche();
            held2.Toonfiche();


        }
    }
}
