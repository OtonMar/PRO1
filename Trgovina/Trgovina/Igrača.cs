using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovina
{
    internal class Igrača:AbstractProduct
    {
        public Igrača(int i, string im, double p)
        {
            id = i;
            ime = im;
            cena = p;
        }
        public override string GetDescription()
        {
            return "To je eden od primerkov igrače";
        }

        public override double GetDiscountedPrice()
        {
            return cena * 0.5;
        }
    }
}
