using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    /**
     * This factory creates a clean board
     */
    public static class BoardFactory
    {
        public static string[][] CreateBoard() =>
            new string[][] { new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" } };
    }
}
