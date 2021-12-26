//Написать метод, возвращающий минимальное из трёх чисел.
void Met(int x, int y, int z)
{
    int min = x;
    if (min > y)
    {
        min = y;
    }
    if (min > z)
    {
        min = z;
    }
    Console.WriteLine($"Минимальное число {min}");

}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Met(a, b, c);
