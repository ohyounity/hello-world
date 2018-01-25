using System.Collections.Generic;

namespace Framework.NET.Containers.Extensions
{
    public static class KeyValuePairExtensions
    {
        public static KeyValuePair<K, V> MakeKeyValuePair<K,V>(K key, V value)
        {
            return new KeyValuePair<K, V>(key, value);
        }
    }
}
