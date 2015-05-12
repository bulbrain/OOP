using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CustomLINQ
{
    public static class CustomLINQ
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) 
        {
            collection = collection.Except(bool ;
            collection = collection.Distinct();
            return collection;
        } 

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            collection = collection.
            return collection;
        }

        public static IEnumerable<string> WhereEndsWith<string>(this IEnumerable<string> collection, IEnumerable<string> suffixes) 
        {

        } 
    }
}
