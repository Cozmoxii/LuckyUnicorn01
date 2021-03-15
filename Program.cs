using System;

namespace LuckyUnicorn01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Lucky Unicorn!!\n\n");

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Have you played before? y/n");
                char userinput = Convert.ToChar(Console.ReadLine().ToLower()[0]);

                if (userinput == 'y')
                {
                    Console.WriteLine("Start game");
                    flag = false;
                }

                else if (userinput == 'n')
                {
                    Console.WriteLine("Show Instructions");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("----ERROR PLEASE ENTER Y/N----");
                }
            }
           
        }
    }
}
