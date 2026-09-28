using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

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

            //Pair<int, double> pair = new Pair<int, double>(5, 1.0);
            //Console.WriteLine(pair.Key);
            //Console.WriteLine(pair.Value);
            #endregion

            #region Q4
            //Q4: What is a generic method? Write Swap<T> method.
            //A method with its own type parameter, even inside a non-generic class

            //int x = 5;
            //int y = 77;
            //Swap<int>(ref x, ref y);
            #endregion

            #region Q5
            //Q5: Write a generic method FindMax < T > that finds maximum value.

            //int[] x = { 40, 708, 90 };
            //int res = FindMax<int>(x);
            //Console.WriteLine(res);
            #endregion

            #region Q6
            //Q6: What is a generic interface? Write IRepository<T>.
            //An interface with a type parameter
            #endregion

            #region Q7
            //Q7: What is the 'struct' constraint? Write an example.
            //T must be a value type

            //public class Box<T> where T : struct
            //{
            //  public T Value;
            //}
            #endregion
        }
        #region @4
        public static void Swap<T>(ref T x,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        #endregion

        #region Q5
        static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            T max = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].CompareTo(max) > 0)
                {
                    max = items[i];
                }                
            }
            return max;
        }
        #endregion

        
    }
}
