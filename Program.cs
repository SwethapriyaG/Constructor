using System;
using System.IO;

namespace Konstruktor
{
    class Program
    {
        static string vNamn;
        static float vKilo, vPris;
        static void Main(string[] args)
        {
            Fruit apple = new Fruit("apple", "geen", 30, 29, true, false);

            Console.WriteLine("Välkommen till frukt fariken!");
            Console.WriteLine(apple.FruitText());

            Fruit obj1 = new Fruit("Banana", "yello", 12, 10, true, false);
            Console.WriteLine("Välkommen till frukt fariken!");
            Console.WriteLine(obj1.FruitText());

            VegInfo();
            Food veg = new Food(vNamn, vKilo, vPris);
            Console.WriteLine(veg.VegText());
            
        }
        static void VegInfo()
        {
            

            Console.WriteLine("Grönsaker Namn?");
            vNamn = Console.ReadLine();
            Console.WriteLine("Grönsaker Vikt i KG?");
            string vikt = Console.ReadLine();
            
           float.TryParse(vikt, out vKilo);

           Console.WriteLine("Grönsaker pris i SEK?");
            string prise = Console.ReadLine();
            float.TryParse(prise, out vPris);
            





        }
    }
}
