using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Zunanji:Lokacija
    {
        bool jeVroče;
        public Zunanji(string i, bool v) : base(i)
        {
            jeVroče = v;
        }
        public new string Opis()
        {
            string r = base.Opis();
            r += Environment.NewLine;
            r += "Je vroče? " + jeVroče + Environment.NewLine;
            return r;
        }
    }
}
