using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi oddelek študenta 1-ang, 2-mat, 3-nar");
            int oddelek = int.Parse(Console.ReadLine());
            switch (oddelek)
            {
                case 1://ang
                    break;
                case 2:
                    ŠtudentMat m = new ŠtudentMat();
                    Console.WriteLine("Vnesi delni 1");
                    m.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi delni 2");
                    m.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(m.Izpis());
                    break;//mat
                case 3:
                    break;


            }
        }
    }
}
