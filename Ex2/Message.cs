class Message
{
    //Вывести только те слова сообщения, которые содержат не более n букв.
    static public string[] wordsN(string text, int n)
    {
        string[] t = text.Split(" ");
        int k = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i].Length == n)
            { k++; }
        }
        string[] words = new string[k];
        k = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i].Length == n)
            { 
                words[k++] = t[i];
            }
        }
        return words;
    }
    //вывод массива
    static public string Print(string[] a)
    {
        string s = "";
        for (int i = 0; i < a.Length; i++)
        {
            s += a[i].ToString();
            s += " ";
        }
        return s;
    }
    //Удалить из сообщения все слова, которые заканчиваются на заданный символ
    static public string removal(string text, char n)
    {
        string[] t = text.Split(" ");
        string[] s = new string[t.Length];
        for (int i = 0;i < t.Length; i++)
        {
            char[] c = t[i].ToCharArray();
            if (char.IsPunctuation(c[c.Length - 1]))
            {
                if (c.Length > 2)
                {
                    if (c[c.Length - 2] != n)
                    {
                        s[i] = t[i] + ' ';
                    }
                }

            }
            else
            {
                if (c[c.Length - 1] != n)
                {
                    s[i] = t[i] + ' ';
                }
            }
        }
        string text2 = String.Concat(s);
        return text2;
    }
    //Найти самое длинное слово сообщения
    static public string wordmax(string text)
    {
        string word=" ";
        string[] t = text.Split(" ");
        int max = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i].Length>max)
            {
                max = t[i].Length;
                word= t[i];
            }
        }
        return word;
    }

}