using System;
using System.Collections.Generic;
using System.Text;

namespace Konstruktor
{
    class Food
    {
        string vNamn;
        float vPris, vKilo;
        float total;

        public Food()
        {
            this.vNamn = "defaltName";
            this.vPris = 0;
            this.vKilo = 0;
            
        }
        public Food(string namn, float pris, float kilo)
        {
            this.vNamn = namn;
            this.vPris = pris;
            this.vKilo = kilo;
            

        }
        private string VegPrint()
        {
            string veg1;
            veg1 = "GrönsakerNamn: " + vNamn + "\nVikt: " + vKilo + "\npris:" + vPris + "\nTotal pris: " + TotalPris() + " SEK";
            return veg1;
        }

        public string VegText()
        {
            string publicVegInfo;
            publicVegInfo = VegPrint();
            return publicVegInfo;
            

        }

        public double TotalPris()
        {
            
            total = vKilo * vPris;
            return total;
            

        }
    }



}

