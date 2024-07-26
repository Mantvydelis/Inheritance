using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimas.Models
{
    public class TransportoPriemone
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int MaksimalusGreitis { get; set; }

        public TransportoPriemone(string marke, string modelis, int maksimalusGreitis)
        {
            Marke = marke;
            Modelis = modelis;  
            MaksimalusGreitis = maksimalusGreitis;
        }
        public TransportoPriemone() { }


    }
}
