using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class FieldTaken : Exception
    {
        public FieldTaken()
        {

        }
        public FieldTaken(string message) : base(message)
        {

        }
        public FieldTaken(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
