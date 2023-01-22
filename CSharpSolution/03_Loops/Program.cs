using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace _03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int index = 0;
            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: while loop ...");
            Console.ReadLine();
            // ================================================================================
            /*
             * while (condition) 
             *  {
             *      // code block to be executed
             *  }
             */

            // Note: there is a chance that it will not run at all (=condition is false)
            while (index < 5)
            {
                Console.WriteLine(index);
                index++;
            }

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: do-while loop ...");
            Console.ReadLine();
            // ================================================================================
            /*
             * do 
             *  {
             *      // code block to be executed
             *  }
             *  while (condition);
             */

            // Note: it will run once for sure. Then it will check the condition
            index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index < 5);
            


            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: for loop from 0 to 5 with stepping of 1...");
            Console.ReadLine();
            // ================================================================================
            /* 
             * Syntax
             * for (statement 1; statement 2; statement 3) 
             * {    
             *      // code block to be executed
             * }
             * 
             * Statement 1 is executed(one time) before the execution of the code block.
             * Statement 2 defines the condition for executing the code block.
             * Statement 3 is executed(every time) after the code block has been executed.
             */

            for (index = 0; index < 5; index++)
            {
                Console.WriteLine(index);
            }

            // variable 'i' only exists in the loop. After it, it is destroyed.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            /*
             * Statement 1 sets a variable before the loop starts(int index = 0).
             * Statement 2 defines the condition for the loop to run(index must be less than 5).If the condition is true, the loop will start over again, if it is false, the loop will end.
             * Statement 3 increases a value(index++) each time the code block in the loop has been executed.
             */

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: for loop from 0 to 10 with stepping of 2...");
            Console.ReadLine();
            // ================================================================================
            for (int index2 = 0; index2 <= 10; index2 = index2 + 2)
            {
                Console.WriteLine(index2);
            }

            for (int index2 = 10; index2 >= 0; index2 = index2 - 2)
            {
                Console.WriteLine(index2);
            }

            for (int index2 = 0; index2 <= 10; index2 = index2 + 2)
            {
                Console.WriteLine(index2);
            }

            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: nested loop. Outer goes until 4, inner goes until 3...");
            Console.ReadLine();
            // ================================================================================// Outer loop
            for (int outerIndex = 1; outerIndex <= 4; outerIndex++)           {   
                Console.WriteLine("Sorok: " + outerIndex);  // Executes 2 times

                // Inner loop
                for (int innerIndex = 1; innerIndex <= 3; innerIndex++)
                {
                    Console.WriteLine(" Oszlopok: " + innerIndex); // Executes 6 times (2 * 3)
                }
            }


            // ================================================================================
            Console.WriteLine("==================================================");
            Console.WriteLine("Next: for loop, but it is for-each...");
            Console.ReadLine();
            // ================================================================================// Outer loop
            List<string> szavak = new List<string>();

            szavak.Add("Apple");
            szavak.Add("Banana");
            szavak.Add("Carrot");

            foreach (string aktualisElem in szavak)
            {
                Console.WriteLine(aktualisElem);
                // listából távolítja el az elemet
                szavak.Remove(aktualisElem);

                // az adott elemból távolítja az A betűt
                aktualisElem.Remove('A');

            }


            int[] szamok = { 0, 1, 2, 3 };
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
                szamok[i] = 0;

            }

            Console.ReadLine();
        }

    }
}