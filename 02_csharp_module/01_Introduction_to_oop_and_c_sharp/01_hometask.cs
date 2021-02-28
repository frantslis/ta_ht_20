using System;

namespace Condition
{
    public static class Condition
    {
        /// <summary>
        /// Implement code according to description of  task 1
        /// </summary>        
        public static int Task1(int n)
        {
            int result;
            
            if (n > 0)
            {
                result = Convert.ToInt32(Math.Pow(n, 2));
                return result;
            }
            else
            {
                if (n < 0)
                {
                    result = Convert.ToInt32(Math.Abs(n));
                    return result;
                }
                else
                {
                    result = Convert.ToInt32(n);
                    return result;
                }
            }
        }

        /// <summary>
        /// Implement code according to description of  task 2
        /// </summary>  
        public static int Task2(int n)
        {
            int a;
            int b;
            int c;
            int d;
            int e;
            int result;
            
            a = n / 100;
            c = n % 10;
            b = (n - c - 100 * a) / 10;
            d = Math.Min(a, b);
            e = Math.Max(a, b);

            if (Math.Min(a, b) >= c)
            {
                result = e * 100 + d * 10 + c;
                return result;
            }
            else
            {
                if (Math.Min(a, b) <= c && Math.Max(a,b) <= c)
                {
                    result = c * 100 + e * 10 + d; 
                    return result;
                }
                else
                {
                    result = e * 100 + c * 10 + d; 
                    return result;
                }
            }
        }
    }
}
