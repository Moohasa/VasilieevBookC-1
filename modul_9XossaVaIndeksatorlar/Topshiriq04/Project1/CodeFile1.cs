using System;

class MyClass
{
    // Yopiq butun sonli maydon — foydalanuvchi kiritgan son shu yerda saqlanadi
    private int number;

    // Yopiq matnli maydon — kiritilgan sonning sakkizlik (octal) ko‘rinishi shu yerda saqlanadi
    private string octalCode;

    // Konstruktor: yangi obyekt yaratilganda son qabul qiladi va Number property orqali o‘rnatadi
    public MyClass(int n)
    {
        Number = n; // shu orqali number va octalCode bir vaqtda o‘rnatiladi
    }

    // Yordamchi metod: Butun sonni sakkizlik sanoq sistemasiga o‘giradi
    private string ToOctal(int n)
    {
        if (n == 0)
            return "0"; // 0 ga alohida holat

        string result = "";

        while (n > 0)
        {
            int qoldiq = n % 8;         // 8 ga bo‘lgandagi qoldiqni olamiz
            result = qoldiq + result;  // Har bir qoldiqni natijaning oldiga qo‘shamiz
            n /= 8;                     // Sonni 8 ga bo‘lamiz va davom etamiz
        }

        return result;
    }

    // Faqat yozish uchun (write-only) property
    // Bu yerga qiymat berilganda:
    //   1. number maydoniga yoziladi
    //   2. octalCode maydoniga sakkizlik ko‘rinishi yoziladi
    public int Number
    {
        set
        {
            if (value >= 0) // Faqat manfiy bo‘lmagan qiymatlar ruxsat etiladi
            {
                number = value;
                octalCode = ToOctal(value); // Oktal ko‘rinishga o‘girish
            }
        }
    }

    // Faqat o‘qish uchun (read-only) property
    // Sakkizlik ko‘rinishni foydalanuvchiga beradi
    public string OctalCode
    {
        get
        {
            return octalCode;
        }
    }
}

class NumsToOctal
{
    static void Main()
    {
        // Foydalanuvchidan raqam kiritishni so‘raymiz
        Console.WriteLine("Raqamni kiriting");

        // Raqamni qabul qilib, MyClass obyektini yaratamiz
        MyClass obj = new MyClass(Convert.ToInt32(Console.ReadLine()));

        // Obyekt orqali sakkizlik ko‘rinishni chiqaramiz
        Console.WriteLine(obj.OctalCode);
    }
}
