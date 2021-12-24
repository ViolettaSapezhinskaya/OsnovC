class Array
{
    public int[] a;
    //заполнение массива рандомными значениями
    public Array(int n, int min, int max)
    {
        a = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
            a[i] = rnd.Next(min, max);

    }
    //вывод массива
    public override string ToString()
    {
        string s = "";
        for (int i = 0; i < a.Length; i++)
        {
            s += a[i].ToString();
            s += ";";
        }
        return s;
    }
    // вывести количество пар элементов массива, в которых только одно число делится на 3
    public int Pair()
    {
        int x = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] % 3 == 0)
            {
                if (a[i + 1] % 3 != 0)
                    //{
                    x++;
            }
    
            else
        {
            if (a[i + 1] % 3 == 0)
            {
                x++;
            }
        }
    }
        return x;
    }

  }
