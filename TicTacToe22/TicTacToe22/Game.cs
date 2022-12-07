﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public class Game
    {
        public InputService InputService { get; set; }

        public MovementService MovementService { get; set; }
        public ApplyRulesService ApplyRulesService { get; set; }
        public Display Display { get; set; }


        public Game(InputService inputService, MovementService movementService, ApplyRulesService applyRulesService, Display display)
        {
            MovementService = movementService;
            InputService = inputService;
            ApplyRulesService = applyRulesService;
            Display = display;
        }

        public string SwitchPlayer(string playerName) => playerName.ToUpper().Equals("X") ? "O" : "X";


        public void PlayMe(string[][] board)
        {
            var win = false;
            var isBoardFull = false;
            var player = this.InputService.CollectDetails("X");
            var winner = player;

            while (!(win|| isBoardFull))
            {                
                var TupplePlayerAndBoard = this.MovementService.FillBoard(player, board);
                this.Display.DisplayBoard(board);

                win = this.ApplyRulesService.HasWon(player: TupplePlayerAndBoard.Item2, board: TupplePlayerAndBoard.Item1);
                if (win)
                {
                    winner = player;
                }

                isBoardFull = this.ApplyRulesService.IsBoardFilled(board);
                
                player = this.InputService.CollectDetails(SwitchPlayer(player.Name));
            }

            if (win)
            {
                Console.WriteLine($"Winner is {player.Name} ");
                Display.DisplayBoard(board);
            }

            if(!win && isBoardFull)
            {
                Console.WriteLine(" Seems nobody won - goodluck next time");
            }

        }

    }
}
