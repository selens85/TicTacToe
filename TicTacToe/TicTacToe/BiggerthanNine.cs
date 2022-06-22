using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class BiggerthanNine : Exception
    {
        public BiggerthanNine()
        {

        }
        public BiggerthanNine(string message) : base(message)
        {

        }
        public BiggerthanNine(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
