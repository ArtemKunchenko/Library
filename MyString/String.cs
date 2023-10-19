using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace MyString
{
    public class String
    {
        public char[] str { get; set; }
        public int length { get; set; }
        public String(char[] str)
        {
            this.str = str;
            this.length = str.Length;
        }
        public char StartWith() { return str[0]; }
        public char EndWith() { return str[length - 1]; }
        public char[] Substring(int startIndex, int endIndex)
        {
            // if data in startIndex and endIndex aren't correct
            if (startIndex < 0) startIndex = 0;
            if ((startIndex + endIndex) > length) endIndex = length - startIndex;
            if (endIndex < 0) endIndex = 0;
            //create new string
            int sub_lenght = endIndex;
            char[] sub_string = new char[sub_lenght];
            for (int i = 0; i < sub_lenght; i++)
            {
                sub_string[i] = str[startIndex + i];
            }
            return sub_string;
        }
        public void Remove(int startIndex, int endIndex)
        {
            // if data in startIndex and endIndex aren't correct
            if (startIndex < 0) startIndex = 0;
            if ((startIndex + endIndex) > length) endIndex = length - startIndex;
            if (endIndex < 0) endIndex = 0;
            int temp_lenght = this.length - endIndex;
            char[] temp_string = new char[temp_lenght];
            for (int i = 0, j = 0; i < this.length; i++)
            {
                if (i <startIndex||i>=(startIndex+endIndex))
                {
                    temp_string[j] = this.str[i];
                    j++;
                }

            }
            this.length = temp_lenght;
            this.str = temp_string;
        }
        public void RemoveAll() 
        {
            this.length = 0;
            this.str = new char[this.length];
        }
        public int IndexOf(char[] search)
        {
            int counter = 0;
            for (int i = 0; i <length; i++)
            {
                if (this.str[i] == search[0])
                {
                    for (int j = 0; j < search.Length; j++)
                    {
                        if(this.str[i+j] == search[j]) counter++;
                    }
                }
                if(counter==search.Length) return i;
                counter = 0;
              
            }
            return -1;
        }
        public void Concat(char[] str1, char[] str2)
        {
            int new_lenght = str1.Length + str2.Length;
            char[] new_str = new char[new_lenght];

            for (int i = 0, j=0; i < new_lenght; i++)
            {
                if(i< str1.Length) new_str[i] = str1[i];
                else
                {
                    new_str[i] = str2[j];
                    j++;
                }
            }
            this.str = new_str; 
            this.length = new_lenght;
        }
        public void Concat(char[] str2)
        {
            int new_lenght = this.length + str2.Length;
            char[] new_str = new char[new_lenght];

            for (int i = 0, j = 0; i < new_lenght; i++)
            {
                if (i < this.length) new_str[i] = this.str[i];
                else
                {
                    new_str[i] = str2[j];
                    j++;
                }
            }
            this.str = new_str;
            this.length = new_lenght;
        }
        public void Replace(char[] newValue)
        {
            this.str = newValue;
            this.length = newValue.Length;  
        }
        public void Trim(char ch)
        {
            List<char> temp = new List<char>();
            for (int i = 0; i < this.length; i++)
            {
                if (this.str[i]!=ch) temp.Add(this.str[i]);  
            }
            this.str = temp.ToArray();  
            this.length = this.str.Length;
        }
        public bool CompareTo(char[] str1, char[] str2)
        {
            if(str1.Length != str2.Length) return false;
            else
            {
                for (int i = 0; i<str1.Length; i++)
                {
                    if (str1[i] != str2[i])return false;
                }
                return true;
            } 
        }
        public bool CompareTo(char[] str2)
        {
            if (this.length != str2.Length) return false;
            else
            {
                for (int i = 0; i < this.length; i++)
                {
                    if (this.str[i] != str2[i]) return false;
                }
                return true;
            }
        }

        public override string ToString()
        {
            string str_print = new string(this.str);
            return str_print;
        }
        public static String operator +(String left, String right)
        {
            int new_lenght=left.length + right.length+1;
            char[]new_srt=new char[new_lenght];
            for (int i = 0; i < left.length; i++)
            {
                new_srt[i] = left.str[i];    
            }
            new_srt[left.length] = ' ';
            for (int i = 0; i < right.length; i++)
            {
                new_srt[left.length+1+i] = right.str[i];
            }
            String sum_str = new String(new_srt);
           
            return sum_str;
        }

    }
}
