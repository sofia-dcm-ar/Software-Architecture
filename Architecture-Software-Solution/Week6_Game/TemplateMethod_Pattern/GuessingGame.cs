using System;
using System.Collections.Generic;


namespace Week6_Game.TemplateMethod_Pattern
{
    /* 
     This game allows a user to play multiple rounds against the computer using the keyboard.
     (I definitely didn't just make this up... :P)
     
        Game Rules:
        - There is a deck with cards numbered 1 to 4.
        - One card from the deck is placed face down on the table.
        - The player must enter the number they believe the card is:
            - If the guess is correct: +1 point.
            - If the guess is incorrect: 0 points.
        - The card is then removed from the table (discarded).

        Winner: 
         - None. The player decides when to quit by entering 0, which signifies their last turn.
         - The final score is displayed, and the game ends.
         - If 0 is not entered, a new round begins.
     */

    public class GuessingGame : CardGame
    {
        protected override void DealCards(Player player1, Player player2) { } //In this game cards aren't dealed

        protected override bool Winner(Player player1, Player player2)
        { 
            if (player1.GetHasFinished())
                Console.WriteLine(player1.ToString());
            return player1.GetHasFinished();
        }

        protected override void DrawCards(Player player1, Player player2)
        {
            int card = _generate.RandomNumber(5);
            Console.WriteLine("settle down a card");
            Console.WriteLine("\nWhat number is?");
            int adivino = int.Parse(Console.ReadLine());
            if (card == adivino)
            {
                player1.SetScore(); //+1 Point
                Console.WriteLine("You Guessed! --> +1 Point");
            }
            else
                Console.WriteLine("no, the number was {0}", card);
            if (adivino == 0)
                player1.DontPlayAnymore();

        }

        protected override void DiscardCards()
        {
            Console.WriteLine("removing the card from the table");
        }
    }
}
