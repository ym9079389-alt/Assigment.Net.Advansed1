using System.ComponentModel;

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

            Container<int> container = new Container<int>();
            container.Add(5);
            container.Add(7);
            container.Add(2);
            Console.WriteLine(container.Get(1));
            #endregion
        }
    }
}
