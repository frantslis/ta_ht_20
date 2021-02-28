package com.epam.test.automation.java.practice2;

public class Main {
    private Main(){

    }

    /**
     * <summary>
     * Implement code according to description of task 1.
     * </summary>
     */
    public static int task1(int value) {
        int digit;
        int sum = 0;

        if (value <= 0)
        {
            throw new IllegalArgumentException();
        }
        else {
            while (value != 0)
            {
                digit = value % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                value /= 10;
            }

            return sum;

        }




    }

    /**
     * <summary>
     * Implement code according to description of task 2.
     * </summary>
     */
    public static int task2(int value) {
        int result = 0;
        int reminder;

        if (value <= 0)
        {
            throw new IllegalArgumentException();
        }
        else {
            do {
                reminder = value % 2;
                result += reminder;
                value /= 2;
            } while (value > 0);

            return result;
        }
    }

    /**
     * <summary>
     * Implement code according to description of task 3.
     * </summary>
     */
    public static int task3(int value) {
        int numberFibZero = 0;
        int numberFibFirst = 1;
        int numberFib;

        if (value <= 0)
        {
            throw new IllegalArgumentException();
        }
        else {

            for (int step = 2; step < value + 2; step++) {
                numberFib = numberFibZero + numberFibFirst;
                numberFibZero = numberFibFirst;
                numberFibFirst = numberFib;
            }
            return numberFibFirst - 1;
        }
    }
}
