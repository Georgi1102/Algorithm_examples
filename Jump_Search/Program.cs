using System;
using System.Linq;

namespace Jump_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //for jump search we need sorted array
            int[] arr = new int[] { 1, 2, 3, 7, 8, 12, 16, 27 };
            int element = int.Parse(Console.ReadLine());

            int searchedIndex = JumpSearch(arr, element);

            Console.Write("Number " + element +
                           " is at index " + searchedIndex);

        }

        public static int JumpSearch(int[] arr, int element)
        {
            int lenght = arr.Length;

            // Finding block size to be jumped
            int prevStep = (int)Math.Floor(Math.Sqrt(lenght));

            // Finding the block where element is
            // present (if it is present)
            int prev = 0;
            while (arr[Math.Min(prevStep, lenght) - 1] < element)
            {
                prev = prevStep;
                prevStep += (int)Math.Floor(Math.Sqrt(lenght));
                if (prev >= lenght)
                    return -1;
            }

            // Doing a linear search for x in block
            // beginning with prev.
            while (arr[prev] < element)
            {
                prev++;

                // If we reached next block or end of
                // array, element is not present.
                if (prev == Math.Min(prevStep, lenght))
                    return -1;
            }

            // If element is found
            if (arr[prev] == element)
                return prev;

            return -1;

        }
    }
}
