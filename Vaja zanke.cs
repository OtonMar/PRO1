using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Vaja10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = 0;
            long vsota=0;
            double obresti = 0;
            for (int i = 0; i < 100000; i++)
                {
                x = r.Next(1000000);
                vsota = vsota  + x;
                //za vsoto vsega
                obresti = obresti + (x / 100 * 2.3);

                }
            Console.WriteLine((vsota / 100 * 2.3) + " je 2.3% seštevka vseh računov");
            Console.WriteLine(obresti +" je račun usake posamezne obresti skupaj");
            Console.ReadLine();
        }
            

            
        }
    }
