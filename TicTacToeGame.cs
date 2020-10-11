using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public static char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            { 
                board[i] = ' '; 
            }
            return board;
        }
        public static char ChooseUserLetter()
        {
            Console.WriteLine("Choose User Letter X or O : ");
            string userLetter = Console.ReadLine();
            return char.ToUpper(userLetter[0]);
        }
    }
}
