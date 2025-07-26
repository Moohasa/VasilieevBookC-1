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

    // Maydonlar kvadratlari yig'indisini hisoblaydigan metod
    public int SumOfSquares()
    {
        return X * X + Y * Y;
    }

    // Kichikligini tekshirish (operator overload emas)
    public bool IsLessThan(MyClass other)
    {
        return this.SumOfSquares() < other.SumOfSquares();
    }

    // Kattaligini tekshirish (operator overload emas)
    public bool IsGreaterThan(MyClass other)
    {
        return this.SumOfSquares() > other.SumOfSquares();
    }
}

class Program
{
    static void Main()
    {
        MyClass a = new MyClass(3, 4);  // Sum squares = 9 + 16 = 25
        MyClass b = new MyClass(6, 1);  // Sum squares = 36 + 1 = 37

        Console.WriteLine(a.IsLessThan(b));   // True
        Console.WriteLine(a.IsGreaterThan(b)); // False
    }
}
