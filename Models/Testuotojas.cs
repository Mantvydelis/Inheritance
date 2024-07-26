using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimas.Models
{
    public class Testuotojas : Darbuotojas
    {
        public bool TuriAutomatizavimoPatirties { get; set; }

        public Testuotojas(bool turiPatirties, string vardas, string pavarde, double atlyginimas)
        {
            TuriAutomatizavimoPatirties = turiPatirties;
            Vardas = vardas;
            Pavarde = pavarde;
            Atlyginimas = atlyginimas;
            
        }

        public void IgautiPatirties()
        {
            if (TuriAutomatizavimoPatirties = false)
            {
                TuriAutomatizavimoPatirties = true;
                return;
            }
            else
            {
                Console.WriteLine("Testuotojas patities turi");
            }
            
        }

        public override string ToString()
        {
            if (TuriAutomatizavimoPatirties = true)
            {
                return $"{Vardas} {Pavarde}, Atlyginimas: {Atlyginimas} ir turi patirties automatizavime";

            }
            else
            {
                return $"{Vardas} {Pavarde}, Atlyginimas: {Atlyginimas} ir neturi patirties automatizavime";
            }

        }
    }
}
