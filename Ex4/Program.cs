﻿//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.
string login = "root";
string password = "GeekBrains";
string log=Console.ReadLine();
string pas=Console.ReadLine();
if (login==log && password==pas)
{
    Console.WriteLine("Поздравляю, вы вошли в систему");
}
else
{
    Console.WriteLine("К сожеления пароль или логин введены не правильно");
}