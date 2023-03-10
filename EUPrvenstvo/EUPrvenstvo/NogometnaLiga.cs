using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUPrvenstvo
{
    internal class NogometnaLiga
    {
        Ekipa[] liga = new Ekipa[10];
        public NogometnaLiga()
        {
            liga[0] = new Ekipa("Slovenija");
            liga[1] = new Ekipa("Islandija");
            liga[2] = new Ekipa("Poljska  ");
            liga[3] = new Ekipa("Švica    ");
            liga[4] = new Ekipa("Srbija   ");
            liga[5] = new Ekipa("Nemčija  ");
            liga[6] = new Ekipa("Španija  ");
            liga[7] = new Ekipa("Grčija   ");
            liga[8] = new Ekipa("Italija  ");
            liga[9] = new Ekipa("Hrvaška  ");
        }



    }
}
