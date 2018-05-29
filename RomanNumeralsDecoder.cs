using System;

public class RomanDecode
{
    public static int Solution(string roman)
    {
        int result = 0;

        object digit, digit_next = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            digit = Enum.Parse(typeof(Numbers), roman[i].ToString());
            result += (int)digit;
        }

        for (int i = 0; i < roman.Length; i++)
        {
            digit = Enum.Parse(typeof(Numbers), roman[i].ToString());

            if (i < roman.Length - 1)
                digit_next = Enum.Parse(typeof(Numbers), roman[i + 1].ToString());

            if ((int)digit < (int)digit_next)
            {
                result -= (int)digit * 2;
            }
        }

        return result;
    }

    public enum Numbers
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }
}
