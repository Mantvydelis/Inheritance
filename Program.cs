using Paveldejimas.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ManoPrograma

{
    public class PagrindineKlase
    {

        //1 uzduotis
        //public static void Main(string[] args)
        //{
        //    TransportoPriemone automobilis1 = new Automobilis(5, "Fiat", "Punto", 100);
        //    TransportoPriemone motociklas1 = new Motociklas(true, "Harley Davidson", "Cool", 150);
        //    TransportoPriemone automobilis2 = new Automobilis(2, "Porshe", "Cayene", 200);
        //    TransportoPriemone motociklas2 = new Motociklas(false, "Suzuki", "Britva" , 250);

        //    List<TransportoPriemone> transportoPriemones = new List<TransportoPriemone> { automobilis1, motociklas1, automobilis2, motociklas2 };

        //    foreach (TransportoPriemone d in transportoPriemones)
        //    {

        //        Console.WriteLine(d);

        //    }


        //}

        //2 uzduotis

        //public static void Main(string[] args)
        //{
        //    Darbuotojas programer1 = new Programuotojas("java", "Petras", "Petraitis", 2000);
        //    Darbuotojas programer2 = new Programuotojas("c#", "Antanas", "Antanaitis", 2500);

        //    Darbuotojas tester1 = new Testuotojas(true, "Kestas", "Kestaitis", 1500);
        //    Darbuotojas tester2 = new Testuotojas(false, "Domantas", "Domantaitis", 1500);

        //    List<Darbuotojas> darbuotojai = new List<Darbuotojas> { programer1, programer2, tester1, tester2 };


        //    foreach (Darbuotojas d in darbuotojai)
        //    {

        //        Console.WriteLine(d);

        //    }

        //    ((Programuotojas)programer1).Persikvalifikuoti();
        //    ((Testuotojas)tester2).IgautiPatirties();


        //    foreach (Darbuotojas d in darbuotojai)
        //    {

        //        Console.WriteLine(d);

        //    }




        //}

        //3 uzduotis

        public static void Main(string[] args)
        {
            Knyga knyga1 = new Romanas("Nusikaltimas ir bausme", "Dostojevskis", 1984, "Siaubiakas");
            Knyga knyga2 = new Romanas("Meiles sukuryje", "M. Meilutyte", 2024, "Meiles romanas");
            Knyga knyga3 = new MokslineKnyga("Pasaulio paslaptys", "M. Mokslininkaitis", 2012, "Biologija");
            Knyga knyga4 = new MokslineKnyga("Astrofizika", "K. Kosmonaitis", 1900, "Astronomija");

            List<Knyga> visosKnygos = new List<Knyga> { knyga1, knyga2, knyga3, knyga4 };

            foreach (Knyga d in visosKnygos)
            {

                Console.WriteLine(d);

            }

            int romanuSkaicius = 0;

            foreach (Knyga d in visosKnygos)
            {

                if (d is Romanas)
                {
                    romanuSkaicius++;
                }
            }

            Console.WriteLine("Romanu skaicius yra:" + romanuSkaicius);
        }


    }

    }

