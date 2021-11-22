using System;

namespace Linq_vaje6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //TODO 1 Ustvarite uporabniški vmesnik, ki bo izpisal, možnosti in čakal na izbirni znak.
            //po vnesenem znaku se bo izvdela izbrana možnost, potem se ponovno izpiše osnovni menu
            //Izgled osnovnega menija.
            //Vnesite znak, katero nalogo želite izpisati:
            //NalogaA
            //NalogaB
            //NalogaC
            //NalogaD
            //NalogaE 
            //Izhod: X





            //NalogaA
            //TODO A ustvarite poizvedbo
            var nalogaA = new[] { 3, 9, 2, 8, 6, 5 };
            Console.Write("\nLINQ : Najdite in izpišite števila, katerih kvadrat je več kot 20: ");
            Console.Write("\n------------------------------------------------------------------------\n");
            //Izpišite, kvadrat števil iz seznama





            //NALOGA B
            //TODO 1B
            int[] nalogaB = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            Console.Write("\nLINQ : Izpišite števila, ki so pozitivna (>0) in manjša (<) od 12: ");
            Console.Write("\n-----------------------------------------------------------------------------");



            //*/
            //TODO 1C
            // NALOGA C

            //iz podanega seznama, izpišite za posamezno število, kolikokrat se ponovi
            int[] nalogaC = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Console.Write("\nLINQ : Izpišite število in število ponovitev posameznega števila, v podanem seznamu: \n");
            Console.Write("---------------------------------------------------------------------\n");



            //TODO 1D Izpišite mesta v 1 vrstici:
            //Mesta so: RIM, .....
            //koda

            //preberite vnos prvi znak chzacetek
            //pomoc ReadKey().KeyChar
            string chzacetek, chkonec;
            char ch;
            string[] mesta ={"RIM","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS", "LJUBLJANA", "DUNAJ", "PARIS", "ZAGREB"};

            Console.Write("\nLINQ : Najdite mesta, ki se začnejo in končajo z določenim znakom: ");
            Console.Write("\n-----------------------------------------------------------------------\n");



            //NALOGA E  (kartezični produkt)
            //TODO 1E
            //kartezični produkt, so vse možnosti med emelenti obeh seznamov
            //izpišite kartezični produkt podanih seznamov
            char[] sezznakiE = { 'X', 'Y', 'Z' };
            int[] sezstevilaE = { 1, 2, 3, 4 };

            Console.Write("\nKartezični produkt seznamov je: ");
            Console.Write("\n------------------------------------------------\n");





        }
    }
}
