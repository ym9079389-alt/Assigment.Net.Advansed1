using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment.Net.Advansed1
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
    }
}
