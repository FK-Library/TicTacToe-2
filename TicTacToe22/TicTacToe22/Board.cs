using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public class Board
    {
        public string[][] TTTBoard { get; set; }

    }

    public static class BoardFactory
    {
        public static string[][] CreateBoard()=> new string[][] { new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" } };
        //{
        //    var x = new Board();
        //    x.TTTBoard = new string[][] { new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" } };
        //    return x.TTTBoard;
        //}

    }
}
