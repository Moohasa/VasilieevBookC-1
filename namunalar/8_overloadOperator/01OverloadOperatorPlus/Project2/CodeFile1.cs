using System;

// MyClass sinfi
class MyClass
{
    public int number;  // Obyektning asosiy qiymati

    // Konstruktor: obyekt yaratilganda qiymat berish
    public MyClass(int n)
    {
        number = n;
    }

    // ToString() — obyektni string ko‘rinishda chiqarish
    public override string ToString()
    {
        return "number obyekti: " + number;
    }

    // MyClass + MyClass operatori
    public static MyClass operator +(MyClass a, MyClass b)
    {
        int m = a.number + b.number;         // ikkita obyektning number maydonini qo‘shamiz
        MyClass t = new MyClass(m);          // yangi obyekt yaratib, natijani unga joylaymiz
        return t;                            // natijani qaytaramiz
    }

    // MyClass + int operatori
    public static MyClass operator +(MyClass a, int x)
    {
        int m = a.number + x;                // obyektning number maydoniga int qo‘shiladi
        return new MyClass(m);               // yangi obyekt qaytariladi
    }

    // int + MyClass operatori — bu yuqoridagining teskarisi
    public static MyClass operator +(int x, MyClass a)
    {
        return a + x;  // oldingi operatorni qayta ishlatish
    }

    // +MyClass — unar operator (bitta operandli)
    public static int operator +(MyClass a)
    {
        return a.number; // obyektni int ga aylantiradi
    }
}

// Demo sinf
class MoreOverloadingOperatorPlusDemo
{
    static void Main()
    {
        // Ikki obyekt yaratamiz
        MyClass A = new MyClass(100);
        MyClass B = new MyClass(200);

        // A + B: MyClass + MyClass ishlaydi
        MyClass C = A + B;

        // A, B va C obyektlarini ekranga chiqaramiz
        Console.WriteLine(A);  // number obyekti: 100
        Console.WriteLine(B);  // number obyekti: 200
        Console.WriteLine(C);  // number obyekti: 300

        // A + 1: MyClass + int operatori ishlaydi
        C = A + 1;
        Console.WriteLine(C);  // number obyekti: 101

        // 10 + A: int + MyClass operatori ishlaydi
        C = 10 + A;
        Console.WriteLine(C);  // number obyekti: 110

        // +C: unar operator chaqiriladi — MyClass → int (number qiymati)
        Console.Write("unar operator:   ");
        Console.WriteLine(+C);  // 110

        // (+A) + (+B): har biri int ga aylantirilib qo‘shiladi
        int num = (+A) + (+B);  // 100 + 200 = 300
        Console.WriteLine(num); // 300
    }
}
