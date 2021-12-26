//Написать метод подсчета количества цифр числа.
string a = Console.ReadLine();
int k = 0;
for (int i=0;i<a.Length;i++)
{
    if (a[i] != ',')
    {
        k++;
    }
}
Console.WriteLine(k);
