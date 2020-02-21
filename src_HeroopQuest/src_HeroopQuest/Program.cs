using src_HeroopQuest.GameClasses; //om heldklasse te kunnen gebruiken
using System;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Held held1 = new Held(Heldtype.Barbaar, "Conan");
            Held held2 = new Held(Heldtype.Tovenaar, "Bart");

            Console.WriteLine(held1.AanvalsDobbelstenen);
            Console.WriteLine(held2.Heldtype);
        }
    }
}
