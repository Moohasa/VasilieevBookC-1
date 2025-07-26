using System;

// MyClass nomli klass e'lon qilinyapti
class MyClass
{
    // Klassning ikkita ommaviy maydoni (public)
    public int first;
    public int last;

    // Konstruktor: obyekt yaratishda boshlang‘ich qiymatlarni oladi
    public MyClass(int a, int b)
    {
        first = a;
        last = b;
    }

    // Faqat o'qish mumkin bo'lgan xossa (read-only property)
    // U 'first' va 'last' maydonlarining yig'indisini qaytaradi
    public int sum
    {
        get
        {
            return first + last;
        }
        // ❌ set aksessori yo‘q — demak bu xossani faqat o‘qib bo‘ladi, yozib bo‘lmaydi
    }
}

// Asosiy klass — dastur shu yerdan boshlanadi
class WithOutSet
{
    static void Main()
    {
        // MyClass obyektini yaratamiz: first = 1, last = 9
        MyClass obj = new MyClass(1, 9);

        // sum xossasini chaqiramiz — 1 + 9 = 10
        Console.WriteLine("Obyektlar yig'indisi: " + obj.sum);

        // first maydonini 6 ga o‘zgartiramiz (public bo‘lgani uchun ruxsat)
        obj.first = 6;

        // sum yana chaqiriladi: 6 + 9 = 15
        Console.WriteLine("Obyektlar yig'indisi: " + obj.sum);

        // endi last maydoni 2 ga o‘zgartiriladi
        obj.last = 2;

        // sum chaqiriladi: 6 + 2 = 8
        Console.WriteLine("Obyektlar yig'indisi: " + obj.sum);
    }
}
