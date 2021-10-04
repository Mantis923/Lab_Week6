/// HomeWork 6 (Graded Assignment)    
/// File Name: Lab_Week6(Graded Assignment)
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
///
///This is a guessing game. A number is randomly picked between 0 and 100
///looping until the number is found. For each guess the program would say higher
///or lower if incorrect(depending on whether it's higher or lower).When correct 
///the game will end and state how many guesses it took to find the right answer.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week6_Graded_Assignment_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int random_number = random.Next(0, 101);

            int guess =0 , NumberOfguesses = 100;
            bool gameEnds = false;

            Console.Write("Pick a number between 0 and 100: ");

            while (gameEnds == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                NumberOfguesses--;

                if (guess != random_number && NumberOfguesses == 0)
                {
                    Console.WriteLine("You have ran out of tries thank you for playing");
                    gameEnds = true;
                }

                else if (guess == random_number)
                {
                    Console.Write("Congrats!! You guessed the number in " + NumberOfguesses + " "+"tries out of 100" +" "
                        +"thank you for playing");
                    gameEnds = true;
                    NumberOfguesses += guess;
                }
                else if (guess < random_number)
                    Console.WriteLine("Your pick is low go higher");

                else if (guess > random_number)
                    Console.WriteLine("Your pick is high go lower");


            }


              Console.ReadLine();
        }
    }
}
