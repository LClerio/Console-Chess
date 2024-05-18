using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.Board
{
    internal class ChessBoard
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Part[,] Parts;

        public ChessBoard(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Parts = new Part[Lines, Columns];
        }

        public Part Part(int lines, int columns)
        {
            return Parts[lines, columns];
        }

    }
}
