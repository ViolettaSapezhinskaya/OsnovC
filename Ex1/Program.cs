//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
//Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

using System;
//функция MyFunc
Console.WriteLine("Таблица функции a*x^2:");
Func.Table(new Fun(Func.MyFunc),2, -2, 2);
//функция MyFunc2
Console.WriteLine("Таблица функции a*sin(x):");
Func.Table(Func.MyFunc2,2, -2, 2);
