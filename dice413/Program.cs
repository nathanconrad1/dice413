using System;

namespace dice413
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables
            Random r = new Random();
            int dice1 = 0;
            int dice2 = 0;
            int total = 0;
            float percent = 0;
            int rolls = 0;
            float dec = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!\n");
           
            
            // Get the amount of times they want to roll
            Console.Write("How many times do you want to roll: ");
            rolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach '*' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls + "\n" );

            // initize array blah (which is the possible combinations of two dice 
            int[] blah = new int[11];

            for (int i = 0; i <11 ; i++)
            {
                blah[i] = 0;
            }

            // roll the dice for the amount of rolls 
            for (int i = 0; i < rolls; i++)
            {
                total = 0;
                dice1 = r.Next(1, 7);
                dice2 = r.Next(1, 7);
                //counts the amount of times a number is rolled and puts it in the array blah
                total += dice1 + dice2;
                blah[total - 2] += 1;
            }
            //calculates the percent for each combination
            for (int i = 0; i < 11; i++)
            {
                dec = blah[i];
                percent = ((dec / rolls) * 100);
                Console.Write((i + 2) + ": ");
                //prints a star for each percent
                for (int x = 0; x < percent; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
