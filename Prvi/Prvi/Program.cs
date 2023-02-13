using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vsota = 0;
            int i = 0;
            int x;
            
            while (i < 10)
            {
                i++;
                Console.WriteLine("vpišite " +i+". število");
                x =int.Parse( Console.ReadLine());
                vsota = vsota + x;
            }
            Console.WriteLine("vsota števil je "+vsota);
            Console.ReadLine();
            i = 0;
            vsota = 0;
            do
            {
                i++;
                Console.WriteLine("vpišite " + i + ". število");
                x = int.Parse(Console.ReadLine());
                vsota = vsota + x;
            } while (i < 10);
            Console.WriteLine("vsota števil je " + vsota);
            Console.ReadLine();
        }
        
    }
}
