using System;
using System.Net.NetworkInformation;
using System.Text;

namespace Week7.ChainOfResponsability_Pattern
{
    //(Week 3) Exercise 2: Implement a class for generating random data
    //(Week 7) Implemment the singletone pattern
    //(week 7) CHAIN OF RESPONSABILITY -> Make the random data generator handler 
    public class RandomDataGenerator : BaseHandler
    {
        private readonly Random _r;
        private static RandomDataGenerator _instance = null;

        public RandomDataGenerator(BaseHandler handler) : base(handler) 
        {
            _r = new Random();
        }

        public override int RandomNumber(int max = 10)
        {
            return _r.Next(max);
        }

        public override string RandomString(int cant = 6)
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

        public static RandomDataGenerator GetInstance(BaseHandler handler)
        {
            if (_instance==null)
                _instance = new RandomDataGenerator(handler);
            return _instance;
        }
    }
}
