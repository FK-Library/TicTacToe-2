using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public class Player
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Player(int x, int y, string name)
        {
            X = x; Y = y; Name = name;
        }
    }
}
