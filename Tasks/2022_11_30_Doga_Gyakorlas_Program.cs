using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Doga_Gyakolrás
{
    class Program
    {
        static void beolvas(int[] hova, string honnan)
        {
            string[] fajlbol = File.ReadAllLines(honnan);
            for(int i=0; i<fajlbol.Length; i++)
            {
                hova[i] = int.Parse(fajlbol[i]);
            }
        }

        static void kiir(int[] mit)
        {
            foreach(int elem in mit)
            {
                Console.Write($"{elem}, ");
            }
            Console.WriteLine();
        }

        static int osszegzes(int[] tomb)
        {
            int s = 0;  // Összegzés Tétel
            for(int i=0; i<tomb.Length; i++)
            {
                s += tomb[i];
            }
            return s;
        }


        static int megszamol(int[] hol) // tulajdonság == 0
        {
            int db = 0;
            for(int i=0; i<hol.Length; i++)
            {
                if (hol[i] == 0) db++; // db = db+1; db +=1
            }
            return db;
        }

        static bool eldontes(int[] hol) //van-e 0 elem
        {
            bool van = false;
            int i = 0;
            while(hol[i] !=0 && i < hol.Length)
            {
                i++;
            }
            if (i < hol.Length) van = true;
            else van = false;
            return van;
        }
        static void Main(string[] args)
        {
            int[] be= new int[30];
            string file = "adatok.txt";
            beolvas(be, file);
            kiir(be);
            int tömb_összeg = osszegzes(be);
            if (eldontes(be))
            {
                Console.WriteLine($"A tömbben van 0 szám, mégpedig {megszamol(be)} db.");
            }
            else Console.WriteLine($"A tömmben nincs 0 szám.");


            Console.WriteLine($"A tömb elemeinek az összege: {tömb_összeg}");
            Console.WriteLine($"A tömb elemeinek az összege: {osszegzes(be)}");

            Random vel = new Random();
            string[] kiiras=new string[80];
            for(int i=0; i<kiiras.Length; i++)
            {
                kiiras[i] = Convert.ToString(vel.Next(-5, 4));
            }
            File.WriteAllLines("delfinadatok.txt", kiiras);

            Console.ReadLine();
        }
    }
}
