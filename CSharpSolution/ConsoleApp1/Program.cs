// importing namespace will allow us to use the classes from it (like System.IO)
using System;

// namespace will allow us to organize our codes
namespace _01_ConsoleApp1
{
    internal class Program
    {
        // the function which is the starting point of our program, it should be named Main
        static void Main(string[] args)
        {
            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: basics...");
            Console.ReadLine();
            // ================================================================================

            // simple console output
            Console.WriteLine("Hello World!");

            // other examples
            Console.WriteLine("I am Learning C#");

            // providing mathematical expression
            Console.WriteLine(3 + 3);

            // write function
            Console.Write("Hello C#! ");
            Console.Write("I will print on the same line.");

            // this is a single line comment

            Console.Write("Test"); // also single line comment

            /* 
             * with this method,
             * you can
             * write
             * multiline comments
             */


            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: Basic types...");
            Console.ReadLine();
            // ================================================================================


            /*
                int     : 4 bytes Stores whole numbers from - 2,147,483,648 to 2,147,483,647
                long    : 8 bytes Stores whole numbers from - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                float   : 4 bytes Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
                double  : 8 bytes Stores fractional numbers. Sufficient for storing 15 decimal digits
            */

            int myFirstInt = 1; //stores integers(whole numbers)
            double myFirstDouble = 1.234; //stores floating point numbers
            char myFirstChar = 'a'; //stores single characters, values are surrounded by single quotes
            string myFirstString = "Lorem ipsum dolor sit amet...."; //stores text, String values are surrounded by double quotes
            bool myFirstBool = true; // true or false

            Console.WriteLine(myFirstInt);
            Console.WriteLine(myFirstDouble);
            Console.WriteLine(myFirstChar);
            Console.WriteLine(myFirstString);
            Console.WriteLine(myFirstBool);

            string firstName = "Irving ";
            string lastName = "Lambert";
            string fullName = firstName + lastName;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(fullName);
            Console.WriteLine(firstName + " " + lastName);


            // Casting - Implicit
            int myInt = 7;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 7
            Console.WriteLine(myDouble);   // Outputs 7

            // Casting - explicit 
            double myDoubleNum = 9.78;
            int myIntNum = (int)myDoubleNum;    // Manual casting: double to int

            Console.WriteLine(myDoubleNum);     // Outputs 9.78
            Console.WriteLine(myIntNum);        // Outputs 9

            // Conversion
            int myInteger = 10;
            double myDoubleNumber = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInteger));      // convert int to string
            Console.WriteLine(Convert.ToDouble(myInteger));      // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubleNumber));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));         // convert bool to string


            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: User input...");
            Console.ReadLine();
            // ================================================================================

            // Type your username and press enter
            Console.WriteLine("Enter your name:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string name = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Your name is: " + name);

            /*
             * The Console.ReadLine() method returns a string.
             * You cannot get information from another data type, such as int. 
             * The following program will cause an error:
             */
            //Console.WriteLine("Enter your age:");
            //int age = Console.ReadLine();
            //Console.WriteLine("Your age is: " + age);

            // corrected:
            Console.WriteLine("Enter your age:");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age2);

       

            /**
            Operators:
            Operator    Example     Meaning
            =           x = 5       x = 5
            +=          x += 3      x = x + 3
            -=          x -= 3      x = x - 3
            *=          x *= 3      x = x * 3
            /=          x /= 3      x = x / 3
            %=          x %= 3      x = x % 3

            &=          x &= 3      x = x & 3
            |=          x |= 3      x = x | 3
            ^=          x ^= 3      x = x ^ 3
            >>=         x >>= 3     x = x >> 3
            <<=         x <<= 3     x = x << 3


            Comparison operators:
            ==	    Equal to	                x == y	
            !=	    Not equal	                x != y	
            >	    Greater than	            x > y	
            <	    Less than	                x < y	
            >=	    Greater than or equal to	x >= y	
            <=	    Less than or equal to	    x <= y


            Logical operators:
            && 	Logical and	Returns true if both statements are true	                x < 5 && x < 10	
            || 	Logical or	Returns true if one of the statements is true	            x < 5 || x < 4	
            !	Logical not	Reverse the result, returns false if the result is true	    !(x < 5 && x < 10)
            */

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: Math...");
            Console.ReadLine();
            // ================================================================================

            // Mathematical calculations are in the Math class

            Console.WriteLine("Enter your first number:");
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            int firstNum = Convert.ToInt32(firstInput);
            int secondNum = Convert.ToInt32(secondInput);

            Console.WriteLine("The max is: " + Math.Max(firstNum, secondNum));
            Console.WriteLine("The min is: " + Math.Min(firstNum, secondNum));
            Console.WriteLine("The PI in C#: " + Math.PI);
            Console.WriteLine("Absolute of -3.56 is: " + Math.Abs(-3.56));
            Console.WriteLine("Rounding 9.521: " + Math.Round(9.112));
            Console.WriteLine("Rounding 9.521: " + Math.Ceiling(9.112));
            Console.WriteLine("Flooring 9.521: " + Math.Floor(9.999));


            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: Strings...");
            Console.ReadLine();
            // ================================================================================
            
            // string is a collection of characters

            string greeting = "Hello";

            // string 
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the alphabet string is: " + alphabet.Length);

            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            // working with strings: concatenation
            string firstNameString = "John ";
            string lastNameString = "Doe";
            string nameString = firstNameString + lastNameString;
            Console.WriteLine(nameString);

            string firstName2 = "John";
            string lastName2 = "Doe";
            string name2 = $"My full name is: {firstName2} {lastName2}";
            Console.WriteLine(name2);

            // Accessing strings like lists:
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
            Console.WriteLine(myString[1]);  // Outputs "e"
            Console.WriteLine(myString.IndexOf("ö"));  // Outputs "1"

            string escapeQuoteString = "We are the so-called \"Hackers\\\" from the IT world.";
            Console.WriteLine(escapeQuoteString);
            string example = "The character \\ is called backslash. We can also use a newline with \n character.";
            Console.WriteLine(example);

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: Booleans...");
            Console.ReadLine();
            // ================================================================================

            bool isItTrue = true;
            bool isItFalse = false;
            Console.WriteLine(isItTrue);   // Outputs True
            Console.WriteLine(isItFalse);   // Outputs False

            int x = 10;
            int y = 9;
            Console.WriteLine(x > y);

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: If-then-else...");
            Console.ReadLine();
            // ================================================================================

            int firstNumber = 20;
            int secondNumber = 18;

            // if
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("20 is greater than 18");
            }

            // if-else
            if (firstNumber < secondNumber)
            {
                Console.WriteLine("First number is greater.");
            }
            else
            {
                Console.WriteLine("Second number is greater.");
            }

            // if-else if-else
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is greater.");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("Second number is greater.");
            }
            else
            {
                Console.WriteLine("Even?");
            }

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: switch case...");
            Console.ReadLine();
            // ================================================================================

            Random randGen = new Random();

            int day = randGen.Next(7);
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Greater than 7");
            }
        }
    }
}