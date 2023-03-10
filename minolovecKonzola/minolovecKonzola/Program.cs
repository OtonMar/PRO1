using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minolovecKonzola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool[,] mine = new bool[10 + 2, 10 + 2];
            Random r = new Random();
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j<=10; j++)
                {
                    mine[i, j] = r.NextDouble() < 0.25;
                    if (mine[i, j] == true)
                        Console.Write("* ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
            int[,] resitev = new int[10 + 2, 10 + 2];
            for(int k=1; k <= 10; k++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    for(int x = k - 1; x <= k + 1; x++)
                    {
                        for(int y = j - 1; y <= j + 1; y++)
                        {
                            if (mine[x, y] == true)
                                resitev[k, j]++;
                        }
                    }
                }
            }
            for(int k = 1; k <= 10; k++)
            {
                for(int j=1; j <= 10; j++)
                {
                    if (mine[k, j] == true)
                        Console.Write("*");
                    else
                        Console.Write(resitev[k, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
