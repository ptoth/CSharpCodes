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
        }
    }
}