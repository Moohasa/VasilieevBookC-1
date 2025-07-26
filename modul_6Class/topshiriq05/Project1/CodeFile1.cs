using System;

class MyClass
{
    // Private maydon
    private int value;

    // Konstruktor, argumentli va argumentsiz chaqirilishi mumkin
    public MyClass(int val = 0)  // default qiymat 0
    {
        SetValue(val);  // qiymatni o'rnatish uchun umumiy metodni chaqiramiz
    }

    // Qiymatni o'rnatish uchun metod, overload qilib argumentsiz versiya ham
    public void SetValue()
    {
        value = 0; // argumentsiz chaqirilsa, 0 ni o'rnatamiz
    }

    public void SetValue(int val)
    {
        if (val > 100)
            value = 100;
        else
            value = val;
    }

    // Qiymatni olish uchun metod
    public int GetValue()
    {
        return value;
    }
}

class Program
{
    static void Main()
    {
        MyClass obj1 = new MyClass();  // argumentsiz konstruktor, value = 0
        Console.WriteLine("obj1 qiymati: " + obj1.GetValue());

        MyClass obj2 = new MyClass(50);  // konstruktor orqali 50 ni o'rnatamiz
        Console.WriteLine("obj2 qiymati: " + obj2.GetValue());

        MyClass obj3 = new MyClass(150);  // 150 > 100, shuning uchun value=100 bo'ladi
        Console.WriteLine("obj3 qiymati: " + obj3.GetValue());

        // SetValue metodining turli chaqiriqlari
        obj1.SetValue(75);
        Console.WriteLine("obj1 yangi qiymati: " + obj1.GetValue());

        obj1.SetValue(120);
        Console.WriteLine("obj1 qiymati 120 berilganda: " + obj1.GetValue());

        obj1.SetValue();
        Console.WriteLine("obj1 argumentsiz SetValue chaqirilganda: " + obj1.GetValue());
    }
}
