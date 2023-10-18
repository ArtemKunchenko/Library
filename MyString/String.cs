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


        public override string ToString()
        {
            string str_print = new string(this.str);
            return str_print;
        }
    }
}
