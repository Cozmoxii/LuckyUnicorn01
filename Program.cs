//imports
using System;

namespace LuckyUnicorn01
{
    class Program
    {
        //global variables

        //methods

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

        //main process
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Lucky Unicorn!!\n\n");

            if (CheckYesNo().Equals("y")) 
            {
                Console.WriteLine("start game");
            }
            else
            {
                Console.WriteLine("Show Instructions");
                Console.WriteLine("start game");
            }

            
           
        }
    }
}
