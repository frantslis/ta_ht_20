using System;

namespace LoopTasks
{
    public static class LoopTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static int SumOfOddDigits(int n)
        {
            int digit;
            int result;
            result = 0;

            while (n != 0)
            {
                digit = n % 10;
                if (digit % 2 != 0)
                {
                    result += digit;
                }
                n /= 10;
            }
            return result;
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int NumberOfUnitsInBinaryRecord(int n)
        {
            int reminder;
            int result;
            result = 0;

            do
            {
                reminder = n % 2;
                result += reminder;
                n /= 2;
            } while (n > 0);

            return result;
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static int SumOfFirstNFibonacciNumbers(int n)
        {
            
            int result;

            if (n == 1)
            {
                return 0;
            }
            else
            {
                if (n == 2)
                {
                    return 1;
                }
                else
                {
                    result = SumOfFirstNFibonacciNumbers(n - 1) + SumOfFirstNFibonacciNumbers(n - 2) + 1;
                }
            }
            return result;


        }
    }
}