struct Complecs
{
    public int a, b;
    //само число
    public Complecs(int im, int re)
    {
        this.a = im;
        this.b = re;
    }
    //вывод числа
    public override string ToString()
    {
        string s;
        if (b < 0) s = $"{a} - {-b}i";
        else s = $"{a} + {b}i";
        return s;
    }
    //сумма
    public static Complecs operator +(Complecs z1, Complecs z2)
    {
        Complecs result;
        result = new Complecs(z2.a + z1.a, z2.b + z1.b);
        return result;
    }
    //вычитание
    public static Complecs operator -(Complecs z1, Complecs z2)
    {
        Complecs result;
        result = new Complecs(z1.a - z2.a, z1.b - z2.b);
        return result;
    }
    //произведение
    public static Complecs operator *(Complecs z1, Complecs z2)
    {
        Complecs result;
        result = new Complecs(z1.a * z2.a - z1.b * z2.b, z1.b * z2.a + z1.a * z2.b);
        return result;
    }
} 