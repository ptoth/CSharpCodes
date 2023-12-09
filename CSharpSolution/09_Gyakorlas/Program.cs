using System.Reflection.Metadata;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace _09_Gyakorlas
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int[] kihuzottSzamok = new int[5];
            int kihuzottSzamokDb = 0;
            int[] tippeltSzamok = new int[5];
            Random randGen = new Random();
            bool talaltEgyezest = false;

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // számok kihúzása
            int i = 0;
            while (i < kihuzottSzamok.Length && kihuzottSzamokDb <= 5)
            {
                int kihuzottSzam = randGen.Next(1, 7);
                Console.WriteLine("A " + (i+1) + ". húzott szám: " + kihuzottSzam);
                
                if (i == 0)
                {
                    kihuzottSzamok[i] = kihuzottSzam;
                }
                else
                {
                    int j = 0;
                    while (j < i && talaltEgyezest == false)
                    {
                        if (kihuzottSzamok[j] == kihuzottSzam)
                        {
                            Console.WriteLine("A " + (j + 1) + ". szám ellenőrzése: Ezt a számot már kihúzták: " + kihuzottSzam);
                            kihuzottSzamok[i] = 666;
                            talaltEgyezest=true;
                            i--;
                            kihuzottSzamokDb--;
                        }
                        else
                        {
                            Console.WriteLine("A " + (j + 1) + ". szám ellenőrzése: Ezt a számot még nem húzták: " + kihuzottSzam);
                            kihuzottSzamok[i] = kihuzottSzam;
                            kihuzottSzamokDb++;
                        }
                        j++;
                       
                    }
                    Console.WriteLine("-------------");
                    talaltEgyezest = false;
                }
                i++;
            }

            for (int o = 0; o < kihuzottSzamok.Length; o++)
            {
                Console.WriteLine("A " + (o+1) + " kihúzott szám a: " + kihuzottSzamok[o]);
            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // tippelt számok beolvasása
            for (int j = 0; j < tippeltSzamok.Length; j++)
            {
                Console.WriteLine((j + 1) + ". adja meg az egyik számot: ");
                int ideiglhatos = int.Parse(Console.ReadLine());

                if (ideiglhatos > 45)
                {
                    Console.WriteLine("Túl nagy számot írtál be!");
                    j--;
                }

                else if (ideiglhatos < 1)
                {
                    Console.WriteLine("Túl kicsi számot írtál be!");
                    j--;
                }

                else
                {
                    tippeltSzamok[j] = ideiglhatos;
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            for (int k = 0; k < kihuzottSzamok.Length; k++)
            {
                Console.WriteLine("A "+(k+1)+"következő kihúzott szám a: " + kihuzottSzamok[k]);
            }

            Console.WriteLine("----------");

            for (int m = 0; m < tippeltSzamok.Length; m++)
            {
                Console.WriteLine("A " + (m + 1) + " következő tippelt szám a: " + tippeltSzamok[m]);
            }




        }
    }
}