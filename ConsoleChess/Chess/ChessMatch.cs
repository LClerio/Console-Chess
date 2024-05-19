using ConsoleChess.Board;
using ConsoleChess.Board.Enums;
using ConsoleChess.Chess.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.Chess
{
    internal class ChessMatch
    {
        public ChessBoard Board { get;  private set; }
        private PartColor PlayersTurn;
        private int turn;
        public bool Finished { get; private set; }

        public ChessMatch()
        {
            Board = new ChessBoard(8, 8);
            PlayersTurn = PartColor.White;
            turn = 1;
            Finished = false;
            placePart();
        }

        //Movimentação das peças
        public void Moviment(Position initial, Position final)
        {
            Part p = Board.RemovePart(initial); // remover a peça de origem
            p.increaseMoviment(); // acrencentar +1 no movimentp
            Board.RemovePart(final); // remover peça na destino se ouver uma
            Part part = Board.RemovePart(final); // capturar peça derrubada no desdino
            Board.AddPart(p, final); // levar a peça da origem para o destino
        }

        private void placePart()
        {
            Board.AddPart(new Rooks(Board, PartColor.White), new ChessPosition('c', 1).toPosition());

        }
    }
}
