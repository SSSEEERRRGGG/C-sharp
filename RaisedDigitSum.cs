using System;
using System.Collections.Generic;

public class SumDigPower
{

    public static long[] SumDigPow(long a, long b)
    {
        List<long> list = new List<long>();

        for (int i = (int)a; i <= b; i++)
        {
            if (Summ(i) == i)
                list.Add(i);
        }

        long[] result = new long[list.Count];

        for (int i = 0; i < list.Count; i++)
            result[i] = list[i];

        return result;
    }

    public static double Summ(int num)
    {
        double result = 0;
        int digit = 0;
        char[] ar = num.ToString().ToCharArray();

        for (int i = 0; i < ar.Length; i++)
        {
            digit = Int32.Parse(ar[i].ToString());
            result += Math.Pow(digit, i + 1);
        }

        return result;
    }
}
