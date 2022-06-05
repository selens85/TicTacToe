//1.Provide instructions
//1.1.A greeting
//1.2.Display player sign, Player 1 is X and Player 2 is O
//1.3.	 Who’s turn is it?
//1.4.	 Instruc the user to enter a number between 1 and 9
//2.	Draw the game board
//2.1.	 Game will have 3 rows and 3 columns will be numbered 1 through 9
//3.	As the user places markers on the game update the board then notify which player has a turn
//3.1.	 After each turn judge if there is a winner
//3.2.	 If no winner keep playing by going to step 1.
//3.3.	 If all markers are placed and no winner then it’s a draw stop the game
//3.4.	 If we have a winner announce who won and stop the game
using System;
using System.Threading;




namespace TicTacToe
{
    public static class Program
    {
        public static char[] boardValues = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static void Main(string[] args)
        {
            int choice = 0;

            Console.WriteLine("This is Tic Tac Toe game.");
            Console.WriteLine("If you don't know the rules you play Desas");
            Console.WriteLine("Player one choses char X");
            Console.WriteLine("Player two choses char O");
            Console.WriteLine("Player needs to enter number from 1 to 9 according to Board layout");
            Console.WriteLine("\n");
            Console.WriteLine("To begin the game press any key");
            Console.ReadKey();

            Console.Clear();
            DrawBoard();
            Console.WriteLine("\n");

            for (var i = 1; i <= 9; i++)
            {
                var counter = i;
                if (counter % 2 != 0)
                {
                    Console.WriteLine("Player one goes: ");
                    choice = int.Parse(Console.ReadLine());
                    boardValues[choice - 1] = 'X';
                }
                else
                {
                    Console.WriteLine("Player two goes: ");
                    choice = int.Parse(Console.ReadLine());
                    boardValues[choice - 1] = 'O';
                }
                Console.Clear();
                DrawBoard();
                Console.WriteLine("\n");
            }
            Console.ReadLine(); 

        }



            public  static void DrawBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardValues[0], boardValues[1], boardValues[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardValues[3], boardValues[4], boardValues[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardValues[6], boardValues[7], boardValues[8]);
            Console.WriteLine("     |     |      ");

        }

    }
}




