using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB02._IEnumerable.Extension
{
    public static class Extensions
    {
        public static T Sumext<T>(this IEnumerable<T> IEnum)
        {
            if (typeof(T) == typeof(int))
            {
                int sum = 0;
                foreach (T number in IEnum)
                {
                    sum += (int)(object)number;
                }
                return (T)(object)sum;
            }
            else if (typeof(T) == typeof(decimal))
            {
                decimal sum = 0;
                foreach (T number in IEnum)
                {
                    sum += (decimal)(object)number;
                }
                return (T)(object)sum;
            }
            return (T)(object)0;
        }

        public static T Productext<T>(this IEnumerable<T> IEnum)
        {
            if (typeof(T) == typeof(int))
            {
                int product = 1;
                foreach (T number in IEnum)
                {
                    product *= (int)(object)number;
                }
                return (T)(object)product;
            }
            else if (typeof(T) == typeof(decimal))
            {
                decimal product = 0;
                foreach (T number in IEnum)
                {
                    product *= (decimal)(object)number;
                }
                return (T)(object)product;
            }
            return (T)(object)0;
        }

        public static decimal Averageext<T>(this IEnumerable<T> IEnum)
        {
            if (typeof(T) == typeof(int))
            {
                int sum = 0;
                foreach (T number in IEnum)
                {
                    sum += (int)(object)number;
                }
                return ((decimal)sum / IEnum.Count());
            }
            else if (typeof(T) == typeof(decimal))
            {
                decimal sum = 0;
                foreach (T number in IEnum)
                {
                    sum += (decimal)(object)number;
                }
                return (sum / IEnum.Count());
            }
            return (decimal)0;
        }
    }
}
