using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment.Net.Advansed1
{
    public class Container<T>
    {
        private List<T> _items = new List<T>();
        public void Add(T temp)
        {
            _items.Add(temp);
        }
        public T Get(int index)
        {
            return _items[index];
        }
    }
}
