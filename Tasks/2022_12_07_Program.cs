using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20221207
{


    struct diak
    {
        public string nev;
        public int ev;
        public int honap;
        public int nap;
    }

    
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("diakok.txt");
            diak[] adatok = new diak[fajlbol.Length]; //tömbben
            List<diak> diakok = new List<diak>(); //listában 

            for(int i=0; i<fajlbol.Length; i++)
            {
                string[] darabol = fajlbol[i].Split(';');
                adatok[i].nev = darabol[0];

                diak kisdiak = new diak();
                kisdiak.nev = darabol[0];
                darabol = darabol[1].Split('.');
                adatok[i].ev = int.Parse(darabol[0]);
                adatok[i].honap= int.Parse(darabol[1]);
                adatok[i].nap = int.Parse(darabol[2]);

                kisdiak.ev = int.Parse(darabol[0]);
                kisdiak.honap = int.Parse(darabol[1]);
                kisdiak.nap = int.Parse(darabol[2]);
                diakok.Add(kisdiak);

                
            }
            int[] honapok = new int[12];
            for (int i = 0; i < fajlbol.Length; i++)
            {
                honapok[adatok[i].honap - 1]++;
            }
            string[] honapnev = new string[12] { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
            for(int i=0; i<12; i++)
            {
                Console.Write($"{honapnev[i]}-ban/-ben: \t {honapok[i]} fő született\n");
            }

        

        Console.ReadLine();
        }
       
    }
}
