using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyString
{
    string a;
    public MyString(string a)
    {
        this.a = a;
    }
    public override string ToString()
    {
        return a;
    }
    //сортировка строка
    public string Sorting()
    {
        string text="";
        char[] c = a.ToCharArray();

   
        var orderedNumbers = from i in c
                             orderby i
                             select i;
        foreach (int i in orderedNumbers)
            text += i;
        return text;
    }
    public string A (string b)
    {
        string s;
        MyString text1 = new MyString(a);
        MyString text2 = new MyString(b);
        string s1 = text1.Sorting();
        string s2 = text2.Sorting();
        if (s1 == s2)
        {
            s =$"Строка {a} явлеятся перестановкой строки {b}";
        }
        else
        {
            s =$"Строка {a} не является перестановкой строки {b}";
        }
        return s;
    }
        


}