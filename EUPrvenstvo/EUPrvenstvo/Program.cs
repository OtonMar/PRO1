using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUPrvenstvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ekipa a = new Ekipa("Slovenija");
            Ekipa b = new Ekipa("Italija  ");
            a.VnesiRezultat(2, 1);
            b.VnesiRezultat(1, 2);
            a.Izpis();
            b.Izpis();
            if(a.boljšaEkipa(b))
                Console.WriteLine("Slovenija je boljša");
            else
                Console.WriteLine("Italija je boljša");
            Console.ReadLine();
        }
    }
}
