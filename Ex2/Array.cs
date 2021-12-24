class Array
{
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
    static public int[] MyArray(string path)
    {
        StreamReader sr = new StreamReader(path);
        int n = int.Parse(sr.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            int b = int.Parse(sr.ReadLine());
            a[i] = b;
        }
        return a;
    }
}
