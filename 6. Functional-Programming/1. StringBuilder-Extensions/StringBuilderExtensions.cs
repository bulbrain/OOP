using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StringBuilder_Extensions
{
    public static class StringBuilderExtention
    {
        public static StringBuilder Substring(this StringBuilder str, int startIndex, int length)
        {
            string res = str.ToString();
            if (res.Length < startIndex + length)
            {
                throw new ArgumentOutOfRangeException("Invalid range.");
            }
            res = res.Substring(startIndex, length);
            StringBuilder result = new StringBuilder(res);
            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder str, string text) 
        {
            str.Replace(text, "");
            return str;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder str,IEnumerable<T> items)
        {
            str = str.Append(items);
            return str;
        }
    }
}
