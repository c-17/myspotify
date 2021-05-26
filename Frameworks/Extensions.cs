using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Frameworks{
    internal static class Extensions{
        public static Dictionary<TKey, TValue> AddIfNotExists<TKey, TValue>(this Dictionary<TKey, TValue> Dictionary, TKey Key, TValue Value){
            if(Dictionary.ContainsKey(Key))
                return Dictionary;

            Dictionary.Add(Key, Value);

            return Dictionary;
            }
        
        public static Dictionary<TKey, TValue> RemoveIfExists<TKey, TValue>(this Dictionary<TKey, TValue> Dictionary, TKey Key){
            if(!Dictionary.ContainsKey(Key))
                return Dictionary;

            Dictionary.Remove(Key);

            return Dictionary;
            }

        public static Dictionary<TKey, TValue> Insert<TKey, TValue>(this Dictionary<TKey, TValue> Dictionary, Int32 Index, TKey Key, TValue Value){
            List<KeyValuePair<TKey, TValue>> List = Dictionary.ToList();
            
            List.Insert(Index, new KeyValuePair<TKey, TValue>(Key , Value));

            Dictionary = new Dictionary<TKey, TValue>(List.ToDictionary(K => K.Key, V => V.Value));

            return Dictionary;
            }
        
        public static List<TValue> AddIfNotExists<TValue>(this List<TValue> List, TValue Value){
            if(List.Contains(Value))
                return List;

            List.Add(Value);

            return List;
            }
        
        public static List<TValue> RemoveIfExists<TValue>(this List<TValue> List, TValue Value){
            if(!List.Contains(Value))
                return List;

            List.Remove(Value);

            return List;
            }
        }
    }   
