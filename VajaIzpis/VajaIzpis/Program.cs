using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaIzpis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 20;
            double b = -13.6667;
            double c = 17;
            double d = 12.88;
            double e = 2222.879;

            Console.WriteLine("{0,20}", a);
            Console.WriteLine("{0,20}", b);
            Console.WriteLine("{0,20}", c);
            Console.WriteLine("{0,20}", d);
            Console.WriteLine("{0,20}", e);

            double r = 12345.6789;
            Console.WriteLine("r={0,10:f2}",r);
            //f2-za 2 decimalni mesti, x- hexadecimalno, d-decimalno, e- št*10 na N, n- itpiše s . in ,, p-izpiše kot procent     
            Console.ReadLine();
        }
    }
}
