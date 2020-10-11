using System;

namespace TicTacToe
{
    class Program
    {

        static void Main(string[] args)
        {
            char[] board = TicTacToeGame.CreateBoard();
            TicTacToeGame.DisplayBoard(board);
            char userLetter = TicTacToeGame.ChooseUserLetter();         
            int userMove = TicTacToeGame.UserMove(board);
            TicTacToeGame.Player player = TicTacToeGame.GetWhoStartsFirst();
            
        }
    }
}
