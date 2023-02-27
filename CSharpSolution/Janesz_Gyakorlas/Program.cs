namespace Janesz_Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("10 szám: ");
            string szamok = Console.ReadLine();
            */

            
            
            int[] beolvasottSzamok = new int[10];
            string szamok = null;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1+". szám");
                szamok = Console.ReadLine();
                beolvasottSzamok[i] = int.Parse(szamok);
            }


            // Console.WriteLine(beolvasottSzamok);

            for (int i = 0; i < beolvasottSzamok.Length; i++)
            {
                Console.WriteLine(beolvasottSzamok[i]);
            }

            int minimum = beolvasottSzamok[0];
            int maximum = 0;

            for (int i = 0; i < beolvasottSzamok.Length; i++)
            {
                if (beolvasottSzamok[i] > maximum)
                {
                    maximum = beolvasottSzamok[i];
                }

                if (beolvasottSzamok[i] < minimum)
                {
                    minimum = beolvasottSzamok[i];
                }
            }

            Console.WriteLine("Minimum:  " + minimum);
            Console.WriteLine("Maximum:  " + maximum);

            // olvassunk be egy számot, majd ellenőrizzük, hogy oszható-e 2-vel vagy 3-mal
            List<int> oszthatoKettovel = new List<int>();
            List<int> oszthatoHarommal = new List<int>();


            for (int i = 0; i < beolvasottSzamok.Length; i++)
            {
                if (beolvasottSzamok[i] % 2 == 0)
                {
                    oszthatoKettovel.Add(beolvasottSzamok[i]);
                }

                if (beolvasottSzamok[i] % 3 == 0)
                {
                    oszthatoHarommal.Add(beolvasottSzamok[i]);
                }
            }

             Console.Write("Az alábbi számok osztható ketttővel: " );
            for (int i = 0; i < oszthatoKettovel.Count; i++)
            {
                Console.Write(oszthatoKettovel.ElementAt(i)+" ");
            }
            Console.WriteLine("");
            Console.Write("Az alábbi számok osztható hárommal: " );
            for (int i = 0; i < oszthatoHarommal.Count; i++)
            {
                Console.Write(oszthatoHarommal.ElementAt(i)+" ");
            }

            

            // olvassunk be két számot, majd írjuk ki az összegét
            
            int[] beolvasottSzamok2 = new int[2];
            string szamok2 = null;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i + 1 + ". szám");
                szamok2 = Console.ReadLine();
                beolvasottSzamok2[i] = int.Parse(szamok2);
            }
           
            Console.WriteLine("Két szám összege: " + beolvasottSzamok2[0] + beolvasottSzamok2[1]);

            
            
            Console.WriteLine("adja meg az első számot");
            int elsoSzam = int.Parse(Console.ReadLine());
            Console.WriteLine("adja meg az második számot");
            int masodikSzam = int.Parse(Console.ReadLine());
            Console.WriteLine(elsoSzam+masodikSzam);
            


            // olvassunk be 3 számot egy tömbbe, majd írassuk ki őket visszafelé.

            int[] beolvasottSzamok3 = new int[3];
            string szamok3 = null;
            for (int i = 0; i < beolvasottSzamok3.Length; i++)
            {
                Console.WriteLine(i + 1 + ". szám");
                szamok3 = Console.ReadLine();
                beolvasottSzamok3[i] = int.Parse(szamok3);
            }

            //Visszafelé kiírás
            for (int i = beolvasottSzamok3.Length-1; i >= 0; i--)
            {
                Console.WriteLine(beolvasottSzamok3[i]);
            }
            
        }
    }
}