using System;

class MyClass
{
    public int X;
    public int Y;

    public MyClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Maydonlar kvadratlari yig'indisi
    private int SumOfSquares()
    {
        return X * X + Y * Y;
    }

    // Operator < overload: solishtirish uchun
    public static bool operator <(MyClass a, MyClass b)
    {
        return a.SumOfSquares() < b.SumOfSquares();
    }

    // Operator > overload: solishtirish uchun
    public static bool operator >(MyClass a, MyClass b)
    {
        return a.SumOfSquares() > b.SumOfSquares();
    }

    // Agar < va > overload qilinsa, odatda <= va >= ni ham qilish tavsiya etiladi,
    // lekin topshiriqda ular kerak emas
}

class Program
{
    static void Main()
    {
        MyClass a = new MyClass(3, 4);  // 3²+4²=25
        MyClass b = new MyClass(6, 1);  // 6²+1²=37

        // Operatorlar yordamida solishtirish
        Console.WriteLine(a < b);   // True, chunki 25 < 37
        Console.WriteLine(a > b);   // False, chunki 25 > 37 emas
    }
}
