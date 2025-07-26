using System;

// Klass e'lon qilinyapti
class MyClass
{
    // Bu yerda ikkita maydon (field) e'lon qilingan, ular private
    // Faqat shu klass ichidagina foydalanish mumkin
    private int number;
    private char symbol;

    // obyektning hozirgi qiymatlarini ekranga chiqaruvchi metod
    public void show()
    {
        Console.WriteLine("Obyekt maydoni: " + number + " va " + symbol);
    }

    // 1. Versiya: 2 ta parametr oladigan metod - number va symbol ni o'rnatadi
    public void set(int n, char c)
    {
        number = n;
        symbol = c;
    }

    // 2. Versiya: faqat int parametr qabul qiladi, lekin bu yerda xatolik bor
    public void set(int n)
    {
        number = n; // bu yerda xatolik bor, aslida: number = n; bo‘lishi kerak
        symbol = 'B';
    }

    // 3. Versiya: parametrsiz versiya, ichida birinchi versiyani chaqiryapti
    public void set()
    {
        set(100, 'A'); // yuqoridagi 2 parametrli `set` metodini chaqiryapti
    }
}

class MethodDemo
{
    static void Main()
    {
        MyClass obj = new MyClass();  // obyekt yaratildi

        obj.set();   // 3-versiya: set() chaqirildi → number = 100, symbol = 'A'
        obj.show();  // natija: 100 va A

        obj.set(200); // 2-versiya chaqirildi, lekin `number = number;` bo'lgani uchun o'zgarish bo'lmaydi
        obj.show();   // natija: 200 va B

        obj.set(300, 'C'); // 1-versiya chaqirildi → number = 300, symbol = 'C'
        obj.show();        // natija: 300 va C
    }
}
