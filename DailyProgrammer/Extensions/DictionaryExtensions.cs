using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.Extensions
{
    public static class DictionaryExtensions
    {
        public static TValue SetDefault<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue defaultValue) 
            where TKey : notnull
        {
            if (dict.ContainsKey(key)) 
            {
                return dict[key];
            }
            else
            {
                dict[key] = defaultValue;
                return defaultValue;
            }
        }
    }
}
