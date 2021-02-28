package com.epam.test.automation.java.practice4;


public class Task2 {
    private Task2() {}

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     * if set invalid arguments in method, then method must throws
     * IllegalArgumentException
     */
    public static int[] transform(int[] array, SortOrder order) {
        boolean resultIn = Task1.isSorted(array, order);

        if (array.length == 0) {
            throw new IllegalArgumentException();
        }
        if (order == null)
        {
            throw new NullPointerException();
        }
        if (resultIn)
        {
            for (int i = 1; i < array.length; i++)
            {
                array[i] = array[i] + i;
            }
        }
        return array;
    }
}
