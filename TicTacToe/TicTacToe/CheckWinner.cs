using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class CheckWinner
    {
        public char Winner(char[] boardValues)
        {
            if (boardValues[0] == 'X' && boardValues[1] == 'X' && boardValues[2] == 'X' ||
                boardValues[3] == 'X' && boardValues[4] == 'X' && boardValues[5] == 'X' ||
                boardValues[6] == 'X' && boardValues[7] == 'X' && boardValues[8] == 'X' ||
                boardValues[0] == 'X' && boardValues[3] == 'X' && boardValues[6] == 'X' ||
                boardValues[1] == 'X' && boardValues[4] == 'X' && boardValues[7] == 'X' ||
                boardValues[2] == 'X' && boardValues[5] == 'X' && boardValues[8] == 'X' ||
                boardValues[0] == 'X' && boardValues[4] == 'X' && boardValues[8] == 'X' ||
                boardValues[2] == 'X' && boardValues[4] == 'X' && boardValues[6] == 'X')
            {
                return 'X';
            }
            else if (boardValues[0] == 'O' && boardValues[1] == 'O' && boardValues[2] == 'O' ||
                boardValues[3] == 'O' && boardValues[4] == 'O' && boardValues[5] == 'O' ||
                boardValues[6] == 'O' && boardValues[7] == 'O' && boardValues[8] == 'O' ||
                boardValues[0] == 'O' && boardValues[3] == 'O' && boardValues[6] == 'O' ||
                boardValues[1] == 'O' && boardValues[4] == 'O' && boardValues[7] == 'O' ||
                boardValues[2] == 'O' && boardValues[5] == 'O' && boardValues[8] == 'O' ||
                boardValues[0] == 'O' && boardValues[4] == 'O' && boardValues[8] == 'O' ||
                boardValues[2] == 'O' && boardValues[4] == 'O' && boardValues[6] == 'O')
            {
                return 'O';
            }
            else
            {
                return 'D';
            }
        }

    }
}
