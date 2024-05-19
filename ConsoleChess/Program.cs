

using ConsoleChess;
using ConsoleChess.Board;
using ConsoleChess.Board.Enums;
using ConsoleChess.Chess;
using ConsoleChess.Chess.Parts;
;

try
{

   ChessMatch match = new ChessMatch();

    while (!match.Finished)
    {
        Console.Clear();
        Screen.PrintBoard(match.Board);

        Console.WriteLine();
        Console.Write("Origem: ");
        Position origem = Screen.readeChessPosition().toPosition();
        Console.Write("Destino: ");
        Position destino = Screen.readeChessPosition().toPosition();

        match.Moviment(origem, destino);


    }

}
catch(ChessBoardExeption e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();

