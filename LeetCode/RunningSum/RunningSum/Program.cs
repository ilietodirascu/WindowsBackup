using System;

namespace RunningSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",RunningSum(new int[] { 1, 2, 3, 4, 5 })));
        }
        public static int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}
