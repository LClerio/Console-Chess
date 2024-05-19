using ConsoleChess.Board;
using ConsoleChess.Board.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.Chess.Parts
{
    internal class Knights : Part
    {
        public Knights(ChessBoard board, PartColor color) : base(board, color) { }
        public override string ToString()
        {
            return "C";
        }
    }
}
