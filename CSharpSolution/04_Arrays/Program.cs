namespace _04_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: arrays...");
            Console.ReadLine();
            // ================================================================================
            // Declare an empty array
            string[] cars;

            // Declare with initial values
            string[] myCars = { "Volvo", "BMW", "Mazda" };

            // Another example
            int[] myNumbers = { 10, 20, 30, 40 };

            // Other options
            // Create an array of four elements, and add values later
            string[] myFutureCars = new string[4];

            // Create an array of four elements and add values right away 
            string[] myOldCars = new string[3] { "Fiat", "Ford", "Skoda" };

            // Create an array of four elements without specifying the size 
            string[] myDreamCars = new string[] { "Ferrari", "Lotus", "Bugatti", "Aston Martin" };

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: accessing through arrays...");
            Console.ReadLine();
            // ================================================================================
            // Accessing array item by index
            Console.WriteLine(myCars[0]); // Outputs Volvo

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: iterating through arrays...");
            Console.ReadLine();
            // ================================================================================

            for (int index = 0; index < myNumbers.Length; index++)
            {
                Console.WriteLine(myNumbers[index]);
            }

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: change element by index...");
            Console.ReadLine();
            // ================================================================================
            myCars[0] = "Opel";

            Console.ReadLine();
        }
    }
}