
using System.Text;



class Message
{
    public string text;
    public Message(string t)
    {
        text = new string(t);
    }
    //Вывести только те слова сообщения, которые содержат не более n букв.
    public string[] wordsN( int n)
    {
        string[] t = text.Split(" ");
        int k = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i].Length <= n)
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
  
    //Удалить из сообщения все слова, которые заканчиваются на заданный символ
     public string removal( char n)
    {
        string[] t = text.Split(" ");
        string[] s = new string[t.Length];
        for (int i = 0;i < t.Length; i++)
        {
            if (t[i].EndsWith(n))
            {
                s[i] = t[i] + ' ';
            }
        }
        string text2 = String.Concat(s);
        return text2;
    }
    //Найти самое длинное слово сообщения
     public string wordmax()
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
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    public StringBuilder Long()
    {
        string [] t = text.Split(" ");
        StringBuilder sb = new StringBuilder();
        int max = 0;
        for (int i=0; i < t.Length; i++)
        {
            if (t[i].Length>max)
            {
                max=t[i].Length;
            }

        }
        for (int i = 0; i < t.Length; i++)
        {
            if(t[i].Length==max)
            {
                sb.Append($"{t[i]} ");
            }
        }

            return sb;
    }

}