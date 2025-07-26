using System;

class MyNumber
{
    // Integer tipidagi maydon
    public int Value;

    // Konstruktor: boshlang'ich qiymat berish uchun
    public MyNumber(int value)
    {
        Value = value;
    }

    // + operatorini overload qilish
    // Ikkita MyNumber obyekti qo'shilganda, yangi MyNumber qaytaradi
    public static MyNumber operator +(MyNumber a, MyNumber b)
    {
        // Yangi obyektda Value maydonlari yig'indisi bo'ladi
        return new MyNumber(a.Value + b.Value);
    }

    // - operatori overload qilinadi
    public static MyNumber operator -(MyNumber a, MyNumber b)
    {
        return new MyNumber(a.Value - b.Value);
    }

    // * operatori overload qilinadi
    public static MyNumber operator *(MyNumber a, MyNumber b)
    {
        return new MyNumber(a.Value * b.Value);
    }

    // Qiymatni ko'rsatish uchun qulay metod
    public override string ToString()
    {
        return Value.ToString();
    }
}

class Program
{
    static void Main()
    {
        MyNumber a = new MyNumber(10);
        MyNumber b = new MyNumber(5);

        // += operatori
        a += b;  // aslida a = a + b;
        Console.WriteLine("a += b => " + a);  // 15

        // -= operatori
        a -= b;  // a = a - b;
        Console.WriteLine("a -= b => " + a);  // 10

        // *= operatori
        a *= b;  // a = a * b;
        Console.WriteLine("a *= b => " + a);  // 50
    }
}
