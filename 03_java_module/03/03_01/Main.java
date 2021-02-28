package com.epam.test.automation.java.practice3;

public class Main {
    private Main(){
    }

    /**
     * <summary>
     * Implement code according to description of task 1.
     * </summary>
     */
    public static int[] task1(int[] array) {
        for (int i = 0; i < array.length / 2; i++)
        {
            int j = array.length - i - 1;
            if (array[i] % 2 == 0 && array[j] % 2 == 0)
            {
                array[i] += array[j];
                array[j] = array[i] - array[j];
                array[i] -= array[j];
            }
        }
        return array;

    }

    /**
     * <summary>
     * Implement code according to description of task 2.
     * </summary>
     */
    public static int task2(int[] array) {
        int indexFirst = 0;
        int indexLast = 0;
        int maxElement = 0;

        for (int i = 0; i < array.length; i++)
        {
            if (maxElement < array[i])
            {
                maxElement = array[i];
                indexFirst = i;
                indexLast = i;
            }
            else
            {
                if (maxElement == array[i])
                    indexLast = i;
            }
        }
        return indexLast - indexFirst;
    }

    /**
     * <summary>
     * Implement code according to description of task 3.
     * </summary>
     */
    public static int[][] task3(int[][] matrix) {

        for (int i = 0; i < matrix.length; i++)
        {
            for (int j = 0; j < matrix[0].length; j++)
            {
                if (i > j)
                {
                    matrix[i] [j] = 0;
                }
                else if (i < j)
                {
                    matrix[i] [j] = 1;
                }
            }

        }
        return matrix;

    }

}
