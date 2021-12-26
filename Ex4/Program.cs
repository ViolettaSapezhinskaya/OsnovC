//Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
//С помощью цикла do while ограничить ввод пароля тремя попытками.

//метод проверки логина и пароля
void Check(string[,] a)
{
    string sms = "";
    int i = 0;
    while (i < 9)
    { 
        string log = Console.ReadLine();
        string pas = Console.ReadLine();
        for (int j = 0; j < a.GetLength(1); j++)
        { 
            if (log == a[0,j] && pas ==a [1,j] )
            {
                sms=("Поздравляю, вы вошли в систему");
                i+=9 ;
            }
            else
            {
                sms = ("К сожелению пароль или логин введены не правильно");
                i++;
            }
        }
        Console.WriteLine(sms);
    }
}

//метод считывающий логины и пароли
string[,] LogPas(string text)
{
    StreamReader sr = new StreamReader(text);
    int n = int.Parse(sr.ReadLine());
    string[,] a = new string[2,n];
    for (int i = 0; i < n; i++)
    {
        string log = sr.ReadLine();
        a[0,i] = log;
        string pas = sr.ReadLine(); 
        a[1,i] = pas;
    }
    return a;
}
string text = "C:\\Users\\User\\source\\repos\\OsnovC1\\Ex4\\TextFile1.txt";
string[,] p = LogPas(text);
Check(p);

