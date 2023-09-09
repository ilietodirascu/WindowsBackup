using System;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', SelectionSort(new int[] { 50,-4,-10,-20,1,0,3,33,40,49,-33,-100 })));
        }
        public static int[] SelectionSort(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < newArr.Length; i++)
            {
                int index = GetSmallestElement(arr);
                newArr[i] = arr[index];
                arr = arr.Where((x, i) => i != index).ToArray();
            }
            return newArr;
        }
        public static int GetSmallestElement(int[] arr)
        {
            int smallest = arr[0];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    index = i;
                    smallest = arr[i];
                }
            }
            return index;
        }
    }
}
