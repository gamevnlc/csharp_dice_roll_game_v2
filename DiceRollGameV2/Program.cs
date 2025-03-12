// See https://aka.ms/new-console-template for more information

using DiceRollGameV2;

Dice dice = new Dice();
GameHandler gameHandler = new GameHandler(dice);
gameHandler.PlayGame();
gameHandler.PrintResult();
Console.ReadKey();