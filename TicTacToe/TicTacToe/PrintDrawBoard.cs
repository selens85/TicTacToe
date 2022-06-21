using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PrintDrawBoard
    {
        public void DrawBoard(char[] boardValues)
        {
            Console.Clear();
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {boardValues[0]}  |  {boardValues[1]}  |  {boardValues[2]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {boardValues[3]}  |  {boardValues[4]}  |  {boardValues[5]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {boardValues[6]}  |  {boardValues[7]}  |  {boardValues[8]}");
            Console.WriteLine("     |     |      ");

        }

    }
}
