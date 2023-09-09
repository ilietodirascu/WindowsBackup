using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBinarySearch();
        }
        public static int BinarySearch(int[] numbers, int number)
        {
            int high = numbers.Length - 1;
            int low = 0;

            while (low <= high)
            {
                int mid = (high + low) / 2;
                int guess = numbers[mid];
                if (guess == number)
                {
                    return mid;
                }
                if (guess > number)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            Console.WriteLine("Number was not found");
            return 0;
        }
        public static void TestBinarySearch()
        {
            Random rnd = new Random();
            for (int i = 0; i < 300; i++)
            {
                List<int> nums = new List<int>();
                while (nums.Count < 15)
                {
                    if (!nums.Contains(rnd.Next(0, int.MaxValue))) nums.Add(rnd.Next(0, 100));
                }
                int[] arr = nums.ToArray();
                Array.Sort(arr);
                int requestedNum = nums[rnd.Next(0, 15)];
                int binarySearchReturnValue = BinarySearch(arr, requestedNum);
                if (arr[binarySearchReturnValue] != requestedNum )
                {
                    Console.WriteLine($"Your tests failed for requested num:{requestedNum}; \narray:[{String.Join(',',arr)}];\nreturnedIndex:{binarySearchReturnValue}");
                    return;
                }
                Console.WriteLine($"Your tests passed for requested num:{requestedNum}; \narray:[{String.Join(',', arr)}];\nreturnedIndex:{binarySearchReturnValue}");


            }
        }
    }
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]

        public void TestBinarySearch()
        {
            Random rnd = new Random();
            bool passes = true;

            for (int i = 0; i < 300; i++)
            {
                List<int> nums = new List<int>();
                while (nums.Count < 30)
                {
                    if (!nums.Contains(rnd.Next(0, int.MaxValue))) nums.Add(rnd.Next(0, int.MaxValue));
                }
            }

        }

    }
}
