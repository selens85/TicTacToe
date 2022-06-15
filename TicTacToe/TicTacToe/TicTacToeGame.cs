using System.Collections.ObjectModel;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public const Players player1 = Players.Player1;
        public const Players player2 = Players.Player2;

        public char playerX = (char)player1;
        public char playerO = (char)player2;

        PlayerHuman PlayerOneName = new PlayerHuman();
        PlayerHuman PlayerTwoName = new PlayerHuman();

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
                    if (PlayerOneName.Age > PlayerTwoName.Age)
                    {
                        Console.WriteLine($"Player {PlayerOneName.Name} ({playerX}) is a winner!");
                        PlayerOneName.Haleluja();
                    }
                    else
                    {
                        Console.WriteLine($"Player {PlayerOneName.Name} ({playerX}) is a winner!");
                    }
                    
                    break;
                }
                else if (result == 'O')
                {
                    if (PlayerOneName.Age < PlayerTwoName.Age)
                    {
                        Console.WriteLine($"Player {PlayerTwoName.Name} ({playerO}) is a winner!");
                        PlayerTwoName.Haleluja();
                    }
                    else
                    {
                        Console.WriteLine($"Player {PlayerTwoName.Name} ({playerO}) is a winner!");
                    }
                    break;
                }
                else if (result == 'D' && i == 9)
                {
                    Console.WriteLine("Its a draw!");
                }
            }
        }

        public bool InputChoice(int i, int choice = 0)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"Player {PlayerOneName.Name} ({playerX}) goes: ");
            }
            else
            {
                Console.WriteLine($"Player {PlayerTwoName.Name} ({playerO}) goes: ");
            }

           
            choice = int.Parse(Console.ReadLine());
            

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

        public void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {BoardValues[0]}  |  {BoardValues[1]}  |  {BoardValues[2]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {BoardValues[3]}  |  {BoardValues[4]}  |  {BoardValues[5]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {BoardValues[6]}  |  {BoardValues[7]}  |  {BoardValues[8]}");
            Console.WriteLine("     |     |      ");

        }
    }
}
