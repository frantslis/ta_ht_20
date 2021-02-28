package com.epam.test.automation.java.practice4;

public class Task3 {
    private Task3() {}

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     * if set invalid arguments in method, then method must throws
     * IllegalArgumentException
     */
    public static int multiArithmeticElements(int a1, int t, int n) {

        int multiplication = 1;

        if (n < 1)
        {
            throw new IllegalArgumentException();
        }
        else {
            for (int i = 0; i < n; i++) {
                multiplication *= a1;
                a1 += t;
            }
            return multiplication;
        }
    }
}
