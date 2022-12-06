using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public class Dislay
    {
        public string[][] Board { get; set; }

        public Dislay(string[][] board)
        {
            Board = board;
        }

        public void DisplayBoard(string[][] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    Console.WriteLine( $"{ board[i][j]} ");
                }
                Console.WriteLine("\n");

            }
        }
    }
}
