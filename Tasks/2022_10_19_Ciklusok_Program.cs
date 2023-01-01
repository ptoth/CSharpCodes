using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            // 1. Ciklus segítségével írjuk ki a számokat egymás
            // mellé 30-tól 20-ig kettesével visszafelé!

            Console.WriteLine("1. Ciklus segítségével írjuk ki a számokat egymás mellé 30-tól 20-ig kettesével visszafelé!");
            int szam = 0;
            for (szam=30; szam >=20; szam-=2)
            {
                Console.Write($"{szam} ");
            }


            // 2. Oldjuk meg az előző feladatot while ciklus
            // segítségével!

            Console.WriteLine("2. Oldjuk meg az előző feladatot while ciklus segítségével!");
            int szam1 = 30;
            while (szam1 >= 20)
            {
                Console.Write($"{szam1} ");
                szam1 -= 2;
            }

            // 3. Kérjünk be egy értéket 15 és 25 között (a program csak a megadott tartományból fogadjon el értékeket)!	

            Console.WriteLine("3. Kérjünk be egy értéket 15 és 25 között (a program csak a megadott tartományból fogadjon el értékeket)!");



            int szam2 = int.Parse(Console.ReadLine());
            if (szam2 <= 25)
            {
                if (szam2 >= 15) Console.WriteLine("A számod beleesik a 15 és a 25 értékbe.");
            else if (szam2 >= 26)






            // 4. Hozzunk létre egy akkora méretű egész típusú tömböt, 
            // mint amekkora érteket a felhasználó az előző feladatban
            // megadott. Töltsük fel a tömböt véletlen egész számokkal
            // [10...50] között.

            Console.WriteLine("4. Hozzunk létre egy akkora méretű egész típusú tömböt, mint amekkora érteket a felhasználó az előző feladatban megadott. Töltsük fel a tömböt véletlen egész számokkal [10...50] között.");

                int[] tombocke = new int[szam];
                Random vel = new Random();
                for(int i=0; i<szam; i++)
                {
                    tombocke[i] = vel.Next(10, 51);
                    {
                        for (int i = 0; i < szam; i++)
                        {
                            Console.Write($"{tombocke[i]}; ");
                        }
                    }
                }
                Console.WriteLine();





            // 5. Adjuk össze a tömb elemeit és írjuk ki a végeredményt!

            Console.WriteLine("5. Adjuk össze a tömb elemeit és írjuk ki a végeredményt!");

                int osszeg = 0;
                for(int i=0; i<szam; i++)
                {
                    osszeg += tombocke[i];
                }
                Console.WriteLine($"A tömb elemeinek az összege: {osszeg}");




            // 6. Igaz-e, hogy a tömbben ugyanannyi 30-nál kisebb elem van, mint nagyobb?

            Console.WriteLine("6. Igaz-e, hogy a tömbben ugyanannyi 30-nál kisebb elem van, mint nagyobb?");

            int k_30 = 0;
            int n_30 = 0;
            for (int i=0; i<szam; i++)
            {
                    if (tombocke[i] < 30) k_30++;
                    else if (tombocke[i] > 30) n_30++;
            }
                if (k_30 == n_30) Console.WriteLine("Igaz, hogy ugyanannyi....");
                else Console.WriteLine("Nem igaz, hogy....");

            Console.ReadLine();

        }
    }
}
