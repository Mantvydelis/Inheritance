using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimas.Models
{
    public class Automobilis : TransportoPriemone
    {
        public int KeleiviuSkaicius { get; set; }

        public Automobilis (int keleiviuSkaicius, string marke, string modelis, int maksimalusgreitis):base(marke, modelis, maksimalusgreitis)
        {
            KeleiviuSkaicius = keleiviuSkaicius;

        }
        public override string ToString()
        {
            return $"{Marke} {Modelis}, Maksimalus greitis: {MaksimalusGreitis}, Telpa keleiviu: {KeleiviuSkaicius}";
        }

    }
}
