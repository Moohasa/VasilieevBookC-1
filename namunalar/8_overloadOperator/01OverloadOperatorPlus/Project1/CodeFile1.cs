using System;

// Oddiy sinf yaratamiz
class MyClass
{
    // Sinfda int tipidagi maydon (field)
    public int number;

    // Konstruktor: sinf obyekti yaratilganda 'number' maydonini qiymat bilan to'ldiradi
    public MyClass(int n)
    {
        number = n;
    }

    // Operator + ni overload qilish
    // Bu metod ikkita MyClass obyekti qabul qiladi (a va b)
    // va ularning 'number' maydonlarini qo'shib, int natija qaytaradi
    public static int operator +(MyClass a, MyClass b)
    {
        int m = a.number + b.number; // a.number va b.number ni qo'shamiz
        return m;                    // natijani qaytaramiz
    }
}

// Boshqa sinf, bunda dastur bajariladi
class OverLoadinigOperatorQushish
{
    static void Main()
    {
        // MyClass tipida ikkita obyekt yaratamiz, ularga 100 va 200 qiymat beramiz
        MyClass A = new MyClass(100);
        MyClass B = new MyClass(200);

        // Natijani saqlash uchun int tipidagi o'zgaruvchi
        int num;

        // Operator + chaqiriladi: A.number + B.number
        num = A + B;

        // Natijani ekranga chiqaramiz: A+B=300
        Console.WriteLine("A+B=" + num);
    }
}
