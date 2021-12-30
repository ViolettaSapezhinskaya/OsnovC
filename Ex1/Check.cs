using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Check
{
    //проверка логина без использования регулярных выражений
    static public StringBuilder CheckLogin(StringBuilder login)
    {
        StringBuilder text = new();
        bool flag = true;
        if (login.Length > 10 | login.Length < 2)
        {
            text.Append("Ваш логин неверной длины.");
            flag = false;
        }
        if (Char.IsDigit(login[0]))
        {
            text.Append("Логин не может начинаться с цифры.");
            flag = false;
        }
        if (true)
        {
            for (int i = 0; i < login.Length; i++)
            {
                if (!(Char.IsDigit(login[i]) || login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z'))
                {
                    text.Append("В вашем логине есть некоректные символы.");
                    flag = false;
                    break;
                }
            }
        }
        if (flag)
        {
            text.Append("Ваш логин коректен");
        }
        return text;
    }
}