using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcen
{
    internal class ŠtudentMat : ŠtudentAbs
    {
        public override string Izpis()
        {
            string r = "";
            r += "********ŠTUDENT MATEMATIKE**********";
            r += Environment.NewLine + "Delni 1 " + delni1;
            r += Environment.NewLine + "Delni 2 " + delni2;
            r += Environment.NewLine + "Končna  " + Ocena();
            r += Environment.NewLine + "Črka    " + Črka();
            return r;

        }

        public override double Ocena()
        {
            return 0.5 * delni1 + 0.5 * delni2; 
        }

        public override string Črka()
        {
            double x = Ocena();
            if (x >= 90)
            {
                return "A";
            }
            if (x >= 83)
            {
                return "B";
            }
            if (x >= 76)
            {
                return "C";
            }
            if (x >= 65)
            {
                return "D";
            }
                return "F";
        }
    }
}
