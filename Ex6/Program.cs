// Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.
//Реализовать подсчёт времени выполнения программы, используя структуру DateTime
DateTime start = DateTime.Now;
int k = 0;
for (int i=1; i < 1000000000; i++ )
{
    int j = i;
    int s = 0;
    while (j > 0)
    {
        s += j % 10;
        j /= 10;
    }
    if (i%s==0)
    {
        k++;
    }

}
Console.WriteLine(k);
DateTime finish = DateTime.Now;
Console.WriteLine(finish - start);