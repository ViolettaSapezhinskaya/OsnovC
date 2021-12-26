class Array
{
    //вывести количество пар элементов массива, в которых только одно число делится на 3
    static public int Pair(int[] a)
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
    //вывести массив из текстового файла
    static public int[] MyArray(string path)
    {
        int[] a = new int[1];
        try
        {
            StreamReader sr = new StreamReader(path);
            int n = int.Parse(sr.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(sr.ReadLine());
                a[i] = b;
            }
        }
        catch
        {
            Console.WriteLine("Что-то пошло не так");
        }
        return a;
    }
    //вывод массива
    static public string Print(int[] a)
    {
        string s = "";
        for (int i = 0; i < a.Length; i++)
        {
            s += a[i].ToString();
            s += ";";
        }
        return s;
    }
    //заполнение массива рандомными значениями
    public Array(int[]a,int n, int min, int max)
    {
        a = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
            a[i] = rnd.Next(min, max);

    }
    //массив определенного размера и заполненный числами от начального значения с заданным шагом
    static public int[] Completion(int n, int min, int k)
    {
        int[]a= new int[n];
        for (int i=0; i < n; i++)
        {
            a[i] = min;
            min += k;
        }
        return a;
    }
    //Сумма элементов массива
    static public int Sum(int[]a)
    {
        int s = 0;
        for (int i = 0;i < a.Length;i++)
        {
            s+=a[i];
        }
        return s;
    }
    //массив с измененными знаками у всех элементов массива (старый массив, остается без изменений)
    static public int[] Inverse(int[]a)
    {
        int[] b=new int[a.Length];
        for (int i = 0; a.Length > i; i++)
        {
            b[i]=-a[i];
        }
        return b;
    }
    //метод Multi, умножающий каждый элемент массива на определённое число
    static public int[] Multi(int[]a,int n)
    {
        for (int i = 0; i<a.Length; i++)
        {
            a[i] = a[i] * n;
        }
        return a;
    }
    //количество максимальных элементов
    static public int MaxCount(int[]a)
    {
        int max = a[0];
        int k=0;
        for (int j=1; j<a.Length; j++)
        {
            if (a[j] > max)
            {
                max = a[j];
            }
        }
        for (int j = 0; j < a.Length; j++)
        {
            if (a[j]==max)
            {
                k++;
            }
        }

            return k;
    }
}
