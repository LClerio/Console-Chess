using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.Board
{
    internal class ChessBoardExeption : Exception
    {
        public ChessBoardExeption(string msg) : base (msg) { }
    }
}
