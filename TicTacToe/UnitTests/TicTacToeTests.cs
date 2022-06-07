using Xunit;
using TicTacToe;

namespace UnitTests
{
    public class TicTacToeTests
    {
        [Fact]
        public void CheckWinnerX()
        {
            char[] boardValues = { 'X', 'X', 'X', '4', '5', '6', '7', '8', '9' };
            var ticTacToe = new TicTacToeGame(boardValues);

            var result = ticTacToe.CheckWinner();

            Assert.Equal('X', result);
        }

        [Fact]
        public void CheckWinnerO()
        {
            char[] boardValues = { '1', '2', '3', 'O', 'O', 'O', '7', '8', '9' };
            var ticTacToe = new TicTacToeGame(boardValues);

            var result = ticTacToe.CheckWinner();

            Assert.Equal('O', result);
        }        

        [Fact]
        public void InputChoice()
        {
            char[] boardValues = { 'X', 'X', '3', '4', '5', '6', '7', '8', '9' };
            var ticTacToe = new TicTacToeGame(boardValues);

            ticTacToe.InputChoice(3, 3);
            Assert.Equal(new char[] { 'X', 'X', 'X', '4', '5', '6', '7', '8', '9' }, ticTacToe.BoardValues);
        }       
    }
}