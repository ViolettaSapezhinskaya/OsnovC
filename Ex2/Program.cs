//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
int[] a=new int[5] { 6, 2, 9, 3, 6};
int y = Array.Pair(a);
Console.WriteLine(y);
//б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
string text1 = "C:\\Users\\User\\source\\repos\\OsnovC1\\Ex2\\TextFile01.txt";
int[] b = Array.MyArray(text1);
Console.WriteLine(Array.Print(b));
//в)**Добавьте обработку ситуации отсутствия файла на диске
string text2 = "C:\\Users\\User\\source\\repos\\OsnovC1\\Ex2\\TextFile1.txt";
int[] c = Array.MyArray(text2);
