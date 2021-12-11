using System;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rollsArr = { 1, 2, 3, 4, 5, 10, 22, 27 };
            int inputNumber = int.Parse(Console.ReadLine());

            bool searchResult = false;

            for (int i = 0; i < rollsArr.Length; i++)
            {
                if (rollsArr[i] == inputNumber)
                {
                    Console.WriteLine($"The number is found, {inputNumber} is in the array.");
                    searchResult = true;
                }           
            }

            if (searchResult == false)
            {
                Console.WriteLine($"The {inputNumber} was not in the array ");
            }
        }
    }
}
