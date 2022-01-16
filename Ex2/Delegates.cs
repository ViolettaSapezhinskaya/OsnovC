class MyAction
{
    //делегат тип 1
    public delegate double Fun1(double x);
    //делегат тип 2
    public delegate double Fun2(double x, double a);
}
class WorkFunc
{
    //тип 1
    public static void SaveFunc(MyAction.Fun1 F, string fileName, double x, double b, double h )
    {
        FileStream fs= new FileStream(fileName, FileMode.Create, FileAccess.Write);
        BinaryWriter bw= new BinaryWriter(fs);
        while(x<=b)
        {
           bw.Write(F(x));
           x += h;
        }
        bw.Close();
        fs.Close();
    }
    //тип 2
    public static void SaveFunc(MyAction.Fun2 F,string fileName, double a,double x, double b, double h)
    {
        FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        while (x <= b)
        {
            bw.Write(F(a,x));
            x += h;
        }
        bw.Close();
        fs.Close();
    }
    public static double Load(string fileName)
    {
        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        BinaryReader bw = new BinaryReader(fs);
        double min = double.MaxValue;
        double d;
        for (int i = 0; i < fs.Length / sizeof(double); i++)
        {
            // Считываем значение и переходим к следующему
            d = bw.ReadDouble();
            if (d < min) min = d;
        }
        bw.Close();
        fs.Close();
        return min;
    }

}