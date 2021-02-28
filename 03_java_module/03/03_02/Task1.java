package com.epam.test.automation.java.practice4;

public class Task1 {
    private Task1() {}

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     * if set invalid arguments in method, then method must throws
     *  IllegalArgumentException
     */
    public static boolean isSorted(int[] array, SortOrder order)
    {
        if (array.length == 0) {
            throw new IllegalArgumentException();
        }
        if (order == null)
        {
            throw new NullPointerException();
        }
        else {
            switch (order) { // NOSONAR
                case ASC:
                    for (int i = 1; i < array.length; i++) {
                        if (array[i] < array[i - 1])
                            return false;
                    }
                    break;
                case DESC:
                    for (int i = 1; i < array.length; i++) {
                        if (array[i] > array[i - 1])
                            return false;
                    }
                    break;
            }
            return true;
        }
    }
}
