package com.epam.test.automation.java.practice1;

public class Main {

    private Main(){

    }

    public static int task1(int n) {

        int result = 0;

        if (n > 0)
        {
            result = (int) Math.pow(n, 2);
        }
        else if (n < 0)
        {
            result = Math.abs(n);
        }

        return result;
    }

    /**
     * <summary>
     * Implement code according to description of task 2.
     * </summary>
     */
    public static int task2(int n) {

        int result = 0;
        int a = n / 100;
        int b = n / 10 % 10;
        int c = n % 10;

        int max = Math.max(Math.max(a, b), c);
        int min = Math.min(Math.min(a, b), c);

        int tens = a + b + c - max - min;
        result = max * 100 + tens * 10 + min;

        return result;
    }
}
