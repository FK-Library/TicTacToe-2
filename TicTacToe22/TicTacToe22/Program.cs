// See https://aka.ms/new-console-template for more information
using TicTacToe22;

Console.WriteLine("Tic Tac Toe");

var win = false;
while (!win)
{
    //collect payer 1 & 2  input
    var inputService = new InputService();
    var details = inputService.CollectDetails();
    Console.WriteLine(details.Players[0].Name);
    Console.WriteLine(details.Players[0].X);
    Console.WriteLine(details.Players[0].Y);
    Console.WriteLine(details.Players[0].Choices[details.Players[0].X][details.Players[0].Y]);

    Console.WriteLine(details.Players[1].Name);
    Console.WriteLine(details.Players[1].X);
    Console.WriteLine(details.Players[1].Y);
    Console.WriteLine(details.Players[1].Choices[details.Players[1].X][details.Players[1].Y]);

    // Validate and calculate moves 

    //Check winning
    win = true;
}
Console.ReadKey();
