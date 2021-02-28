package com.epam.test.automation.java.practice5;

/**
 * <summary>
 * Implement class according to description of task.
 * </summary>
 */
public class ArrayRectangles {

    final Rectangle[] rectangleArray;

    protected ArrayRectangles(int n)
    {
        rectangleArray = new Rectangle[n];
    }

    public ArrayRectangles(Rectangle ... rectangles)
    {
        rectangleArray = rectangles;
    }
    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public boolean addRectangle(Rectangle rectangle) {
        for (int i = 0; i < rectangleArray.length; i++)
            if (rectangleArray[i] == null)
            {
                rectangleArray[i] = rectangle;
                return true;
            }
        return false;
    }

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public int numberMaxArea() {
        double maxArea = rectangleArray[0].area();
        int number = 0;
        for (int i = 1; i < rectangleArray.length; i++)
        {
            if (rectangleArray[i] != null && maxArea < rectangleArray[i].area())
            {
                maxArea = rectangleArray[i].area();
                number = i;
            }
        }
        return number;
    }

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public int numberMinPerimeter() {
        int number = 0;
        double minPerimeter = rectangleArray[0].perimeter();

        for (int i = 1; i < rectangleArray.length; i++)
        {
            if (minPerimeter > rectangleArray[i].perimeter())
            {
                minPerimeter = rectangleArray[i].perimeter();
                number = i;
            }
        }
        return number;
    }

    /**
     * <summary>
     * Implement code according to description of task.
     * </summary>
     */
    public int numberSquares() {
        int number = 0;
        for (var rectangle : rectangleArray) {
            if (rectangle != null && rectangle.isSquare())
                number++;
        }
        return number;
    }

}

