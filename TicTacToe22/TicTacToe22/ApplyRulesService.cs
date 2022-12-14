using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public class ApplyRulesService
    {

        //This is handling 3X3 - need to be optimised to take any dimentions
        //Also its comparing with player name, rule should be independent
        public bool HasWon(Player player, string[][] board)
        {
            if (board[0][0].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[0][1].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[0][2].ToString().ToUpper().Equals(player.Name.ToUpper())) return true;
            if (board[1][0].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[1][1].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[1][2].ToString().ToUpper().Equals(player.Name.ToUpper())) return true;
            if (board[2][0].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[2][1].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[2][2].ToString().ToUpper().Equals(player.Name.ToUpper())) return true;

            if (board[0][0].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[1][0].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[2][0].ToString().ToUpper().Equals(player.Name.ToUpper())) return true;
            if (board[0][1].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[1][1].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[2][1].ToString().ToUpper().Equals(player.Name.ToUpper())) return true;
            if (board[2][0].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[2][1].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[2][2].ToString().ToUpper().Equals(player.Name.ToUpper())) return true;

            if (board[0][0].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[1][1].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[2][2].ToString().ToUpper().Equals(player.Name.ToUpper())) return true;
            if (board[0][2].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[1][1].ToString().ToUpper().Equals(player.Name.ToUpper()) && board[2][0].ToString().ToUpper().Equals(player.Name.ToUpper())) return true;

            return false;
        }

        /**
         * if there is only one z then there is a space and no need checking the whole board
         */
        public bool IsBoardFilled(string[][] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j].ToString().Equals("Z"))
                        return false;
                }
            }
            return true;
        }

    }
}
