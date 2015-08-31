using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    public static class Extension
    {
        // PREDICATE ------>  extension метод, който връща Т. Will extended колекция от Т и ще подбира по func/predicate условие
        public static T FirstOrDef<T>( this IEnumerable<T> collection, Func<T, bool> conditionFunc)//Func<T,bool> ===== Predicate<T>
        {
            foreach (var element in collection)
            {
                if (conditionFunc(element))
                {
                    return element;
                }
            }
            return default(T);
        }

        //FUNC/PREDICATE--------> extension метод, който връща Т. Will extended колекция от Т и ще подбира по func/predicate условие
        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            var resultCollection = new List<T>();
            foreach (var element in collection)
            {
                if (condition(element))
                {
                    resultCollection.Add(element);
                }
            }
            return resultCollection;
        }
        
        //ACTION delegate
        public static void ForEachH<T>(this IEnumerable<T> colection) 
        {
            foreach (var elem in colection)
            {
                Console.WriteLine(elem);                
            }
        }
    }
}
