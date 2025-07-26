using System;

class MyClass
{
    public int alpha;  // Obyektning ochiq (public) maydoni
    public int bravo;  // Obyektning ochiq (public) maydoni

    // Bitta parametrli konstruktor
    public MyClass(int a)
    {
        alpha = a;       // alpha maydoniga a qiymatini beramiz
        bravo = alpha;   // bravo maydoniga alpha ning qiymatini beramiz (ya'ni a ni)

        Console.WriteLine("ikki maydon teng " + alpha + "ga");  // Konsolga chiqaramiz
    }

    // Ikki parametrli konstruktor, this(a) bilan bitta parametrli konstruktor chaqiriladi
    public MyClass(int a, int b) : this(a)
    {
        Console.WriteLine("ikki argumentli konstruktor");
        bravo = b;   // bravo maydoniga b qiymatini beramiz (oldingi qiymat ustiga yoziladi)
        Console.WriteLine(alpha + " va " + bravo + " maydoni");
    }

    // Argumentsiz konstruktor, this(400, 500) bilan ikki parametrli konstruktor chaqiriladi
    public MyClass() : this(400, 500)
    {
        Console.WriteLine("argumentsiz konstruktor");
        Console.WriteLine(alpha + " va " + bravo + " qiymati");
    }
}

class ConstrAndThisDemo
{
    static void Main()
    {
        MyClass A = new MyClass(100);         // Bitta argumentli konstruktor ishlaydi
        Console.WriteLine();

        MyClass B = new MyClass(200, 300);    // Ikki argumentli konstruktor ishlaydi (ichida bitta argumentli chaqiriladi)
        Console.WriteLine();

        MyClass C = new MyClass();             // Argumentsiz konstruktor ishlaydi (ichida ikki argumentli va bitta argumentli konstruktorlar chaqiriladi)
    }
}
