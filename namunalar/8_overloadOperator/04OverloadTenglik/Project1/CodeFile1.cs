using System;

// A klass
class A
{
    public int code;
    public A(int n)
    {
        code = n;
    }
}

// B klass
class B
{
    public int code;
    public B(int n)
    {
        code = n;
    }

    // B klassdagi obyektlar uchun == operatorini overload qilayapmiz
    public static bool operator ==(B a, B b)
    {
        return a.code == b.code; // faqat qiymatlar tengligini tekshiryapti (obyekt manzili emas)
    }

    // != operatori == dan foydalanib ishlayapti
    public static bool operator !=(B a, B b)
    {
        return !(a == b); // ya'ni, teng emaslik = tenglik emas
    }
}

// Demo klass
class OverloadimgEqvOperatorsDemo
{
    static void Main()
    {
        // A klassidan uchta obyekt
        A A1 = new A(100);
        A A2 = new A(100);
        A A3 = new A(300);

        // A klassida == overload qilinmagan => reference solishtiradi
        Console.WriteLine("A1==A2 natijasi:  {0}", A1 == A2); // False
        Console.WriteLine("A1!=A2 natijasi:  {0}", A1 != A2); // True
        Console.WriteLine("A1==A3 natijasi:  {0}", A1 == A3); // False
        Console.WriteLine("A1!=A3 natijasi:  {0}", A1 != A3); // True

        // B klassidan uchta obyekt
        B B1 = new B(100);
        B B2 = new B(100);
        B B3 = new B(200);

        // B klassida == va != overload qilingan => qiymatga qarab taqqoslaydi
        Console.WriteLine("B1==B2 natijasi:  {0}", B1 == B2); // True
        Console.WriteLine("B1!=B2 natijasi:  {0}", B1 != B2); // False
        Console.WriteLine("B1==B3 natijasi:  {0}", B1 == B3); // False
        Console.WriteLine("B1!=B3 natijasi:  {0}", B1 != B3); // True
    }
}
