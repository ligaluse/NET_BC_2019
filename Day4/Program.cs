using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartNewGame();
            game.Loop();
            Console.Read();
        }
    }
}
//interface IPlayer
//int GuessNumber()
//abstract class BasePlayer : IPlayer
//string Name (visiem speletajiem jabut vardam un jarealizee fja, kaa sho vardu dabut)
// int CurrentGuess (jasaglabaa shi briizha minejums)
//bool IsNumberGuessed(int number) (shii metode nav abstrakta)
//abstract string GetName() (atseviski katram speletajam)
//class User : BasePlayer (te bus realizeta GetName un GuessNumber)
//class Robot : BasePlayer (te bus realizeta GetName un GuessNumber)
//class Game (visa speles logjika ir sheit)
//-int CurrentNumber; //current number player guesses
//Iplayer PlayerOne (iipashiiba)
//Iplayer PlayerTwo - (iipashiiba)
// fja uzsakt jaunu speli void StartNewGame() //generates new random number
//void Loop() //main game logic
//void PlayerTurn(Iplayer player)