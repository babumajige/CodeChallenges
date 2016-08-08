using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    public class CodeChallengeOne
    {
        public static void Main(string[] args)
        {
            string inputValues = Console.ReadLine();
            if (inputValues != null)
            {
                String[] elements = inputValues.Split(',');                 
                int[] numbers = Array.ConvertAll(elements, Int32.Parse);  
                bool result = CheckSum(numbers);                             //check sum of left and right numbers of index
                Console.WriteLine(result ? "TRUE" : "FALSE");               
            }
        }

        public static bool CheckSum(int[] nums)
        {
            int leftIndex = 0;
            int rightIndex = nums.Length - 1;

            long leftSum = nums[leftIndex];
            long rightSum = nums[rightIndex];

            while (leftIndex != rightIndex)
            {
                if (leftSum < rightSum)
                {
                    leftIndex++;
                    leftSum += nums[leftIndex];
                }
                else 
                {
                    rightIndex--;
                    rightSum += nums[rightIndex];
                }

                if (leftSum == rightSum)
                {
                    return true;
                }
            }
            return false;
        }
    }
}