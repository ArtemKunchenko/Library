using System;
using MyString;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] str = new char[] { 'H', 'i', ',', ' ', 'A', 'l', 'e', 'x', '!' };
            char[] str1 = new char[] { 'A', 'l', 'e', 'x' };
            char[] str2 = new char[] { ',', ' ', 'H', 'i' };
            MyString.String ex = new MyString.String(str);
            //Console.WriteLine(ex.StartWith());
            //Console.WriteLine(ex.EndWith());
            //Console.WriteLine(ex.ToString());
            //MyString.String ex2 = new MyString.String(ex.Substring(4,4));
            //Console.WriteLine(ex2.ToString());
            //ex.Remove(2, 6);
            //Console.WriteLine(ex.ToString());
            //ex2.RemoveAll();
            //Console.WriteLine(ex2.ToString());
            Console.WriteLine(ex.IndexOf(str1));// attention ex was changed above
            ex.Concat(str1, str2 );
            Console.WriteLine(ex.ToString());
            Console.ReadKey();
            
        }
    }
}
