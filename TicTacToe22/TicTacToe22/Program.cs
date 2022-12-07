// See https://aka.ms/new-console-template for more information

using TicTacToe22;

Console.WriteLine(" --------- Tic Tac Toe --------- ");

var board = BoardFactory.CreateBoard();

var inputService = new InputService();
var display = new Display(board);
var movements = new MovementService();
var applyRules = new ApplyRulesService();

var game = new Game(inputService, movements, applyRules, display);
game.PlayMe(board);

Console.ReadKey();
