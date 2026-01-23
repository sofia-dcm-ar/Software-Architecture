using System;
using System.Collections.Generic;


namespace Week6_Game.TemplateMethod_Pattern
{
    public abstract class CardGame
    {
        protected List<int> _deck = new List<int>();
        protected RandomDataGenerator _generate = new RandomDataGenerator();

        public void Play(Player player1, Player player2)
        {
            Shuffle();
            DealCards(player1, player2);
            while (!Winner(player1, player2))
            {
                DrawCards(player1, player2);
                DiscardCards();
            }
            Console.WriteLine("\nThanks for play!\n");
        }

        protected void Shuffle()
        {
            Console.WriteLine("shuffling cards");
            Console.WriteLine("cutting the deck");
            Console.WriteLine("shuffling cards");
        }

        protected abstract void DealCards(Player player1, Player player2);
        protected abstract bool Winner(Player player1, Player player2);
        protected abstract void DrawCards(Player player1, Player player2);
        protected abstract void DiscardCards();
    }
}
