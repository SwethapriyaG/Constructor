using System;
using System.Collections.Generic;
using System.Text;

namespace Konstruktor
{
    class Fruit
    {
        string namn, farg;
        float kcal, pris;
        bool atbar, skal;
        public Fruit(string fruktNamn, string fruktFarg, float fruktKcal, float fruktPris, bool fruktAtbar, bool fruktSkal)
        {
            namn = fruktNamn;
            farg = fruktFarg;
            kcal = fruktKcal;
            pris = fruktPris;
            atbar = fruktAtbar;
            skal = fruktSkal;

        }
        private string FruitInfo()
        {
            string fruitInfo;
            fruitInfo = "Fruktnamn: " + namn + "\nFruktfarg: " + farg;
            return fruitInfo;
        }

        public string FruitText()
        {
            string publicFruitInfo;
            publicFruitInfo = FruitInfo();
            return publicFruitInfo;

        }
    }
}
