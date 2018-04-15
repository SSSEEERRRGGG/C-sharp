//Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

List<int> numbers = new List<int>();

for (int i = 0; i < value; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
         numbers.Add(i);
}

return numbers.Sum();
