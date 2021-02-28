using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    //TODO: Create public class Rectangle here   
    public class Rectangle
    {
        //TODO: Define two private double fields: 'sideA', 'sideB'
        private double sideA;
        private double sideB;

        //TODO: Define constructor with two double parameters: 'a', 'b'. Assign parameters to sides
        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }

        //TODO: Define constructor with double parameter: 'a'. Parameter sets side A of rectangle, and B-side always equals 5
        public Rectangle(double a)
        {
            sideA = a;
            sideB = 5;
        }

        //TODO: Define constructor without parameters. A-side of rectangle equals 4, B-side - 3
        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }

        //TODO: Define public method 'GetSideA' that returns value of A-side
        public double GetSideA()
        {
            return sideA;
        }

        //TODO: Define public method 'GetSideB' that returns value of B-side
        public double GetSideB()
        {
            return sideB;
        }

        //TODO: Define public method 'Area' that calculates and returns value of area
        public double Area()
        {
            return sideA * sideB;
        }

        //TODO: Define public method 'Perimeter' that calculates and returns value of perimeter
        public double Perimeter()
        {
            return 2 * (sideA + sideB);
        }

        //TODO: Define public method 'IsSquare' that checks if rectangle is a square. Returns true if it is a square, false if it's not.
        public bool IsSquare()
        {
            if (sideA == sideB)
                return true;
            else
                return false;
        }

        //TODO: Define public method 'ReplaceSides' that swaps values of rectangle sides
        public void ReplaceSides()
        {
            sideA += sideB;
            sideB = sideA - sideB;
            sideA -= sideB;
        }
    }

    //TODO: Create public class ArrayRectangles here
    public class ArrayRectangles
    {
        //TODO: Define private field that is array of rectangles: rectangle_array
        private Rectangle[] rectangle_array;

        public ArrayRectangles(int n)
        {
            //TODO: Define constructor with int parameter: 'n'. Constructor should create an empty array 
            //of rectangles with length of 'n'
            Rectangle[] rectangle_array = new Rectangle[n];
        }

        //TODO: Define constructor that gets enumerable or array of rectangles. 
        //Constructor should assign them to its field
     
        public ArrayRectangles(IEnumerable<Rectangle> array)
        {
            rectangle_array = (Rectangle[])array;
        }

        //TODO: Define public method 'AddRectangle' that adds rectangle on the first empty place of array field. 
        //Returns true if array has empty space, if not false, if there is no free space in the array  

        public bool AddRectangle(Rectangle rectangle)
        {
            bool result = true;
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] != null)                
                    result = false;                   

                if (rectangle_array[i] == null)
                    rectangle_array[i] = rectangle;
            }
            return result;
        }

        //TODO: Define public method 'NumberMaxArea' that returns number of rectangle with max value of area. 
        //Numbering starts from 0

        
        public int NumberMaxArea()
        {
            /*
            int result;

            if (rectangle_array.Length == 0)
            {
                result = 0;
            }
            else
            {
                int max = rectangle_array[0];

                for (int i = 1; i < rectangle_array.Length; i++)
                {
                    if (max < rectangle_array[i])
                        max = rectangle_array[i];
                }

                int maxArea = Array.IndexOf(rectangle_array, max);

                result = maxArea;
            }
            return result;

            double maxArea = Array.IndexOf(rectangle_array, max);
            
            */
            int result = 0;
            return result;
            
        }

        //TODO: Define public method 'NumberMinPerimeter' that returns number of rectangle with min value of perimeter. Numbering starts from 0
        public int NumberMinPerimeter()
        {
            int result = 0;
            return result;
        }

        //TODO: Define public method 'NumberSquare' that returns amount of squares in array of rectangles
        public int NumberSquare()
        {
            int result = 0;
            return result;
        }
    }


}
