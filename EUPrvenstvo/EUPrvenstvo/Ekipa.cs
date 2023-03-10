using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EUPrvenstvo
{
    internal class Ekipa
    {
        String ime;
        int štTekem;
        int štZmag;
        int štNeoodločenih;
        int daniGoli;
        int prejetiGoli;
        public Ekipa(string i)
        {
            ime = i;
            štTekem=0;
            štZmag=0;
            štNeoodločenih=0;
            daniGoli=0;
            prejetiGoli=0;
        }

        public void VnesiRezultat(int d, int p)
        {
            //d - dani goli, p- prejeti goli
            štTekem++;
            if (d > p)
                štZmag++;
            else if (d == p)
            {
                štNeoodločenih++;
            }
            daniGoli += d;
            PrejetiGoli += p;
        }
        public int številoTočk()
        {
            return 3 * štZmag + štNeoodločenih;
        }

        public int GolRazlika()
        {
            return daniGoli - prejetiGoli;
        }

        public void Izpis()
        {
            Console.WriteLine(ime+"\t"+številoTočk()+"\t"+GolRazlika()+"\t"+daniGoli);
        }

        public bool boljšaEkipa(Ekipa druga)
        {
            if (this.številoTočk() > druga.številoTočk())
                return true;
            if (this.številoTočk() == druga.številoTočk() && this.GolRazlika() > druga.GolRazlika())
                return true;
            if (this.številoTočk() == druga.številoTočk() && this.GolRazlika() == druga.GolRazlika()&& this.daniGoli>druga.daniGoli)
                return true;
            return false;
        }

        public string Ime { get => ime; set => ime = value; }
        public int ŠtTekem { get => štTekem; set => štTekem = value; }
        public int ŠtZmag { get => štZmag; set => štZmag = value; }
        public int ŠtNeoodločenih { get => štNeoodločenih; set => štNeoodločenih = value; }
        public int DaniGoli { get => daniGoli; set => daniGoli = value; }
        public int PrejetiGoli { get => prejetiGoli; set => prejetiGoli = value; }
    }
}
