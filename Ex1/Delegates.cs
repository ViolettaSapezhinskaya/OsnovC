//создаем делегат
public delegate double Fun(double x, double a);
class Func
{ 
    //создание таблицы
    public static void Table(Fun F, double a, double x, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    // сами функции
    public static double MyFunc(double x, double a)
    {
        return a * (x * x);
    }
    public static double MyFunc2(double x, double a)
    {
        return a * Math.Sin(x);
    }
}