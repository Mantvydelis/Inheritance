using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldejimas.Models
{
    public class Motociklas : TransportoPriemone
    {
        public bool TuriSideCart {  get; set; }

        public Motociklas(bool turiSideCart, string marke, string modelis, int maksimalusGreitis)
        {
            TuriSideCart = turiSideCart;
            Marke = marke;
            Modelis = modelis;
            MaksimalusGreitis = maksimalusGreitis;

        }

        public override string ToString()
        { 
            if (TuriSideCart = true) 
            {
                return $"{Marke} {Modelis}, Maksimalus greitis: {MaksimalusGreitis} ir turi sidecart";

            }
            else
            {
                return $"{Marke} {Modelis}, Maksimalus greitis: {MaksimalusGreitis} ir neturi sidecart";
            }

        }


    }
}
