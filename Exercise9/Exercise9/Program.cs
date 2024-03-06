using System.Globalization;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowWidth;
            int numberOfRows;

            //This will parse the numbers that you wrote into the console.
            Console.WriteLine("How many rows of asterisks do you want?");
            numberOfRows = int.Parse(Console.ReadLine());

            Console.WriteLine("What do you want the length of each row to be?");
            rowWidth = int.Parse(Console.ReadLine());

            //I put a for loop in a for loop, so you can for loop while you for loop.
            //This will
            for (int j = 0; j < numberOfRows; j++)
            {

                for (int i = 0; i < rowWidth; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            

            Console.WriteLine("How many rows of asterisks do you want?");
            int rows = int.Parse(Console.ReadLine());

            for (int k = 0; k <= rows; k++)
            {

                for (int y = 0; y <= k; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}