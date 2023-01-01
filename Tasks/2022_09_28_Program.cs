using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasodikProject_Ciklusok__.NET_Framework11_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Feladat Készíts egy programot, amely a felhasználótól bekér egy péros számot,
            //majd ennek megfelelően rajzol ki a képernyőre egy O alakzatot az alábbiak szerint!
            // O
            // O O
            // O O O 
            // O O O O
            // O O O O 
            // O O O
            // O O
            // O 
            Console.Write("Kérek egy páros számot: ");
            int n = int.Parse(Console.ReadLine());
            int m = n / 2;
            for(int i=1; i<=m; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("O ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i<=m; i++)
            {
                for (int j = m-i+1; j > 0; j--)
                {
                    Console.Write("O ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            //2. Feladat Kéeszíts egy programot, amely egymásba ágyazott ciklusok segítségével rajzolja ki
            // egy 5 x 5 -ös mezőben az alábbi alakzatot!
            // O x x x x
            // x O x x x
            // x x O x x
            // x x x O x
            // x x x x O
            Console.WriteLine("\n2. Feladat");
            for(int i=1; i<=5; i++)
            {
                for (int j=1; j<=5; j++)
                {
                    if (i == j)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // 3. Feladat Készíts egy programot, amely egymásba ágyazott ciklusok segítségével rajzolja ki
            // egy 7 x 7 es mezőben az alábbi alakzatot !

            // O x x x x x 0
            // x 0 x x x 0 x
            // x x 0 x 0 x x
            // x x x 0 x x x
            // x x 0 x 0 x x
            // x 0 x x x 0 x
            // 0 x x x x x 0

            Console.WriteLine("\3. Feladat");
            int n1 = 7;
            for(int i=1; i<=n1; i++)
            {
                for (int j=1; j<=3; j++)
                {
                    if(i==j)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(" ");
                for (int j=1; j<4; j++)
                {
                    if (i == (j + 3))
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}