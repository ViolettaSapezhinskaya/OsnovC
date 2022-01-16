//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
//Использовать массив (или список) делегатов, в котором хранятся различные функции.
//б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).
//Вывод "меню"
Console.WriteLine("Введите число по типу функции:\n" +
    "1 - квадрат числа (x^2)\n" +
    "2 - куб числа (x^3)\n" +
    "3 - синус числа (sin(x))\n" +
    "4 - косинус числа (cos(x))\n" +
    "5 - синус числа умноженный на постоянную переменную (a*sin(x))\n" +
    "6 - косинус числа умноженный на постоянную переменную (a*cos(x))\n" +
    "7 - квадрат числа умноженный на постоянную переменную (a*x^2)\n");
int v = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало числового отрезка");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите конец числового отрезка");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите шаг с которым будут вычисляться переменные");
double h = Convert.ToDouble(Console.ReadLine());
if (v > 4)
{
    Console.WriteLine("Введите постоянную переменную");
    double a = Convert.ToDouble(Console.ReadLine());
}
if (v < 4)
{
    if (v == 1) { WorkFunc.SaveFunc(MyFunc.Sq1, "data.bin", x, b, h); }
    else if (v == 2) { WorkFunc.SaveFunc(MyFunc.cube, "data.bin", x, b, h); }
    else if (v == 3) { WorkFunc.SaveFunc(Math.Sin, "data.bin", x, b, h); }
    else if (v == 4) { WorkFunc.SaveFunc(Math.Cos, "data.bin", x, b, h); }

}
else if (v > 4)
{
    Console.WriteLine("Введите постоянную переменную");
    double a = Convert.ToDouble(Console.ReadLine());
    if (v == 5) { WorkFunc.SaveFunc(MyFunc.Mysin, "data.bin", a, x, b, h); }
    if (v == 6) { WorkFunc.SaveFunc(MyFunc.MyCos, "data.bin", a, x, b, h); }
    if (v == 7) { WorkFunc.SaveFunc(MyFunc.Sq2, "data.bin", a, x, b, h); }

}
else { Console.WriteLine("Вы ввели не корректные данные"); }
//вывод минимума функции
Console.WriteLine(WorkFunc.Load("data.bin"));
Console.ReadKey();