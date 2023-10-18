using System;
using MyString;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] str = new char[] { 'H', 'i', ',', ' ', 'A', 'l', 'e', 'x', '!' };
            MyString.String ex = new MyString.String(str);
            Console.WriteLine(ex.StartWith());
            Console.WriteLine(ex.EndWith());
            
            Console.ReadKey();
        }
    }
}
