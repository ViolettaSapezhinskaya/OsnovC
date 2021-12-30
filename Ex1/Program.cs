//оздать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) **с использованием регулярных выражений.
using System.Text.RegularExpressions;
using System.Text;


StringBuilder login = new (Console.ReadLine());
StringBuilder text;
text= Check.CheckLogin(login);
Console.WriteLine(text);
