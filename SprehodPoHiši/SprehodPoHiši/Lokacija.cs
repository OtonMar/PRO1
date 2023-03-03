using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Lokacija
    {
        public string ime;
        public Lokacija[] izhodi;
        public Lokacija(string i)
        {
            ime = i;
        }
        //trenutno si v dnevni sobi, od tu lahko greš v jedilnico, sprednje dvorišče
        public string Opis()
        {
            string r = "";
            r += "trenutno si v " + ime;
            r += Environment.NewLine;
            r += "Od tu lahko greš: ";
            r += Environment.NewLine;
            for(int k=0; k<izhodi.Length; k++)
            {

                r += k + " - " + izhodi[k].ime;
                r += Environment.NewLine;
            }
            return r;
        }
    }
}
