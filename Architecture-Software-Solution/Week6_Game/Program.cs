using System;
using Week6_Game.TemplateMethod_Pattern;

namespace Week6_Game
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Card snatch game ; the players "play" alone
            Player playerLeon = new Player("Leon");
            Player playerHelena = new Player("Helena");
            CardGame snatchGame = new CardSnatchGame();
            snatchGame.Play(playerLeon, playerHelena);

            //Guessing game
            Player gamer = new Player("Me");
            Player computer = new Player("Computer"); //este no se usará porque es un juego solitario
            CardGame guessing = new GuessingGame();
            guessing.Play(gamer, computer);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}