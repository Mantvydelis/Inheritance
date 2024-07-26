using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimas.Models
{
    public class Darbuotojas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public double Atlyginimas { get; set; }

        public Darbuotojas(string vardas, string pavarde, double atlyginimas) 
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Atlyginimas = atlyginimas;
        }

        public Darbuotojas() { }

    }
}
