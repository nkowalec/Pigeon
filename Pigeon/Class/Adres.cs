using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pigeon
{
    public partial class Adres
    {
        public override string ToString()
        {
            return NrLokalu == "" ? Ulica + " " + NrDomu + ", " + KodPocztowy + " " + Miasto : Ulica + " " +NrLokalu+@"/"+ NrDomu + ", " + KodPocztowy + " " + Miasto;
        }

    }
}
