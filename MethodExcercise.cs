using System;

namespace MethodExcersise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is youfavorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, His favorite color was {userColor}");
            Console.WriteLine($"his favorite animal was a {userAnimal}, He also loved to listen to {userBand}");


        }
    }
}
