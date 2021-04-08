using System;
using System.Collections;

namespace DiceGame
{
    class Program
    {
        static Random _r = new Random();
        public static int age_Checker;

        static void Main(string[] args)
        {

            Console.WriteLine("Hello Dice player what's your name?");
            Console.Write("Enter your name here: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("How old are you?");
            age_Checker= Convert.ToInt32(Console.ReadLine());
            if (age_Checker < 16)
            { Console.WriteLine("Sorry, you must be 16 years old to enter the game");
                return;
            }

            else if (age_Checker >= 21)
                {
                Console.WriteLine("you are 21+ you can play the game with money");

                }
            else
            {
                Console.WriteLine("You are between the age of 16 and 21 you are able to play the but you cant play with money.");
            }

            Die dobbelsteen = new Die();
            dobbelsteen.ThrowDice();

            Console.WriteLine("Oh hello there. player" + name);
            Console.ReadLine();

            int x = _r.Next(1, 7);
            Console.WriteLine(1);

            Console.WriteLine("Player 1 has thrown the number above.");
            Console.ReadLine();
            Console.WriteLine("do you think you will throw lower or higher?");
            Console.ReadLine();

            ArrayList b = new ArrayList { };
            b.Add("");


            Console.WriteLine("When ever you are ready. You can throw the dice by pressing the 'any'-key.");
            Console.ReadLine();

            Random rd = new Random();
            int rand_num = rd.Next(1, 7);
            Console.WriteLine(rand_num);

            for (int i = 0; i < 7; i++)
            {

            }

            if (rand_num < x)
            {
                Console.WriteLine("You are right! ;D You win!");
            }
            else if (rand_num > x)
            {
                Console.WriteLine("You Guessed wrong ): You lose!");
            }
            else if (rand_num == x)
            {
                Console.WriteLine("Try again! :)");
            }
           
        }
    }
}
