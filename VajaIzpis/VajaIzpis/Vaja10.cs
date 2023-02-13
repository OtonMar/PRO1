using System;
using System.Collections.Generic;
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
            int abc=0;
            String x;
            Console.WriteLine("Vnesite temperaturo vode (od 5-100)");
            x = Console.ReadLine();
            int a = Convert.ToInt32(x);
            if (a <= 10)
            {
                Console.WriteLine("zelo mrzla");
                abc = 1;
            }
            else if (10<a & a<=20)
            {
                Console.WriteLine("hladna");
                abc = 2;
            }
            else if (20 < a & a <= 30)
            {
                Console.WriteLine("topla");
                abc = 3;
            }
            else if (30 < a & a <= 50)
            {
                Console.WriteLine("vroča");
                abc = 4;
            }
            else if (a > 50)
            {
                Console.WriteLine("zelo vroča");
                abc = 5;
            }


            switch (abc)
            { 
                case 1:
                    Console.WriteLine("zelo mrzla");
                    break;

                case 2:
                    Console.WriteLine("hladna");
                    break;

                case 3:
                    Console.WriteLine("topla");
                    break;

                case 4:
                    Console.WriteLine("vroča");
                    break;

                case 5:
                    Console.WriteLine("zelo vroča");
                    break;
            }
            Console.ReadLine();

            
        }
    }
}
