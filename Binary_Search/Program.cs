using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of an array with integers
            int[] exampleArr = { 1, 2, 3, 4, 5, 9, 11, 12, 16, 20, 27, 31, 40 };

            //wanted number input from the console
            int wantedNumber = int.Parse(Console.ReadLine());

            if (BinarySearchItem(exampleArr, 0, exampleArr.Length, wantedNumber) != 0)
            {
                Console.WriteLine("Item found!");
            }

            else
            {
                Console.WriteLine("Item not found!");
            }
        }

        static int BinarySearchItem(int[] arr, int leftIndex, int rightIndex, int wantedNumber)
        {
            if (leftIndex <= rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;

                if (arr[middleIndex] == wantedNumber)
                {
                    return wantedNumber; 
                }

                if (arr[middleIndex] > wantedNumber)
                {
                    return BinarySearchItem(arr, leftIndex, middleIndex - 1, wantedNumber);
                }

                else
                {
                    return BinarySearchItem(arr, middleIndex + 1, rightIndex, wantedNumber);
                }
            }


            //static output if the number is not found
            return 0;
        }
    }
}
