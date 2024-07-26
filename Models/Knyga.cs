using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimas.Models
{
    public class Knyga
    {
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }

        public int Metai { get; set; }

        public Knyga(string pavadinimas, string autorius, int metai)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Metai = metai;
        }

        public Knyga() { }
    }


}
