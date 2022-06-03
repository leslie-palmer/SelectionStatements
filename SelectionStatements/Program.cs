using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates Random r, assigns a random number to favNumber
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            //Assigns an int from user to userInput
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            //Compares userInput to favNumber and gives output based on result
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
