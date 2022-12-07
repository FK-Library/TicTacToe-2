using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public class MovementService
    {
        //public Player Player { get; set; }

        //public string[][] Board { get; set; }

        //public MovementService(Player player,  string[][]  board)
        //{
        //    Player=player;  Board = board;
        //}

        public bool ValidatePlayerMovement(Player player, string[][] board)
        {
            if(player.X<0 || player.X>3 || player.Y < 0 || player.Y > 3 )
            {
                throw new Exception("invalid moves - out of boundry");
            }

            
            if (!board[player.X][player.Y].Equals("Z") )
            {
                throw new Exception("invalid move - already filled");
            }


            return true;
        }

        public Tuple<string[][],Player> FillBoard (Player player, string[][] board)
        {
            //validate choices
           var valid =  this.ValidatePlayerMovement(player, board);
            if (valid)
            {
                //fill the board
                board[player.X][player.Y] = player.Name;

            }

            return new Tuple<string[][], Player>(board, player);

        }

    }
}
