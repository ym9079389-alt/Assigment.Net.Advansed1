using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

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

            #region Q8
            //Q8: What is the 'class' constraint? Write an example.
            //T must be a reference type

            //public class Box<T> where T : class
            //{
            //  public T Value;
            //}
            #endregion

            #region Q9
            //Q9: What is the 'new()' constraint? Write an example.
            //T must have parameterless constructor.

            //class Box<T> where T : new()
            //{
            //public T value()
            //{
            //   new T();
            //}
            //}
            #endregion

            #region Q10
            //Q10: What is the interface constraint? Write an example.
            //T must implement a specific interface

            //class Box<T> where T : IComparable<T>
            //{
            //    public bool IsGreater(T a, T b) => a.CompareTo(b) > 0;
            //}
            #endregion

            #region Q11
            //Q11: What is the base class constraint? Write an example.
            //T must inherit from a specific base class

            //class Animal { public void Eat() { } }

            //class Zoo<T> where T : Animal
            //{
            //    public void Feed(T animal) => animal.Eat();
            //}
            #endregion

            #region Q12
            //Q12: How do you apply multiple constraints? Write an example.

            //class cat<T> where T : Animal, IComparable<T>, new()
            //{
            //    public T Feed() => new T();
            //}
            #endregion

            #region Q13
            //Q13: What does the 'default' keyword do in generics ?
            //Returns the default value of T: null for reference types, 0 for numbers, false for bool.
            #endregion

            #region Q14
            //Q14: Write a SafeList < T > that returns default when the index is invalid.

            //SafeList<int> safeList = new SafeList<int>();
            //safeList.Add(5);
            //safeList.Add(7);
            //safeList.Add(2);
            //Console.WriteLine(safeList.Get(3));
            #endregion

            #region Q15
            //Q15: What is covariance? Explain the 'out' keyword.
            //Allows assigning a more derived type where a base type is expected.
            //T is used only as output.
            #endregion

            #region Q16
            //Q16: What is contravariance? Explain the 'in' keyword.
            //Allows using a base type where a more derived type is expected.
            //T is used only as input.
            #endregion

            #region Q17
            //Q17: What is the difference between covariance and contravariance?
            //covariance: out, return only, Derived > Base.
            //contravariance: in, parameter only, Base > Derived.
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
