using System;

/* Hi, here's your problem today. This problem was recently asked by Facebook:

Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:
Input: [0,1,0,3,12]
Output: [1,3,12,0,0]
You must do this in-place without making a copy of the array.
Minimize the total number of operations.

Here is a starting point:

class Solution:
  def moveZeros(self, nums):
    # Fill this in.

nums = [0, 0, 0, 2, 0, 1, 3, 4, 0, 0]
Solution().moveZeros(nums)
print(nums)
# [2, 1, 3, 4, 0, 0, 0, 0, 0, 0]
 */

namespace MoveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var solution = new Solution();
            solution.RunTest1();
            solution.RunTest2();

        }
    }

    public class Solution
    {
        public int[] RunTest1()
        {
            int[] testArray = { 0, 1, 0, 3, 12 };
            return MoveZeros(testArray);
        }

        public int[] RunTest2()
        {
            int[] testArray = { 0, 0, 0, 2, 0, 1, 3, 4, 0, 0 };
            return MoveZeros(testArray);
        }

        public int[] MoveZeros(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 0)
                {
                    for (int j = i+1; j < inputArray.Length; j++)
                    {
                        if (inputArray[j] != 0)
                        {
                            inputArray[i] = inputArray[j];
                            inputArray[j] = 0;
                            break;
                        }
                    }
                }
            }

            return inputArray;

        }

    }
}
