namespace MyString
{
    public class String
    {
        public char[] str { get; set; }
        public int length { get; }
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
            if((startIndex+endIndex)>length) endIndex = length-startIndex;
            if (endIndex < 0) endIndex = 0;
            //create new string
            int sub_lenght = endIndex;
            char[] sub_string= new char[sub_lenght];
            for (int i = 0; i < sub_lenght; i++)
            {
                sub_string[i] = str[startIndex + i];
            }
            return sub_string;
        }


        public override string ToString()
        {
            string str_print=new string(this.str);
            return str_print;
        }
    }
}
