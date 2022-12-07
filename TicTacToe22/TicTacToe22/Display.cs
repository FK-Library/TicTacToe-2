using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public class Display
    {
        public string[][] Board { get; set; }

        public Display(string[][] board)
        {
            Board = board;
        }

        /**
         * this function displays the board, we can add more shape of demonstrating the boar without changing this or any other function
         */
        public void DisplayBoard(string[][] board)
        {
            var formatted = "";
            Console.WriteLine("\n");

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    formatted = board[i][j].Equals("Z") ? " " : board[i][j];
                    Console.Write($@" - | {formatted} | - ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
