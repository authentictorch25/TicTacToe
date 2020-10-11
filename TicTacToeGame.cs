using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum Player { USER, COMPUTER };

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
        public static void DisplayBoard(char[] board)
        {
            Console.WriteLine("\n" + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("\n" + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("\n" + board[7] + " | " + board[8] + " | " + board[9]);
        }
        public static int UserMove(char[] board)
        {
            int[] availableCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("Enter the next move (1-9)!");
                int cell = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(availableCells, element => element == cell) != 0 && IsSpaceFree(board, cell))
                    return cell;
            }
        }

        public static bool IsSpaceFree(char[] board, int cell)
        {
            return board[cell] == ' ';
        }
        public static void MakeMove(char[] board, int cell, char letter)
        {
            Boolean spaceFree = IsSpaceFree(board, cell);
            if (spaceFree)
                board[cell] = letter; 
        }

        public static Player GetWhoStartsFirst()
        {
            int toss = getOneFromRandomChoices(2);
            return (toss == HEAD) ? Player.USER : Player.COMPUTER;
        }
         public static int getOneFromRandomChoices(int choices)
        {
            Random random = new Random();
            return (int)(random.Next() * 10) % choices; 
        }

        public static bool IsWinner(char[] b, char ch)
        {
            return ((b[1] == ch && b[2] == ch && b[3] == ch) ||
                (b[1] == ch && b[5] == ch && b[9] == ch) ||
                (b[4] == ch && b[5] == ch && b[6] == ch) ||
                (b[7] == ch && b[8] == ch && b[9] == ch) ||
                (b[1] == ch && b[4] == ch && b[7] == ch) ||
                (b[3] == ch && b[6] == ch && b[9] == ch) ||
                (b[2] == ch && b[5] == ch && b[8] == ch) ||
                (b[3] == ch && b[5] == ch && b[7] == ch));
        }


    }
}
