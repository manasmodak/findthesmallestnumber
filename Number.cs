using System;
using System.Collections.Generic;

namespace Numbers
{   
    ///
    /// Class for several number operations
    ///
    public class NumberOperations
    public class NumberOperations
    {
        /// <summary>
        /// To find the smallest number among a given set of numbers
        /// Assumption: list will always contain at least one number
        /// </summary>
        /// <param name="listOfNumbers"> List of numbers</param>
        /// <returns> Returns the smallest number from the list</returns>
        public static int FindSmallestNumberFromListOfNUmbers(List<int> listOfNumbers)
        {
            // start with the first number as reference to compare
            int smallestNumber = listOfNumbers[0];

            for (int i = 1; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] < smallestNumber)
                {
                    smallestNumber = listOfNumbers[i];
                }
            }

            return smallestNumber;
        }

    }
}
