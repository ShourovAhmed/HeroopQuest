using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum Heldtype { Babrbaar, Dwerg, Elf, Tovenaar}
    class Held
    {
        public string Naam { get; set; }

        public string Beschrijving { get; private set; }

        public int MaxIntelligentie { get; private set; }// private set want dan kan het spelbord niet bv dit aanpassen (staat letterlijk op kaart vastgeschreven)

        public int MaxLichaam { get; private set; }// private set: zie uitleg maxintelligentie

        public int HuidigIntelligentie { get; set; }

        public int HuidigLichaam { get; set; }

        public Heldtype Heldtype { get; private set; }

        public int AanvalDobbelstenen { get; private set; } = 2;//is standaard 2 als beginwaarde

        public int Verdedigingsdobbelstenen { get; private set; } = 2;

        public int Loopdobbelstenen { get; private set; } = 2;
    }
}
