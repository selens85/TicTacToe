using System.Collections.ObjectModel;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public char[] BoardValues = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
       
        public TicTacToeGame()
        {
        }

        public TicTacToeGame(char[] boardValues)
        {
            BoardValues = boardValues;
        }

        public void StartGame()
        {
            PrintRules();
            DrawBoard();

            for (var i = 1; i <= 9; i++)
            {
                while (!InputChoice(i))
                {
                    Console.WriteLine("Wrong choice, try again");
                }

                DrawBoard();

                var result = CheckWinner();

                if (result == 'X')
                {
                    Console.WriteLine("Player One is a winner!");
                }
                else if (result == 'O')
                {
                    Console.WriteLine("Player Two is a winner!");
                }
                else if (result == 'D')
                {
                    Console.WriteLine("Its a draw!");
                }
            }
        }

        public bool InputChoice(int i, int choice = 0)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("Player one goes: ");
            }
            else
            {
                Console.WriteLine("Player two goes: ");
            }

            if (choice == 0)
            {
                choice = int.Parse(Console.ReadLine());
            }

            if (BoardValues[choice - 1] == 'X' || BoardValues[choice - 1] == 'O')
            {
                return false;
            }

            if (i % 2 != 0)
            {
                BoardValues[choice - 1] = 'X';
            }
            else
            {
                BoardValues[choice - 1] = 'O';
            }

            return true;
        }

        public char CheckWinner()
        {
            if (BoardValues[0] == 'X' && BoardValues[1] == 'X' && BoardValues[2] == 'X' ||
                BoardValues[3] == 'X' && BoardValues[4] == 'X' && BoardValues[5] == 'X' ||
                BoardValues[6] == 'X' && BoardValues[7] == 'X' && BoardValues[8] == 'X' ||
                BoardValues[0] == 'X' && BoardValues[3] == 'X' && BoardValues[6] == 'X' ||
                BoardValues[1] == 'X' && BoardValues[4] == 'X' && BoardValues[7] == 'X' ||
                BoardValues[2] == 'X' && BoardValues[5] == 'X' && BoardValues[8] == 'X' ||
                BoardValues[0] == 'X' && BoardValues[4] == 'X' && BoardValues[8] == 'X' ||
                BoardValues[2] == 'X' && BoardValues[4] == 'X' && BoardValues[6] == 'X')
            {
                return 'X';
            }
            else if (BoardValues[0] == 'O' && BoardValues[1] == 'O' && BoardValues[2] == 'O' ||
                BoardValues[3] == 'O' && BoardValues[4] == 'O' && BoardValues[5] == 'O' ||
                BoardValues[6] == 'O' && BoardValues[7] == 'O' && BoardValues[8] == 'O' ||
                BoardValues[0] == 'O' && BoardValues[3] == 'O' && BoardValues[6] == 'O' ||
                BoardValues[1] == 'O' && BoardValues[4] == 'O' && BoardValues[7] == 'O' ||
                BoardValues[2] == 'O' && BoardValues[5] == 'O' && BoardValues[8] == 'O' ||
                BoardValues[0] == 'O' && BoardValues[4] == 'O' && BoardValues[8] == 'O' ||
                BoardValues[2] == 'O' && BoardValues[4] == 'O' && BoardValues[6] == 'O')
            {
                return 'O';
            }
            else
            {
                return 'D';
            }
        }

        public void PrintRules()
        {
            Console.WriteLine("This is Tic Tac Toe game.");
            Console.WriteLine("If you don't know the rules you play Desas");
            Console.WriteLine("Player one choses char X");
            Console.WriteLine("Player two choses char O");
            Console.WriteLine("Player needs to enter number from 1 to 9 according to the Board layout");
            Console.Write("\n");
            Console.WriteLine("To begin the game press any key");
            Console.ReadKey();
        }

        public void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", BoardValues[0], BoardValues[1], BoardValues[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", BoardValues[3], BoardValues[4], BoardValues[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", BoardValues[6], BoardValues[7], BoardValues[8]);
            Console.WriteLine("     |     |      ");

        }
    }
}
