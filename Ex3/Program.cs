//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
int c = 0;
while (true)
{
    int a = 1;
    while (a!=0)
    {
        a = Convert.ToInt32(Console.ReadLine());
        if (a>0 && a%2==1)
        {
            c += a;
        }
    }
    break;
}
Console.WriteLine(c);
//Дописать