//оздать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) **с использованием регулярных выражений.
using System.Text.RegularExpressions;
using System.Text;



//проверка логина без использования регулярных выражений
StringBuilder CheckLogin(StringBuilder login)
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

StringBuilder login = new(Console.ReadLine());
StringBuilder text;
text= CheckLogin(login);
Console.WriteLine(text);
