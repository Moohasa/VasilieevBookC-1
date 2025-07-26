using System;

class MyRange
{
    // Max va min maydonlari private, tashqaridan bevosita kira olmaymiz
    private int max;
    private int min;

    // Konstruktor — parametrlarga qarab maydonlarni belgilaydi
    // Bitta argument bilan chaqirilsa, ikkala maydon ham bir xil qiymatga teng bo'ladi
    // Ikki argument bilan chaqirilsa, ularning kattasi max, kichigi min bo'ladi
    public MyRange(int a = 0, int b = 0)
    {
        SetValues(a, b);
    }

    // Maydonlarga qiymat beruvchi metod — 1 yoki 2 argument bilan chaqirilishi mumkin
    public void SetValues(int a)
    {
        // Bitta qiymat berilganda ikkala maydon teng bo'ladi
        max = min = a;
    }

    public void SetValues(int a, int b)
    {
        // Ikki qiymat berilganda kattasi max, kichigi min bo'ladi
        if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }
    }

    // Maydonlar qiymatini chiqaruvchi metod
    public void Display()
    {
        Console.WriteLine($"min = {min}, max = {max}");
    }
}

class Program
{
    static void Main()
    {
        // Misol uchun turli holatlarda obyekt yaratamiz va metodni chaqiramiz
        MyRange r1 = new MyRange();
        r1.Display();  // min=0, max=0 (default qiymatlar)

        MyRange r2 = new MyRange(10);
        r2.Display();  // min=10, max=10

        MyRange r3 = new MyRange(20, 5);
        r3.Display();  // min=5, max=20

        MyRange r4 = new MyRange(3, 15);
        r4.Display();  // min=3, max=15

        // Maydonlarni keyinchalik o'zgartirish
        r4.SetValues(30);
        r4.Display();  // min=30, max=30

        r4.SetValues(25, 100);
        r4.Display();  // min=25, max=100
    }
}
