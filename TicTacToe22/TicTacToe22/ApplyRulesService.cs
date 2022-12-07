using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public  class ApplyRulesService
    {
        //public Player Player { get; set; }

        //public string[][] Board { get; set; }

        //public ApplyRulesService(Player player, string[][] board)
        //{
        //    Player = player; Board = board;

        //}

        //This is handling 3X3 - need to be optimised to take any dimentions
        public bool HasWon(Player player, string[][] board)
        {
            if (board[0][0].Equals(player.Name) && board[0][1].Equals(player.Name) && board[0][2].Equals(player.Name)) return true;
            if (board[1][0].Equals(player.Name) && board[1][1].Equals(player.Name) && board[1][2].Equals(player.Name)) return true;
            if (board[2][0].Equals(player.Name) && board[2][1].Equals(player.Name) && board[2][2].Equals(player.Name)) return true;

            if (board[0][0].Equals(player.Name) && board[1][0].Equals(player.Name) && board[2][0].Equals(player.Name)) return true;
            if (board[0][1].Equals(player.Name) && board[1][1].Equals(player.Name) && board[2][1].Equals(player.Name)) return true;
            if (board[2][0].Equals(player.Name) && board[2][1].Equals(player.Name) && board[2][2].Equals(player.Name)) return true;

            if (board[0][0].Equals(player.Name) && board[1][1].Equals(player.Name) && board[2][2].Equals(player.Name)) return true;

            return false;
        }

        public bool IsBoardFilled(string[][] board)
        {
  
            var count = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {

                    //count = board[i][j].Equals("Z") ? count+1 : count;

                    if (board[i][j].Equals("Z"))
                    {
                        count = +1;

                    }

                    
                }
            }
            var isFull = count > 0 ? false : true;

            return isFull;
        }

    }
}
