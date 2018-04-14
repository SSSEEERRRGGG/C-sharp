//Write a function that takes an array of numbers (integers for the tests) and a target number. 
//It should find two different items in the array that, when added together, give the target value. 
//The indices of these items should then be returned in an array like so: [index1, index2].

  public static int[] TwoSum(int[] numbers, int target)
  {
      int[] result = new int[2];

      for (int i = 0; i<numbers.Length; i++)
      {
          for (int j = i+1; j<numbers.Length; j++)
          {
              if (numbers[i] + numbers[j] == target)
              {
                  result[0] = i;
                  result[1] = j;
                  return result;
              }
          }
      }
      return result;
  }
