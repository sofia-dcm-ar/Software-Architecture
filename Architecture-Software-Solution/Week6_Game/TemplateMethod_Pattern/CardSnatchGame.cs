using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Game.TemplateMethod_Pattern
{
    /* 
     This game is a variation of "Steal the Pile" (Casita Robada).
     
    Gameplay:
     - Each player starts with 4 cards.
     - There is a central deck of 8 cards.
     - A card is drawn from the deck and placed on the table:
         - If the player has a matching card: +1 point, and the matching card is discarded.
         - If the player does not have the card: no points awarded.
     The game ends when:
         - The deck is empty.
         - A player reaches 4 points.
     Winner: The player with the highest score, or a tie if scores are equal.
     */

    public class CardSnatchGame : CardGame
    {
        protected override void DealCards(Player player1, Player player2)
        {
            //set the deck
            for (int i = 0; i<8; i++)
            {
                base._deck.Add(_generate.RandomNumber());//add a card between 1 and 12
            }
            //DealCards cards to players
            Console.WriteLine("Dealing cards to the players\n");
            for (int i = 0; i<4; i++)
            {
                player1.ReceiveCard(_generate.RandomNumber(), i);
            }
            for (int i = 0; i<4; i++)
            {
                player2.ReceiveCard(_generate.RandomNumber(), i);
            }
        }

        protected override bool Winner(Player player1, Player player2)
        {
            if ((base._deck.Count == 0)||(player1.GetScore()==4)||(player2.GetScore()==4))
            { //the deck finished or a player reach 4 points

                if (base._deck.Count == 0)
                    Console.WriteLine("No more cards in the deck, finish game\n");

                if ((player1.GetScore()==4)||(player2.GetScore()==4))
                    Console.WriteLine("A player reached 4 points");

                if (player1.HasSameScore(player2))
                {
                    Console.WriteLine("Tie between players, Score: {0}", player1.GetScore());
                    return true;
                }

                if (player1.HasHigherScoreThan(player2))
                {
                    Console.WriteLine("Winner:\n{0}", player1.ToString());
                    return true;
                }

                else
                {
                    Console.WriteLine("Winner:\n{0}", player2.ToString());
                    return true;
                }
            }
            return false;
        }

        protected override void DrawCards(Player player1, Player player2)
        {
            int card = base._deck[0]; //take the next card
            Console.WriteLine("Placing card on the table: {0}", card);

            bool player1HasIt = player1.HasCard(card);
            if (player1HasIt)
            {
                Console.WriteLine("Player {0} match the card {1} --> +1 Point", player1.GetUserName(), card);
                player1.SetScore();
            }

            bool player2HasIt = player2.HasCard(card);
            if (player2HasIt)
            {
                Console.WriteLine("Player {0} match the card {1} --> +1 Point", player2.GetUserName(), card);
                player2.SetScore();
            }

            if (!player1HasIt && !player2HasIt)
                Console.WriteLine("No one match the card");
        }

        protected override void DiscardCards()
        {
            Console.WriteLine("Discarding used card\n");
            base._deck.RemoveAt(0); 
        }
    }
}
