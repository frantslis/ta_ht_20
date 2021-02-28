using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static void ChangeElementsInArray(int[] nums)
        {
            for (int i = 0; i < nums.Length / 2; i++)
            {
                int j = nums.Length - i - 1;
                if (nums[i] % 2 == 0 && nums[j] % 2 == 0)
                {
                    nums[i] = nums[i] + nums[j];
                    nums[j] = nums[i] - nums[j];
                    nums[i] = nums[i] - nums[j];
                }
            }
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            int result;

            if (nums.Length == 0)
            {
                result = 0;
            }
            else
            {
                int max = nums[0];

                for (int i = 1; i < nums.Length; i++)
                {
                    if (max < nums[i])
                        max = nums[i];
                }

                int firstIndex = Array.IndexOf(nums, max);
                int lastIndex = Array.LastIndexOf(nums, max);
                result = lastIndex - firstIndex;
            }
            return result;

        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static void ChangeMatrixDiagonally(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (i < j)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
        }
    }
}
