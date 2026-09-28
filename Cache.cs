using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment.Net.Advansed1
{
    internal class Cache <TKey, TValue>
    {
            private class CacheItem
            {
                public TKey Key;
                public TValue Value;
            }

            private List<CacheItem> _items = new List<CacheItem>();
            public void Add(TKey key, TValue value)
            {
                Remove(key);
                _items.Add(new CacheItem
                {
                    Key = key,
                    Value = value,
                });
            }
            private CacheItem Find(TKey key)
            {
                foreach (var item in _items)
                {
                    if (item.Key.Equals(key))
                        return item;
                }
                return default;
            }
            public bool Contains(TKey key)
            {
                return Find(key) != null;
            }

            public TValue Get(TKey key)
            {
                var item = Find(key);
                if (Contains(key))
                    return Find(key).Value;
                return default;
            }

            public bool Remove(TKey key)
            {
                var item = Find(key);
                if (item == null) return false;
                return _items.Remove(item);
            }

    }
}
