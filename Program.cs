using System;
using System.Linq;
using System.Threading;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerInfo();
            Add(1, 5, 4);
            Subtract();
            Multiply();
            Divide();
            Modulus();
        }

        public static void PlayerInfo()
        {
            Console.WriteLine("Welcome, we need you to answer a few questions before we begin");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
                Thread.Sleep(1000);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
                Thread.Sleep(2000);

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
                Thread.Sleep(2000);

            Console.WriteLine("What is youre favorite animal?");
            string animal = Console.ReadLine();
                Thread.Sleep(2000);

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
                Thread.Sleep(2000);

            Console.WriteLine("Please confirm the below information is correct:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");
            Console.WriteLine("Press 'Enter' to confirm");
            Console.ReadLine();

            Console.WriteLine("Do you wish to start the game? y/n");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                GameStart();
            }
        }

        public static void GameStart()
        {
            Console.WriteLine("Pick a number between 1 and 10");
            int num1 = int.Parse(Console.ReadLine());


            Random rnd = new Random();
            int[] prob = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int randomNumber = rnd.Next(0, 10);
            int randNum = prob[randomNumber];

            if (randNum == num1)
            {
                YouWin();
            }
            else YouLost();
        }

        public static void YouWin()
        {
            Console.WriteLine("You won the game!");
            Console.WriteLine("Play again?");
            Console.WriteLine("yes or no.");
            string choice = Console.ReadLine();

            if (choice == "yes")
            {
                Console.Clear();
                PlayerInfo();
            }
            else
            {
                End();
            }
        }

        public static void YouLost()
        {
            Console.WriteLine("You lost the game!");
            Console.WriteLine("Play again?");
            Console.WriteLine("yes or no.");
            string choice = Console.ReadLine();

            if (choice == "yes")
            {
                Console.Clear();
                PlayerInfo();
            }
            else
            {
                End();
            }
        }

        public static void End()
        {

        }


        public static void Add(params int[] numbers)
        {
            Console.WriteLine(numbers.Sum());
        }
        public static void Subtract()
        {
            Console.WriteLine("Enter the minuend:");
            int minuend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the subtrahend:");
            int subtrahend = int.Parse(Console.ReadLine());

            int diff = minuend - subtrahend;
            Console.WriteLine(diff);
        }
        public static void Multiply()
        {
            Console.WriteLine("Enter the first number to multiply:");
            int fact1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number to multiply:");
            int fact2 = int.Parse(Console.ReadLine());

            int product = fact1 * fact2;
            Console.WriteLine(product);
        }
        public static void Divide()
        {
            Console.WriteLine("Enter dividend:");
            decimal dividend = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter divisor:");
            decimal divisor = decimal.Parse(Console.ReadLine());

            decimal quotient = dividend / divisor;
            Console.WriteLine(quotient);
        }
        public static void Modulus()
        {
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            int num2 = int.Parse(Console.ReadLine());

            int mod = num1 % num2;
            Console.WriteLine(mod);
        }
    }
}
