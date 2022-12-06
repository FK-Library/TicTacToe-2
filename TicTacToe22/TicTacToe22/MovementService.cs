using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public class MovementService
    {
        public Player PlayerX { get; set; }
        public Player PlayerY { get; set; }

        public MovementService(Player x, Player y)
        {
            PlayerX=x; PlayerY=y;
        }

        //public Tuple<Player,Player> Move 


    }
}
