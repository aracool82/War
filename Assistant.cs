using System;

public class Assistant
{
    private static Random s_randon = new();

    public static int GenerateRandomNumber(int maxNumber, int minNumber = 0)
    {
        return s_randon.Next(minNumber, maxNumber);
    }
}