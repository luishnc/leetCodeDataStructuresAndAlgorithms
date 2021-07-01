using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeDataStructuresAndAlgorithms.ArrayExercises
{
    /*
     *
     *Given a fixed length array arr of integers, duplicate each occurrence of zero, shifting the remaining elements to the right.

    Note that elements beyond the length of the original array are not written.

    Do the above modifications to the input array in place, do not return anything from your function.

    Example 1:

    Input: [1,0,2,3,0,4,5,0]
    Output: null
    Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
    Example 2:

    Input: [1,2,3]
    Output: null
    Explanation: After calling your function, the input array is modified to: [1,2,3]
 

    Note:

    1 <= arr.length <= 10000
    0 <= arr[i] <= 9
         * */
    class DuplicateZeros
    {


        public void FunctionDuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int x = arr.Length - 1; x > i; x--)
                    {
                        arr[x] = arr[x - 1];
                    }

                    i++;
                }
            }


        }
    }
}