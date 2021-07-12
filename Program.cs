using System;
using leetCodeDataStructuresAndAlgorithms.ArrayExercises;


namespace leetCodeDataStructuresAndAlgorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            RemoveElement removeElement = new RemoveElement();


            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 }; // Input array
            int val = 2; // Value to remove
                         //int[] expectedNums = [...]; // The expected answer with correct length.
                         // It is sorted with no values equaling val.

            int k = removeElement.RemoveElementFunction(nums, val); // Calls your implementation

            Console.WriteLine(k);
            Console.Read();
        }
    }
}
