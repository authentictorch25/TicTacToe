using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tictactoe game");
            char[] board = TicTacToeGame.CreateBoard();
            char userLetter = TicTacToeGame.ChooseUserLetter();
            TicTacToeGame.DisplayBoard(board);
            int userMove = TicTacToeGame.UserMove(board);
            TicTacToeGame.MakeMove(board, userMove, userLetter);
        }
    }
}
