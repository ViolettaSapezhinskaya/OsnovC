//С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse
int a;
int result=0;
bool flag = false;
do
{
    do
    {
        Console.Write($"Введите число: ");
        flag = int.TryParse(Console.ReadLine(), out a);
    } while (!flag);
    if (a % 2 != 0)
    {
        result += a;
    }
} while (a!=0);
Console.WriteLine(result);



