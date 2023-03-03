using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovina
{
    internal abstract class AbstractProduct : IProduct
    {
        protected int id;
        protected string ime;
        protected double cena;
        public int GetiID()
        {
            return id;
        }

        public string GetIme()
        {
            return ime;
        }

        public double GetPrice()
        {
            return cena;
        }
        public abstract string GetDescription();
        public abstract double GetDiscountedPrice();
        public string GetCategory()
        {
            //če bo izvod razreda Igrača, vrni "igrača"
            if (this is Igrača)
                return "kategorija=Igrača";
            if(this is Knjiga)
                return "kategorija=knjiga";
            return "neznana kategorija";
        
        }
    }
}
