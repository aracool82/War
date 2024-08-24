using System;

public class Assistant
{
    private static Random s_randon = new();

    public static int GenerateRandomNumber(int minNumber, int maxNumber)
    {
        return s_randon.Next(minNumber, maxNumber);
    }

    public static int GenerateRandomNumber(int maxNumber)
    {
        return s_randon.Next(0, maxNumber);
    }
}