using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // kell a beolvasáshoz a txt nek

namespace Gyakorlás
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hány elemű legyen a tömb?: ");

            int N = int.Parse(Console.ReadLine());
            List<int> gyumolcsok = new List<int>();

            int[] gyumolcsok1 = new int[N];
            Random r = new Random();
            for(int i=0; i<N; i++)
            {
                gyumolcsok.Add(r.Next(0, 101));
                gyumolcsok1[i] = r.Next(0, 101);
            }
            Console.WriteLine("A gyumolcsok lista elemei: ");
            for(int i=0; i<N; i++)
            {
                Console.Write($"{gyumolcsok[i]}, ");
            }
            Console.WriteLine();

            Console.WriteLine("A gyumolcsok1 tomb elemei: ");
            foreach (int gyumolcs in gyumolcsok1)
            {
                Console.Write($"{gyumolcs}, ");
            }

            Console.WriteLine("A gyumolcsok lista elemei rendezetten: ");
            gyumolcsok.Sort();
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{gyumolcsok[i]}, ");
            }

            Console.WriteLine();

            Console.WriteLine("A gyumolcsok1 tömb elemei rendezetten: ");
            int osszeg = gyumolcsok1.Sum();
            int min = gyumolcsok1.Min();
            int max = gyumolcsok1.Max();


            int osszeg2 = 0;
            int[,] gyumolcsok2 = new int[3, 5];
            for (int i = 0; i< 3; i++)
            {
                for(int j=0; j<5; j++)
                {
                    gyumolcsok2[i, j] = r.Next(0, 101);
                    osszeg2 += gyumolcsok2[i, j]; // összegzés tétele
                }
            }

            
            foreach(int elem  in gyumolcsok1)
            {
                Console.Write($"{elem}, ");
            }
            Console.WriteLine();

            Console.ReadLine();
            */

            // File beolvasás

            string[] beolvas = File.ReadAllLines("adatok.txt"); // beolvassa a txt file-t egy tömbbe


            Console.ReadLine();
        }
    }
}
