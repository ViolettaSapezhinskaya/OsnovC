// Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
// *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
Console.Write("Введите свой вес:");
string ma = Console.ReadLine();
double m = Convert.ToDouble(ma);
Console.Write("Введите свой рост:");
string ha = Console.ReadLine();
double h = Convert.ToDouble(ha) / 100;
double h2 = h * h;
double I = m / (h2);
if (I < 18.5)
{
    Console.WriteLine("Ваш вес ниже нормы");
    double x= 18.5 * h2;
    x -= m;
    Console.WriteLine($"Вам нужно набрать {x:F} кг, чтобы ваш ИМТ был в норме");
}
else if (I > 25)
{
    Console.WriteLine("Ваш вес выше нормы");
    double x = 25 * h2;
    m -= x;
    Console.WriteLine($"Вам нужно скинуть {m:F} кг, чтобы ваш ИМТ был в норме");
}
else
{
    Console.WriteLine("Ваш вес в норме");
}