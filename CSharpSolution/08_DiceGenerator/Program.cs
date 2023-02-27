namespace _08_DiceGenerator
{
    public class Kocka
    {
        int oldalakSzama;

        // konstruktor
        public Kocka(int kockaOldalainakSzama) 
        {
            this.oldalakSzama = kockaOldalainakSzama;
        }

        public int kockaDobas()
        {
            Random randGen = new Random();
            int result = randGen.Next(6)+1;
            return result;
        }

        public int kockaDobas_egyedi(int hanyOldalaVanAKockanak) 
        {
            Random randGen = new Random();
            int result = randGen.Next(hanyOldalaVanAKockanak) + 1;

            if (result > this.oldalakSzama)
            {
                Console.WriteLine("Csalás, ekkorát nem tudsz dobni");
                result = 0;
            }
            
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // simply roll a 6 sided dice
            Console.WriteLine("Kocka rolls!");
            Kocka butaKocka = new Kocka(6);
            Console.WriteLine(butaKocka.kockaDobas());

            // rolling a custom dice
            Console.WriteLine("Please provide the # of sides of the cube:");
            String input = Console.ReadLine();
            int kockaOldalainakSzama = int.Parse(input);
            Console.WriteLine(butaKocka.kockaDobas_egyedi(kockaOldalainakSzama));

            Kocka okosKocka = new Kocka(8);



            Console.ReadLine();
        }
    }
}