using System;

  // Konsolga yozuv chiqarish uchun kerakli kutubxona

// Klass e'lon qilinyapti
class MyClass
{
    // static maydon (field): bu klass darajasida umumiy qiymat
    public static int code = 100;

    // static metod: bu ham klassga tegishli bo‘ladi, obyektga emas
    public static void show()
    {
        // static metod ichida static maydon ishlatilmoqda
        Console.WriteLine("Statik maydon: " + code);
    }
}

// Asosiy klass, bu yerda dastur bajariladi
class StaticDemo
{
    // Main metodi — dastur kirish nuqtasi
    static void Main()
    {
        // 1. Klass nomi orqali static metod chaqirilyapti
        // Obyekt yaratmasdan to'g'ridan-to'g'ri ishlatish mumkin
        MyClass.show();  // Natija: Statik maydon: 100

        // 2. Static maydonning qiymatini o‘zgartirayapmiz
        MyClass.code = 200;

        // 3. Yana static metodni chaqiryapmiz, endi u yangi qiymatni chiqaradi
        MyClass.show();  // Natija: Statik maydon: 200
    }
}
