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
    public class InputService
    {
        public Player CollectDetails(string label) => this.CollectPlayerDetails(label);

        /**
         *  even if user enters o instead of X , game is picking up the correct letter
         *  but it should only be entered X 0r O 
         *  delimiter is one space, more delimiters can be added
         */
        public bool ValidateChoice(string input)
        {
            string pattern = @"^[0-3] [0-3] [X|O]$";
            return Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase);
        }

        public Player CollectPlayerDetails(string name)
        {

            var x = 0;
            var y = 0;
            var validInput = false;
            while (!validInput)
            {
                Console.WriteLine($"Please enter player move e.g '0 0 {name.ToUpper()}' ");
                var input = Console.ReadLine();
                validInput = ValidateChoice(input);
                if (!validInput)
                    Console.WriteLine("Invalid please try again"); //throws exception here -> TODO: handle the exception for preventing intruption in the game

                var inputArray = input.Split(' ').ToArray();
                x = int.Parse(inputArray[0]);
                y = int.Parse(inputArray[1]);
            }
            return new Player(x, y, name);
        }
    }
}
