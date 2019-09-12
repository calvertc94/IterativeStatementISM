using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Please enter a number between 1 and 100");
                int number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= 100)
                {
                    for (int i = 0; i < number; i++)
                    {
                        Console.WriteLine("You entered" + " " + number + ". This is the current integer value in the loop:" + i);
                        i++;
                    }
                }

                else
                {
                    Console.WriteLine("Please run this program again with a valid number");
                }
            }

            catch { }
        }
    }
}