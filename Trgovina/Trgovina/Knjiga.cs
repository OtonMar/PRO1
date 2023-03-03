using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovina
{
    internal class Knjiga : AbstractProduct
    {
        public Knjiga(int i, string im, double p)
        {
            id= i;
            ime = im;
            cena = p; 
        }
        public override string GetDescription()
        {
            return "To je eden od primerkov knjige";
        }

        public override double GetDiscountedPrice()
        {
            return cena * 0.9;
        }
    }
}
