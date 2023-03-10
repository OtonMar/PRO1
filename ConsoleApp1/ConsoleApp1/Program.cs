using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //char[,] c = new char[5, 5];
            //Random r = new Random();
            //for(int k = 0; k < c.GetLength(0); k++)
            //{
            //    for(int j = 0; j < c.GetLength(1); j++)
            //    {
            //        c[k, j] = (char)(r.Next(26) + 'a');
            //    }
            //}
            //for(int k = 0; k < 5; k++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {
            //        Console.Write(c[k, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //char min = 'z';
            //for(int k = 0; k < 5; k++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {
            //        if (c[k, j] < min)
            //            min = c[k, j];
            //    }
            //}
            //Console.WriteLine("Po abecedi je prva " + min);
            //Console.ReadLine();

            int[,] b = new int[10, 10];
            Random r = new Random();
            int max = 0;
            int sum = 0;

            for (int k = 0; k<10; k++)
            {
                for (int j = 0; j<10; j++)
                {
                    b[k,j] = r.Next(101);
                    Console.Write(b[k, j] + "\t");
                    sum += b[k, j];
                    if (b[k, j] > max)
                        max = b[k, j];
                }
                
                Console.WriteLine();
            }
            Console.WriteLine("Najvecji element v tabeli: " + max);
            Console.WriteLine("Sestevek vseh elementov je: " + sum);
            Console.ReadLine();

            for(int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == k)
                        Console.WriteLine(b[k, j]);
                    
                }
            }
            Console.ReadLine();
        }
    }
}
