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

    }
}
