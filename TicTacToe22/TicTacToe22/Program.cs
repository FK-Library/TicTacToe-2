// See https://aka.ms/new-console-template for more information

using TicTacToe22;

Console.WriteLine("Tic Tac Toe");

//string[][] board = { new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" } };
var board = BoardFactory.CreateBoard();

//var winning = false;

var inputService = new InputService();
var display = new Display(board);

//while (!winning)
//{
//    display.DisplayBoard(board);

    //collect payer 1 & 2  input
    //var details = inputService.CollectDetails();
    //var movements = new MovementService();// (item, board);
    //var applyRules = new ApplyRulesService();//(player: TupplePlayerAndBoard.Item2, board: TupplePlayerAndBoard.Item1);

    //foreach (var item in details.Players)
    //{
    //    var TupplePlayerAndBoard = movements.FillBoard(item, board);
    //    winning = applyRules.HasWon(player: TupplePlayerAndBoard.Item2, board: TupplePlayerAndBoard.Item1);

    //    if (winning)
    //    {
    //        Console.WriteLine($"Winner is {item.Name} ");
    //        display.DisplayBoard(board);
    //        break;
    //    }
    //}


    //}
    //var details = inputService.CollectDetails();
    var movements = new MovementService();// (item, board);
    var applyRules = new ApplyRulesService();//(player: TupplePlayerAndBoard.Item2, board: TupplePlayerAndBoard.Item1);

var game = new Game(inputService, movements, applyRules, display);
game.PlayMe(board);

Console.ReadKey();
