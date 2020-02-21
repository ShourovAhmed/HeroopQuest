using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum Heldtype { Barbaar, Dwerg, Elf, Tovenaar }
    class Held
    {
        public Held(Heldtype type, string naam)
        {
            Naam = naam;
            Heldtype = type;

            switch (type)
            {
                case Heldtype.Barbaar:
                    AanvalsDobbelstenen = 3;
                    MaxIntelligentie = 2;
                    MaxLichaam = 8;
                    break;
                case Heldtype.Dwerg:
                    MaxIntelligentie = 3;
                    MaxLichaam = 7;
                    break;
                case Heldtype.Elf:
                    MaxIntelligentie = 4;
                    MaxLichaam = 6;
                    break;
                case Heldtype.Tovenaar:
                    AanvalsDobbelstenen = 1;
                    MaxIntelligentie = 6;
                    MaxLichaam = 4;
                    break;
                default:
                    break;
            }

            HuidigIntelligentie = MaxIntelligentie;
            HuidigLichaam = MaxLichaam;
        }

        public string Naam { get; set; }

        public string Beschrijving { get; private set; }

        public int MaxIntelligentie { get; private set; }// private set want dan kan het spelbord niet bv dit aanpassen (staat letterlijk op kaart vastgeschreven)

        public int MaxLichaam { get; private set; }// private set: zie uitleg maxintelligentie

        public int HuidigIntelligentie { get; set; }

        public int HuidigLichaam { get; set; }

        public Heldtype Heldtype { get; private set; }

        public int AanvalsDobbelstenen { get; private set; } = 2;//is standaard 2 als beginwaarde

        public int Verdedigingsdobbelstenen { get; private set; } = 2;

        public int Loopdobbelstenen { get; private set; } = 2;
    }
}
