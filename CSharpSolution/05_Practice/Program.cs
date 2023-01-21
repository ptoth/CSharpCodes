namespace _05_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bekérünk egy számot 1-100 között. Írjuk ki az összes osztóját.");

            string input = Console.ReadLine();
            int megadottSzam = Convert.ToInt32(input);

            for (int oszto = 1; oszto < megadottSzam; oszto++)
            {
                if (megadottSzam % oszto == 0)
                {
                    // a szám osztható maradék nélkül
                    Console.WriteLine("talált osztó: " + oszto);
                }
            }

            //---------------------------------------------------------------------------------

            Console.WriteLine("Bekérünk egy szöveget, és írassuk visszafelé.");

            input = Console.ReadLine();  // abcdef
            int szovegHossza = input.Length;    //=6

            for (int index = szovegHossza - 1; index >= 0; index--)
            {
                Console.Write(input[index]);
            }


            // lazy solution
            /*
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            */

            Console.WriteLine();

            //---------------------------------------------------------------------------------
            /*
            Feladatok:

            [Véletlen számok listája] 
            Készítsünk programot, amely bekér két számot, majd a kettő közötti számtartományban kiír a kért darab véletlen számot.
            
            [Pénzérmék] 
            Készítsünk programot, amely bekér egy összeget, majd kiírja, hogy azt hogyan lehet a lehető legkevesebb pénzérméből összeállítani.

            [Csempézés] 
            Készítsünk programot, amely segíti a burkoló mesterek munkáját. 
            A szükséges csempe mennyiségének a kiszámításához a program kérje be a terület szélességét, valamint a magasságát méterben, 
            majd számolja ki, hogy 20cm*20cm méretű csempék esetén hány darabra van szükség a munka elvégzéséhez 
            (a plusz 10%-ot az illesztések miatt illik rászámolnunk). 


            [Lottó]
            Készítsünk programot, mely kihúzza az ötöslottó nyerőszámait.
            + kérjünk be tippeket a felhasználótól, és nézzük meg hány találata van

            */

            string adottSor = "Dagály utca;2;2023.01.01;580;8";
            string[] aktualisSor = adottSor.Split(';');
            DateTime aktualisDatum = DateTime.Parse(aktualisSor[2]);
            Console.WriteLine("Adjon meg egy dátumot");
            string inputDatum = Console.ReadLine();
            DateTime megadottDatum = DateTime.Parse(inputDatum);
            Console.WriteLine(aktualisDatum);
            Console.WriteLine(megadottDatum);
            Console.WriteLine("különbség: "+(aktualisDatum-megadottDatum).Days);
        }

    }
}