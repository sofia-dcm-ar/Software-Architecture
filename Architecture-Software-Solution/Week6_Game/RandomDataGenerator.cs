using System;
using System.Text; 

namespace Week6_Game
{ 
    //(Week 3) Exercise 2: Implement a class for generating random data
    public class RandomDataGenerator
    {
        private readonly Random _r;
        public RandomDataGenerator()
        {
            _r = new Random();
        }

        public int RandomNumber(int max = 13)
        {
            return this._r.Next(1,max);
        }

        public string RandomString(int cant = 6)
        { 
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder token = new StringBuilder();
            token.Append(char.ToUpper(alphabet[_r.Next(alphabet.Length)]));//First letter uppercase
            for (int i = 1; i < cant; i++)
            {
                token.Append(alphabet[_r.Next(alphabet.Length)]);
            }
            return token.ToString();
        }
    }
}
