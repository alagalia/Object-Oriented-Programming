using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CustomLINQExtensionMethods
{
    static class Extension
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            var result = new List<T>();
            foreach (var element in collection)
            {
                if (!condition(element))
                {   
                    result.Add(element);
                }
            }
            return result;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> conditionFunc) where TSelector : IComparable
        {
            TSelector max = conditionFunc(collection.First()); //use Func to take Grade of Student
            foreach (var element in collection)
            {
                if (conditionFunc(element).CompareTo(max)==1)
                {
                    max = conditionFunc(element);
                }
            }
            return max;
        }
    }
}
