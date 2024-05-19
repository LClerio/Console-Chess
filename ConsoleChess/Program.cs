

using ConsoleChess;
using ConsoleChess.Board;
using ConsoleChess.Board.Enums;
using ConsoleChess.Chess.Parts;
;

try
{
    ChessBoard board = new ChessBoard(8, 8);

    board.PlacePart(new Rooks(board, PartColor.Black), new Position(0, 0));
    board.PlacePart(new King(board, PartColor.Black), new Position(1, 3));
    board.PlacePart(new bishops(board, PartColor.Black), new Position(2, 4));

    board.PlacePart(new Pawns(board, PartColor.White), new Position(3, 5));

    Screen.PrintBoard(board);
}
catch(ChessBoardExeption e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();

