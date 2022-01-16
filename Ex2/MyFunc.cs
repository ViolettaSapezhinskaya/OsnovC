class MyFunc
{
    MyFunc F=new MyFunc();
    //тип делегата 1
    public static double Sq1 (double x) { return x*x; }
    public static double cube (double x) { return x*x*x; }   
    //тип делегата 2
    public static double Mysin(double a, double x) { return a*Math.Sin(x); }
    public static double MyCos( double a, double x) { return a * Math.Cos(x); }
    public static double Sq2(double a, double x) { return a * (x * x); }
}