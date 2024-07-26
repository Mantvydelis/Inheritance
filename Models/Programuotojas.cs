using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimas.Models
{
    public class Programuotojas : Darbuotojas
    {
        public string ProgramavimoKalba { get; set; }

        public Programuotojas(string programavimoKalba, string vardas, string pavarde, double atlyginimas)
        {
            ProgramavimoKalba = programavimoKalba;
            Vardas = vardas;
            Pavarde = pavarde;
            Atlyginimas = atlyginimas;
        }

        public void Persikvalifikuoti()
        {
            Console.WriteLine("Ivesite nauja programavimo kalba: ");
            string naujaKalba = Console.ReadLine();
            ProgramavimoKalba = naujaKalba;

        }


        public override string ToString()
        {
            
                return $"{Vardas} {Pavarde}, Atlyginimas: {Atlyginimas}, {ProgramavimoKalba} programavimo kalba";


        }

    }

}
