//Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
//Например:
//badc являются перестановкой abcd.
string x =Console.ReadLine();
MyString a= new MyString(x);
string b=Console.ReadLine();
string s = a.A(b);
Console.WriteLine(s);