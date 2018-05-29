namespace smile67Kata
{
    using System;
    public class Kata
    {
        public string workOnStrings(string a, string b)
        {
            string result = "";
            int counter = 0;
            char checking;

            for (int i = 0; i <= a.Length - 1; i++)
            {
                checking = a[i];
                counter = 0;

                for (int j = 0; j <= b.Length - 1; j++)
                {
                    if (a[i].ToString().ToLower() == b[j].ToString().ToLower())
                        counter++;
                }

                if (counter % 2 == 0)
                    result += a[i].ToString();
                else
                {
                    if (Char.IsLower(a[i]))
                        result += a[i].ToString().ToUpper();
                    else
                        result += a[i].ToString().ToLower();
                }
            }

            for (int i = 0; i <= b.Length - 1; i++)
            {
                checking = b[i];
                counter = 0;

                for (int j = 0; j <= a.Length - 1; j++)
                {
                    if (b[i].ToString().ToLower() == a[j].ToString().ToLower())
                        counter++;
                }

                if (counter % 2 == 0)
                    result += b[i].ToString();
                else
                    if (Char.IsLower(b[i]))
                        result += b[i].ToString().ToUpper();
                    else
                        result += b[i].ToString().ToLower();
            }

            return result;
        }
    }
}
