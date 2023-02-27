using System.Reflection.Metadata;
using System;

namespace _09_Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Az alapok:
             */
            /*
            //Írj programot, mely beolvassa egy derékszögű háromszög két befogóját, és megadja az átfogójának a hosszát!
            //Az átfogót 2 tizedesjeggyel add meg!
            Console.WriteLine("adja meg a háromszög egyik befogóját");
            int aBefogo = int.Parse(Console.ReadLine());
            Console.WriteLine("adja meg a háromszög másik befogóját");
            int bBefogo = int.Parse(Console.ReadLine());

            double atFogo = Math.Sqrt(Math.Pow(aBefogo, 2) + Math.Pow(bBefogo, 2));
            Console.WriteLine("Az átfogó hossza: " + Math.Round(atFogo, 2));

            //Írj programot, mely beolvassa a téglatest három élének hosszát, és kiírja a felszínének és térfogatának mérőszámát!
            Console.WriteLine("adja meg a \"a\" él hosszát:");
            int aElHossz = int.Parse(Console.ReadLine());
            Console.WriteLine("adja meg a \"b\" él hosszát:");
            int bElHossz = int.Parse(Console.ReadLine());
            Console.WriteLine("adja meg a \"c\" él hosszát:");
            int cElHossz = int.Parse(Console.ReadLine());

            double terfogat = aElHossz * bElHossz * cElHossz;
            double felszin = 2 * ((aElHossz * bElHossz) + (aElHossz * cElHossz) + (bElHossz * cElHossz));
            Console.WriteLine("A térfogat: " + terfogat + " a felszín: " + felszin);

            //Írj programot, mely beolvassa egy kör átmérőjét, és kiírja a kör kerületét és területét!
            Console.WriteLine("adja meg a átmérő hosszát:");
            int diameter = int.Parse(Console.ReadLine());
            double radius = diameter / 2;
            double terulet = Math.Pow(radius,2) * Math.PI;
            double kerulet = 2 * radius * Math.PI;

            Console.WriteLine("A kerulet: " + kerulet + " a terulet: " + terulet);

            //Írj programot, mely beolvas egy pozitív egész számot, és kiírja az egész számokat a képernyőre eddig a számig,
            //egymástól szóközzel elválasztva!(for ciklussal)
            Console.WriteLine("adja meg az ön által választott egész számot:");
            int valasztottSzam = int.Parse(Console.ReadLine());
            for (int index = 0; index <= valasztottSzam; index++)
            {
                Console.Write(index+ " ");
            }

            //Írj programot, mely beolvas egy pozitív egész számot, és kiírja az egész számokat egymás alá a képernyőre eddig a számig!
            //(while ciklussal)
            Console.WriteLine("adja meg az ön által választott egész számot:");
            int valasztottSzam2 = int.Parse(Console.ReadLine());
            int i = 0;
            while (i <= valasztottSzam2)
            {
                Console.WriteLine(i + " ");
                i++;
            }

            //Írj programot, mely addig olvas be számokat a billentyűzetről, ameddig azok kisebbek, mint tíz.
            //Írja ki ezek után a beolvasott számok összegét!

            ///FIXME
            
            int beolvasottSzam = 0;
            List<int> szamokListaja = new List<int>();
            while (beolvasottSzam < 10)
            {
                Console.WriteLine("Adjon meg egy számot, ha 10-nél nagyobb, többet beolvasás nincs:");
                szamokListaja.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(szamokListaja.Sum());
            */

            //Tömbök:
            //Olvass be pár számot(a darabszámot is kérje be a program), majd írd ki a páratlanok darabszámát.
            //Programozási tétel: megszámlálás
            Console.WriteLine("adja meg, hány számot szeretne megadni:");
            int tombMeretParatlan = int.Parse(Console.ReadLine());
            int[] szamokTomb = new int[tombMeretParatlan];

            for (int j = 0; j < tombMeretParatlan; j++)
            {
                Console.WriteLine("Adja meg az "+(j+1)+". számot:");
                szamokTomb[j] = int.Parse(Console.ReadLine());
            }

            int paratlanSzamokDb = 0;
            for (int j = 0; j < tombMeretParatlan; j++)
            {
                if (szamokTomb[j] % 2 == 1) { paratlanSzamokDb++; }
            }
            Console.WriteLine("a páratlan számok darabszáma: "+paratlanSzamokDb);

            //Olvass be egy pár számot(a darabszámot is kérje be a program), majd írd ki a párosok összegét.
            //Programozási tétel: összegzés
            Console.WriteLine("adja meg, hány számot szeretne megadni:");
            int tombMeretParos = int.Parse(Console.ReadLine());
            int[] szamokTombParos = new int[tombMeretParatlan];

            for (int j = 0; j < tombMeretParatlan; j++)
            {
                Console.WriteLine("Adja meg az " + (j + 1) + ". számot:");
                szamokTombParos[j] = int.Parse(Console.ReadLine());
            }

            int parosSzamokOsszeg = 0;
            for (int j = 0; j < tombMeretParatlan; j++)
            {
                if (szamokTomb[j] % 2 == 0)
                {
                    parosSzamokOsszeg = parosSzamokOsszeg + szamokTomb[j]; 
                }
            }
            Console.WriteLine("a páros számok összege: " + parosSzamokOsszeg);

            //Olvassunk be egész számokat egy tömbbe(a darabszámot is kérje be a program), majd kérjünk be egy egész számot, és mondjuk meg, hogy hányszor szerepel a tömbben.
            //Programozási tétel: megszámlálás
            Console.WriteLine("adja meg, hány számot szeretne megadni:");
            int tombMerete2 = int.Parse(Console.ReadLine());
            int[] szamokTomb2 = new int[tombMerete2];

            for (int j = 0; j < tombMerete2; j++)
            {
                Console.WriteLine("Adja meg az " + (j + 1) + ". számot:");
                szamokTombParos[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("adja meg, hogy melyik számot keresi:");
            int keresettSzam2 = int.Parse(Console.ReadLine());

            int keresettSzamDarab = 0;
            for (int j = 0; j < tombMerete2; j++)
            {
                if (keresettSzam2 == szamokTomb2[j])
                {
                    keresettSzamDarab++;
                }
            }
            Console.WriteLine("a páros számok összege: " + keresettSzamDarab);

            //Olvassunk be egész számokat egy tömbbe(a darabszámot is kérje be a program), majd kérjünk be egy egész számot. 
            //Keressük meg a tömbben az első ilyen egész számot, majd írjuk ki a tömbindexét.
            //Ha a tömbben nincs ilyen szám,írjuk ki, hogy a beolvasott szám nincs a tömbben.
            Console.WriteLine("adja meg, hány számot szeretne megadni:");
            int tombMerete3 = int.Parse(Console.ReadLine());
            int[] szamokTomb3 = new int[tombMerete3];

            for (int j = 0; j < tombMerete3; j++)
            {
                Console.WriteLine("Adja meg az " + (j + 1) + ". számot:");
                szamokTombParos[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("adja meg, hogy melyik számot keresi:");
            int keresettSzam3 = int.Parse(Console.ReadLine());


            //String:
            //Olvass be egy szót, és írd ki a minden második betűjét egymás alá!
            //Olvass be egy mondatot, és írd ki a szavait egymás alá.
            //
            //Függvények:
            //Készíts programot, amely tetszőleges darab egész számot olvas be.
            //A programnak legyen egy metódusa, ami egy int tömböt vár paraméternek, és visszaadja a tömbben található legkisebb és legnagyobb elem értékét.
            //A program a függvényből visszaadott értéket írja ki.
            //
            //A programnak legyen egy metódusa, ami két paramétert vár: egy int tömböt, valamint egy logikai értéket, hogy a páros, vagy páratlan számokat akarjuk megszámolni a tömbben.
            //A metódus adja vissza, hogy a logikai paraméter által meghatározott típusú számokból hány darab található a tömbben. 
            //A metódust kétszer hívd meg: számolja össze a páros és páratlan értékeket is.
            //A program írja ki, hogy páros, vagy páratlan számokból volt több a bemenetben.
            //
            //Az első és a második bemenet egy - egy index érték lesz, minden további bemenet kerüljön egy int tömbbe. 
            //A programnak legyen egy metódusa, ami egy int tömb valahanyadik elemét keresi meg. 
            //Ehhez 3 paramétert kérjen: az tömböt, a keresendő elem indexét, valamint egy logikai értéket, hogy balról, vagy jobbról keressen a tömbben.
            //A program hívja meg ezt a metódust kétszer: az első beolvasott indexel balról keress a tömbben, a másodikkal pedig jobbról.Mindkét eredményt írd ki. 

        }
    }
}