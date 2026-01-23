using System;
using System.Numerics;

namespace Week6_Game
{
    public class Player
    {
        //A player for the games

        private string _userName;
        private int _score;
        private bool _hasFinished;
        private int[] _cards;

        public Player(string userName)
        {
            _userName = userName;
            _score = 0;
            _hasFinished = false;
            _cards = new int[4];
        }

        public string GetUserName()
        {
            return _userName;
        }

        public int GetScore()
        {
            return _score;
        }

        public void SetScore()
        {
            _score++;
        }

        public bool GetHasFinished()
        {
            return _hasFinished;
        }

        public void DontPlayAnymore()
        {
            _hasFinished = true;
        }

        public void ReceiveCard(int card, int index)
        {
            _cards[index]=card;
        }

        public bool HasCard(int search)
        {
            int i = 0;
            foreach (int card in _cards)
            {
                if (search == card)
                {
                    _cards[i]=0; //saco la card del juego porque se que nunca va a haber una card 0
                    return true;
                }
                i++;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("Player: {0}\nScore: {1}", _userName, _score);
        }

        public bool HasSameScore(Player player)
        {
            return (_score==(player)._score);
        }

        public bool HasLowerScoreThan(Player player)
        {
            return (_score<(player)._score);
        }

        public bool HasHigherScoreThan(Player player)
        {
            return (_score>(player)._score);
        }
    }
}
