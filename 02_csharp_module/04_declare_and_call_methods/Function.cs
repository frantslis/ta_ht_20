using System;

namespace Function
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            bool result = false;
            
            if (order == SortOrder.Descending)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] >= array[i])
                    {
                        result = true;
                        
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
            else if (order == SortOrder.Ascending)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] <= array[i])
                    {
                        result = true;
                        
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
                
            }


            return result;


            /*
            for (int i = 1; i < array.Length; i++)
            {
                if (order == SortOrder.Descending)
                    if (array[i - 1] >= array[i])
                    {
                        result = true;
                        return result;
                    }
                    else
                    {
                        result = false;
                        return result;
                    }
                else if (order == SortOrder.Ascending)
                {
                    if (array[i - 1] <= array[i])
                    {
                        result = true;
                        return result;
                    }
                    else
                    {
                        result = false;
                        return result;
                    }
                }
                else
                    result = false;
                    return result;
            }
            return result;

            */


            /*
            // variant 2 WRONG

            bool result = false;

            for (int i = 1; i < array.Length; i++)
            {

               if ((array[i - 1] > array[i]) && order == SortOrder.Descending)
               {
                   result = true;
               }
               else if ((array[i - 1] < array[i]) && order == SortOrder.Ascending)
               {
                   result = true;
               }
               else if ((array[i - 1] < array[i]) && order == SortOrder.Descending)
               {
                   result = false;
               }
               else if ((array[i - 1] > array[i]) && order == SortOrder.Ascending)
               {
                   result = false;
               }
                          
            }
            return result;
            */

        }


        // TODO :Define public static  method 'Transform' -  that will increase each array element by its index, if array IsSorted in  SortOrder  . The values should be passed into the method in such order : array ,order .
        public static void Transform(int[] array, SortOrder order)
        {
           bool resultIn = IsSorted(array, order);
           if (resultIn == true)
           {
                for (int i = 1; i < array.Length; i++)
                {
                    array[i] = array[i] + i;                   
                }
           }
        }
       
        public static double MultArithmeticElements(double a, double t, int n)
        {
            double mult = 1;
            double[] mas = new double[n];
            mas[0] = a;
            for (int i = 1; i < n; i++)
            {
                mas[i] = mas[i - 1] + t;
                mult *= mas[i];                
            }
            return mult = mult * a;
        }

        //TODO :Define public static method 'SumGeometricElements'  that calculate and return   sum for members of geometric progression ,while  element is smaller than limit value. The values should be passed into the method in such order: a ,t ,alim .  
        public static double SumGeometricElements(double a, double t, double alim)
        {
            double b = a;
            int counter = 0;

            while (alim < b)
            {
                b = b * t;
                counter++;                
            }
           
            double sum = 0;
            int i = 1;

            if (a < alim)
                return 0;
            else
            {

                double[] mas = new double[counter];
                mas[0] = a;

                for (i = 1; i < counter; i++)
                {
                    mas[i] = mas[i - 1] * t;
                    sum += mas[i];
                }
               
                return sum + a;
                
            }
        }
    }
}
