using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicTacToe22
{
    public  class InputService
    {
        public InputResult CollectDetails()
        {
            
            var player1 = this.CollectPlayerDetails();
            player1.Name = "X";
            
            var player2 = this.CollectPlayerDetails();
            player2.Name = "O";
            return new InputResult()
            {
                Players = new List<Player> { player1, player2 }
            };
        }

        public bool ValidateChoice(string input)
        {
            string pattern = @"^[0-9] [0-9] [X|O]$";
            return Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase); //TODO:check playaer 1 enters x not o
        }

        public Player CollectPlayerDetails()
        {
            
            string[][] choices = { new string []{"Z","Z","Z" }, new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" } };
            var x = 0;
            var y = 0;
            var validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Please enter player move e.g '0 0 X' ");
                var input = Console.ReadLine();
                validInput = ValidateChoice(input);
                if (!validInput)
                {
                    Console.WriteLine("Invalid please try again");
                }

                var inputArray = input.Split(' ').ToArray();
                x= int.Parse(inputArray[0]);
                y = int.Parse(inputArray[1]);
                choices[x][y] = inputArray[1].ToString();

            }

            return new Player(x, y, choices);
        }

    }
}
