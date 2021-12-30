using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;

class Proga
{
    static public void Start()
    {
        //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        //а) Вывести только те слова сообщения, которые содержат не более n букв.
        Message text = new Message(@"Здесь должен быть какой-то текст. Вставляю текст из методички для примера. 
Обработка текстовой информации — одна из самых распространённых задач современного программирования . 
С# предоставляет для её решения широкий набор средств: 
символы char, неизменяемые строки string, изменяемые строки StringBuider и регулярные выражения Regex. 
В данном разделе мы рассмотрим работу с символами, неизменяемыми и изменяемыми строками.");
        string[] w = text.wordsN(5);
        Console.WriteLine($"а) {String.Join(' ', w)}");

        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        string text2 = text.removal('т');
        Console.WriteLine($"б) {text2}");
        //в) Найти самое длинное слово сообщения.
        string word = text.wordmax();
        Console.WriteLine($"в) {word}");
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        StringBuilder sb = new StringBuilder();
        sb = text.Long();
        Console.WriteLine($"г){sb}");


    }
}
