//imports
using System;
using System.Collections.Generic;

namespace LuckyUnicorn01
{
    class Program
    {
        //global variables

        //private static List<string> animals = new List<string> {"horse","donkey","zebra","unicorn" };
        private static float money;
        //methods

        private static int MoneyCheck(int low, int high)
        {
            bool valid = false;
            while (!valid)
            {
                string error = $"Whoops! Please choose a whole number between {low} and {high}";

                try
                {
                    Console.WriteLine($"\nPlease enter the amount of money you want to spend between {low}$ and {high}$:" +
                        "\nWe do not accept decimal values.");
                    int response = Convert.ToInt32(Console.ReadLine());
                    if (low <= response && response <= high)
                    {
                        return response;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(error);

                }
            }
            return -1;
        }



        private static string CheckYesNo()
        {


            while (true)
            {
                Console.WriteLine("Have you played before? y/n");
                char userinput = Convert.ToChar(Console.ReadLine().ToLower()[0]);

                if (userinput == 'y')
                {
                    return "y";
                }

                else if (userinput == 'n')
                {
                    return "n";
                }
                else
                {
                    Console.WriteLine("----ERROR PLEASE ENTER Y/N----");
                }
            }

            //return "";
        }

        static void GetRandomAnimal()
        {
            Random rd = new Random();
            int randNum = rd.Next(0, 100);

            if (randNum >= 90) 
            {
                money += 4;
                Console.WriteLine("unicorn");
            }
            else if (randNum >= 60)
            {
                money -= (float)0.5;
                Console.WriteLine("zebra");

            }
            else if (randNum >= 30)
            {
                money -= (float)0.5;
                Console.WriteLine("horse");
            }
            else
            {
                money -= 1;
                Console.WriteLine("donkey");
            }

            



        }
        private static void StartGame()
        {

            int cost = MoneyCheck(1, 10);

            money += cost;

            Console.WriteLine("You will be spending " + cost + "$, so you shall recieve " + cost + " random animals\n");

            for (int i = 0; i < cost; i++)
            {
                GetRandomAnimal();
            }

            Console.WriteLine("\nYour balance is "+money+"$");

            

        }

      
        //main process
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Lucky Unicorn!!\n\n");

            if (CheckYesNo().Equals("y")) 
            {
                StartGame();
            }
            else
            {
                Console.WriteLine("\nIn this game, you will enter the amount of money you want to play----\n" +
                    "Based on the amount you have entered, there will be a random animal generated----\n" +
                    "A unicorn, donkey or horse can be generated--to be continued");
                StartGame();
            }

            
           
        }
    }
}
