using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimas.Models
{
    public class Romanas : Knyga
    {
        public string Zanras { get; set; }

        public Romanas(string pavadinimas, string autorius, int metai, string zanras)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Metai = metai;
            Zanras = zanras;
        }


        public override string ToString()
        {
            return $"Knyga: {Pavadinimas}. Ja parase: {Autorius}. Ji parasyta: {Metai}. Romano zanras: {Zanras}";
        }

    }
}
