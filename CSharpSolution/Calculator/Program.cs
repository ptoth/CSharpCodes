namespace _02_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. reading input number and operator
            Console.WriteLine("Enter your first number:");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Enter your second number:");
            string secondNumberInput = Console.ReadLine();

            Console.WriteLine("Enter your operator:");
            string operatorSign = Console.ReadLine();

            // 2. convert input to numeric
            int firstNumber = Convert.ToInt32(firstNumberInput);
            int secondNumber = Convert.ToInt32(secondNumberInput);

            if (operatorSign == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }

            if (operatorSign == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }

            if (operatorSign == "*")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }

            if (operatorSign == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);
            }

            if (operatorSign == "%")
            {
                Console.WriteLine(firstNumber % secondNumber);
            }

            Console.ReadLine();
        }
    }
}