using System.ComponentModel;
using System.Reflection.Metadata;

namespace Assigment.Net.Advansed1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: What is a generic class? Why use generics?
            //A class with a type parameter T set at usage time.
            //type safety, code reuse, no boxing/Unboxing.
            #endregion

            #region Q2
            //Q2: Write a generic class Container<T> with Add and Get methods.

            //Container<int> container = new Container<int>();
            //container.Add(5);
            //container.Add(7);
            //container.Add(2);
            //Console.WriteLine(container.Get(1));
            #endregion

            #region Q3
            //Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            //A generic type with more than one type parameter

            Pair<int, double> pair = new Pair<int, double>(5, 1.0);
            Console.WriteLine(pair.Key);
            Console.WriteLine(pair.Value);
            #endregion
        }
    }
}
