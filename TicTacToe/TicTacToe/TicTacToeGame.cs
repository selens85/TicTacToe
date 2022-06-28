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
        PrintDrawBoard PrintDrawBoard = new PrintDrawBoard();
        CheckWinner CheckWinner = new CheckWinner();
        PrintRules PrintRules = new PrintRules();

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
            PrintRules.Rules(PlayerOneName, PlayerTwoName, playerX, playerO);
            PrintDrawBoard.DrawBoard(BoardValues);

            for (var i = 1; i <= 9; i++)
            {
                bool inputIsValid = false;
                while (!inputIsValid)
                {
                    inputIsValid = InputChoice(i);
                }

                PrintDrawBoard.DrawBoard(BoardValues);

                var result = CheckWinner.Winner(BoardValues);



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

            try
            {
                choice = int.Parse(Console.ReadLine());

                Validate(choice);

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter number");
                return false;
            }
            catch (BiggerthanNine biggerthanNine)
            {
                Console.WriteLine($"{biggerthanNine.Message}");
                return false;
            }
            catch (FieldTaken fieldtaken)
            {
                Console.WriteLine($"{fieldtaken.Message}");
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Global error {e.Message}");
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
        
        public void Validate(int choice)
        {
            if (choice < 1 || choice > 9)
            {
                throw new BiggerthanNine("Number should be between 1 and 9, try again");
            }
            if (BoardValues[choice - 1] == 'X' || BoardValues[choice - 1] == 'O')
            {
                throw new FieldTaken("Field is taken try again");
                
            }

        }


       
    }
}
