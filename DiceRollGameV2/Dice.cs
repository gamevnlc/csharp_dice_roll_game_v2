namespace DiceRollGameV2;

public class Dice
{
    public int DiceNumber { get; }

    public Dice()
    {
        DiceNumber = Roll();
    }

    private int Roll()
    {
        Random r = new Random();
        return r.Next(1, 7);
    }
}