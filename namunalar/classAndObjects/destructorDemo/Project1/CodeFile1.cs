using System;

class MyClass
{
    private string name;  // Private maydon, faqat shu klass ichida ko‘rinadi

    // Konstruktor: obyekt yaratilganda chaqiriladi
    public MyClass(string txt)
    {
        name = txt;  // name maydoniga qiymat beriladi
        Console.WriteLine("obyekt yaratildi \"{0}\"", name);
    }

    // Destruktor: obyekt xotiradan yo‘q qilinayotganda chaqiriladi
    ~MyClass()
    {
        Console.WriteLine("obyekt o'chirildi \"{0}\"", name);
    }
}

class DestruktorDemo
{
    // Static metod, u ichida yangi MyClass obyektlari yaratiladi, lekin unga havola berilmaydi
    static void maker(string txt)
    {
        new MyClass(txt);
        // Bu yerda obyekt yaratiladi, ammo uni hech qanday o‘zgaruvchiga saqlamayapmiz,
        // demak u qachonki Garbage Collector (GC) ishga tushsa, yo‘q qilinadi.
    }

    static void Main()
    {
        MyClass A = new MyClass("birinchi");
        // Obyekt yaratiladi, "birinchi" nomi bilan, A o‘zgaruvchisiga saqlanadi

        new MyClass("ikkinchi");
        // Yana obyekt yaratiladi, lekin unga havola yo‘q — ya’ni unga hech qanday o‘zgaruvchi bog‘lanmagan.

        A = new MyClass("uchunchi");
        // A o‘zgaruvchisi endi yangi "uchunchi" nomli obyektni ushlab turadi,
        // avvalgi "birinchi" obyekt esa havolasiz qoladi va keyinchalik Garbage Collector tomonidan tozalanishi mumkin

        maker("to'rtinchi");
        // maker metodiga "to'rtinchi" nomli obyekt yaratiladi, unga havola yo‘q,
        // shuning uchun u ham Garbage Collector tomonidan yo‘q qilinishi mumkin.

        A = new MyClass("beshinchi");
        // A yana yangi obyektga bog‘lanadi, oldingi "uchunchi" obyekt havolasiz qoladi
    }
}
