using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PrintRules
    {
        public void Rules(PlayersNames PlayerOneName, PlayersNames PlayerTwoName, char playerX, char playerO)
        {

            Console.WriteLine("This is Tic Tac Toe game.");
            Console.WriteLine("If you don't know the rules you play Desas");
            Console.WriteLine("What's the name of player one:");
            PlayerOneName.Name = Console.ReadLine();
            Console.WriteLine("what's the age of player one:");
            PlayerOneName.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("What's the name of player two:");
            PlayerTwoName.Name = Console.ReadLine();
            Console.WriteLine("what's the age of player two:");
            PlayerTwoName.Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Player {PlayerOneName.Name} choses char {playerX}");
            Console.WriteLine($"Player {PlayerTwoName.Name} choses char {playerO}");
            Console.WriteLine("Player needs to enter number from 1 to 9 according to the Board layout");
            Console.Write("\n");
            Console.WriteLine("To begin the game press any key");
            Console.ReadKey();
        }
    }
}
