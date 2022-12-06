// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using TicTacToe22;

Console.WriteLine("Tic Tac Toe");
string[][] board = { new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" } };

var winner = new Winner();
winner.Won = false;

var inputService = new InputService();
var display = new Display(board);


while (!winner.Won)
{
    display.DisplayBoard(board);


    //collect payer 1 & 2  input
    var details = inputService.CollectDetails();



    foreach (var item in details.Players)
    {
        var movements = new MovementService(item, board);
        var TupplePlayerAndBoard = movements.FillBoard(item, board);
        var applyRules = new ApplyRulesService(player: TupplePlayerAndBoard.Item2, board: TupplePlayerAndBoard.Item1);
        winner.Won = applyRules.Game(player: TupplePlayerAndBoard.Item2, board: TupplePlayerAndBoard.Item1);
        if (winner.Won)
        {
            winner.Name = item.Name;
            Console.WriteLine($"Winner is {winner.Name} ");
            display.DisplayBoard(board);
            break;


        }


    }

}
Console.ReadKey();
