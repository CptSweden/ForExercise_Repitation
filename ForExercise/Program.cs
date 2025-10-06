using System.Diagnostics.CodeAnalysis;

namespace ForExercise
{
    internal class Program
    {
        
        static void Main(string[] args)
        {           
            // #1
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            // #2
            for (int i = 2;i <= 20; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            // #3
            Console.Write("Enter a number to get it's multiplication table: ");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 1;i <= 10;i++)
            {
                int result = userInput * i;

                Console.WriteLine(result);
            }
            
            Console.WriteLine("");

            // #4
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lift Off");

            Console.WriteLine("");

            // #5
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers from 1 - 100 is {sum}");

            // #6
            for (int i = 1; i <= 5 ; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");

            // #7
            Console.Write("Enter a number to calculate it's factorial:");
            int userNumber = int.Parse(Console.ReadLine());

            int factorial = 1;

            for(int i = 1; i <= userNumber ; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factoiral of {userNumber} is {factorial}");
        }
        

        



    }
}
