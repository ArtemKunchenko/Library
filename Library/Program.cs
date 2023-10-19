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
            char[] str3 = new char[] { 'A', 'l', 'i', 'x' };
            MyString.String ex = new MyString.String(str);
            MyString.String ex3 = new MyString.String(str1);
            MyString.String ex4 = new MyString.String(str2);
            //Console.WriteLine(ex.StartWith());
            //Console.WriteLine(ex.EndWith());
            //Console.WriteLine(ex.ToString());
            //MyString.String ex2 = new MyString.String(ex.Substring(4, 4));
            //Console.WriteLine(ex2.ToString());
            //ex.Remove(2, 6);
            //Console.WriteLine(ex.ToString());
            //ex2.RemoveAll();
            //Console.WriteLine(ex2.ToString());
            //Console.WriteLine(ex.IndexOf(str1));// attention ex was changed above
            //ex.Concat(str1, str2);
            //ex.Concat(str2);
            //Console.WriteLine(ex.ToString());
            //ex.Replace(str1);
            //ex.Trim(',');
            //Console.WriteLine(ex.ToString());
            //Console.WriteLine(ex.CompareTo(str1,str3));
            //Console.WriteLine(ex3.CompareTo(str3));
            Console.WriteLine(ex4.ToString());
            ex4=ex+ex3;
            Console.WriteLine(ex4.ToString());
            Console.ReadKey();
            
        }
    }
}
