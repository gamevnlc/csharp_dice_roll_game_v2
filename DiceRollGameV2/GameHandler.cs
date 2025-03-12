namespace DiceRollGameV2;

public class GameHandler
{
    private readonly Dice _dice;
    private const int MaxTry = 3;
    private int _turnCount = 1;
    public GameResult Result;

    public GameHandler(Dice dice)
    {
        _dice = dice;
    }

    public void PlayGame()
    {
        WellComeMsg();
        while (_turnCount <= MaxTry)
        {
            Console.WriteLine("Enter a number:");
            var inputVal = Console.ReadLine();
            if (int.TryParse(inputVal, out int inputNumber))
            {
                if (inputNumber != _dice.DiceNumber)
                {
                    IncorrectMsg();
                    _turnCount++;
                    continue;
                }
                else
                {
                    Result = GameResult.Win;
                    return;
                }
            }
            else
            {
                IncorrectMsg();
                continue;
            }
        }
        Result = GameResult.Lose;
    }

    private void WellComeMsg()
    {
        Console.WriteLine($"Dice rolled. Guess what number it shows in {MaxTry} tries");
    }

    private void IncorrectMsg()
    {
        Console.WriteLine("Wrong number.");
    }

    public void PrintResult()
    {
        if (Result == GameResult.Win)
        {
            Console.WriteLine("You Win");
        }
        else
        {
            Console.WriteLine("You Lose");
        }
    }
}