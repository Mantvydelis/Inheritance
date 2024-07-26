using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimas.Models
{
    public class MokslineKnyga : Knyga
    {
        public string Tema { get; set; }

        public MokslineKnyga(string pavadinimas, string autorius, int metai, string tema)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Metai = metai;
            Tema = tema;
        }

        public override string ToString()
        {
            return $"Knyga: {Pavadinimas}. Ja parase: {Autorius}. Ji parasyta: {Metai}. Knygos tema: {Tema}";
        }
    }
}
