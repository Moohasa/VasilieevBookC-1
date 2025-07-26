using System;

// Klass e'lon qilinmoqda
class MyClass
{
    private int code;  // Bu — obyektga tegishli yopiq (private) maydon

    // 'get' metodi — code qiymatini qaytaradi
    public int get()
    {
        return this.code;  // 'this.code' — bu obyektning ichidagi maydon
    }

    // 'set' metodi — code qiymatini yangilaydi
    public void set(int code)
    {
        this.code = code;  // 'this.code' — bu maydon, 'code' esa parametr
    }

    // Konstruktor — obyekt yaratilganda ishlaydi
    public MyClass(int code)
    {
        this.code = code;  // Parametr qiymatini obyekt maydoniga saqlayapti
        Console.WriteLine("obyekt yaratildi:  " + this.code);
    }
}

class UsingThisDemo
{
    static void Main()
    {
        // MyClass tipidagi obyekt yaratilmoqda, konstruktor chaqiriladi
        MyClass obj = new MyClass(100);  // Ekranga: obyekt yaratildi: 100

        obj.set(200);  // Obyektning 'code' maydoni endi 200 ga teng bo‘ladi

        Console.WriteLine("yangi qiymat: " + obj.get(100));  // 100 bu yerda faqat argument, ishlatilmayapti
        // chiqadi: yangi qiymat: 200
    }
}
