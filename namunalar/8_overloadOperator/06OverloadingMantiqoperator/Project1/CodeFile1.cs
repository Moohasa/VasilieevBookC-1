using System;

class MyClass
{
    public char symb;

    // Konstruktor: obyektga belgini (masalan, 'A') berish
    public MyClass(char s)
    {
        symb = s;
    }

    // 'true' operatorini overload qilish:
    // Bu obyekt 'haqiqat' (true) deb baholanishi uchun belgi unli bo‘lishi kerak
    public static bool operator true(MyClass obj)
    {
        switch (obj.symb)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
            case 'Y':
                return true;  // unli harflar
            default:
                return false; // qolganlar false
        }
    }

    // 'false' operatori: 'true' ga teskari bo‘lishi kerak
    public static bool operator false(MyClass obj)
    {
        // ❓ Savol: Bu false uchun lazeykami?
        // ✅ Ha, lekin bu yerda biroz murakkablashtirilgan:
        //    'Y' harfi garchi true ga kirsa ham, false bo‘lishi mumkin deb olinmoqda.
        //    Bu yerda maxsus holat ko‘rilgan: agar obj — true bo‘lsa, false faqat Y bo‘lsa qaytariladi

        if (obj) // bu demak: operator true(obj)
        {
            return obj.symb == 'Y'; // agar Y bo‘lsa, false qaytariladi
        }
        else
            return true; // qolganlar false hisoblanadi
    }

    // && operatorini overload qilish:
    public static MyClass operator &(MyClass a, MyClass b)
    {
        // Agar birinchi obyekt 'true' bo‘lsa — ikkinchisiga qaraymiz
        if (a)
        {
            return b;
        }
        else
            return a;
    }

    // || operatorini overload qilish:
    public static MyClass operator |(MyClass a, MyClass b)
    {
        // Agar birinchi obyekt 'true' bo‘lsa — uni qaytaramiz
        if (a)
        {
            return a;
        }
        else
            return b;
    }
}

class OverloadingLogOperatorsDemo
{
    static void Main()
    {
        // Obyektlar unli va undosh harflar asosida
        MyClass A = new MyClass('A'); // true
        MyClass B = new MyClass('B'); // false
        MyClass E = new MyClass('E'); // true
        MyClass Y = new MyClass('Y'); // true (lekin false() ham true qaytaradi)

        // && operatorlari (va)
        Console.WriteLine("A&&B  taqqoslash natijasi:   {0}", (A && B).symb);
        // A = true, B = false => A true => qaytadi B

        Console.WriteLine("B&&A  taqqoslash natijasi:   {0}", (B && A).symb);
        // B = false => qaytadi B

        Console.WriteLine("A&&E  taqqoslash natijasi:   {0}", (A && E).symb);
        // A = true => qaytadi E

        Console.WriteLine("E&&A  taqqoslash natijasi:   {0}", (E && A).symb);
        // E = true => qaytadi A

        Console.WriteLine("A&&Y  taqqoslash natijasi:   {0}", (A && Y).symb);
        // A = true => qaytadi Y

        Console.WriteLine("Y&&A  taqqoslash natijasi:   {0}", (Y && A).symb);
        // Y = true => qaytadi A

        // || operatorlari (yoki)
        Console.WriteLine("A||B  taqqoslash natijasi:   {0}", (A || B).symb);
        // A = true => qaytadi A

        Console.WriteLine("B||A  taqqoslash natijasi:   {0}", (B || A).symb);
        // B = false => qaytadi A

        Console.WriteLine("A||E  taqqoslash natijasi:   {0}", (A || E).symb);
        // A = true => qaytadi A

        Console.WriteLine("E||A  taqqoslash natijasi:   {0}", (E || A).symb);
        // E = true => qaytadi E

        Console.WriteLine("A||Y  taqqoslash natijasi:   {0}", (A || Y).symb);
        // A = true => qaytadi A

        Console.WriteLine("Y||A  taqqoslash natijasi:   {0}", (Y || A).symb);
        // Y = true => qaytadi Y
    }
}
