using System;

class MyClass
{
    public int x;
    public int y;

    // Argumentsiz konstruktor
    public MyClass()
    {
        x = 0;
        y = 0;
        Console.WriteLine("Argumentsiz konstruktor chaqirildi: x=0, y=0");
    }

    // Bir argumentli konstruktor
    public MyClass(int a)
    {
        x = a;
        y = 0;
        Console.WriteLine($"Bir argumentli konstruktor chaqirildi: x={x}, y=0");
    }

    // Ikki argumentli konstruktor
    public MyClass(int a, int b)
    {
        x = a;
        y = b;
        Console.WriteLine($"Ikki argumentli konstruktor chaqirildi: x={x}, y={y}");
    }
}

class Program
{
    static void Main()
    {
        MyClass obj1 = new MyClass();
        MyClass obj2 = new MyClass(10);
        MyClass obj3 = new MyClass(20, 30);
    }
}
