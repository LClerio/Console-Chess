using ConsoleChess.Board.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.Board
{
    internal class Part
    {
        public Position Position { get; set; }
        public ChessBoard Board { get; protected set; }
        public PartColor Color { get; protected set; }
        public int AmountMoviment { get; protected set; }

        public Part(Position position, ChessBoard board, PartColor color)
        {
            Position = position;
            Board = board;
            Color = color;
        }
    }
}
