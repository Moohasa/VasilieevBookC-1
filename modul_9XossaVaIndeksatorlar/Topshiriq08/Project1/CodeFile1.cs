using System;

class MyClass
{
    private int number;

    // Konstruktor: boshlang‘ich sonni qabul qiladi
    public MyClass(int n)
    {
        number = n;
    }

    // O‘qish uchun maxsus property (test va chiqarish uchun)
    public int Number
    {
        get
        {
            return number;
        }
    }

    // Indeksator: berilgan index razryadga yangi raqam o‘rnatadi
    public int this[int index]
    {
        set
        {
            // raqamni teskariga o'girish uchun
            int length = number.ToString().Length;
            int trueIndex = length  - 1 - index;

            if (trueIndex < 0||trueIndex >= length)
                return;

            int razryad = (int)Math.Pow(10, trueIndex);             // 10^index → qaysi razryad
            int oldDigit = (number / razryad) % 10;             // Eski raqamni topish
            number -= oldDigit * razryad;                       // Eski raqamni olib tashlash
            int newDigit = value % 10;                          // Faqat oxirgi raqamni olish
            number += newDigit * razryad;                       // Yangi raqamni qo‘shish
        }
    }
}

class MainDemo
{
    static void Main()
    {
        Console.WriteLine("Raqam, o'zgaruvchi razryad va o'zgartiruvchi raqamni kiriting");

        // Foydalanuvchidan raqam va o‘zgarish ma’lumotlarini olish
        int raqam = Convert.ToInt32(Console.ReadLine());
        int razryad = Convert.ToInt32(Console.ReadLine());
        int ozgartiruvchiRaqam = Convert.ToInt32(Console.ReadLine());

        // MyClass obyektini yaratish
        MyClass obj = new MyClass(raqam);

        // Indeksator orqali razryadni o‘zgartirish
        obj[razryad] = ozgartiruvchiRaqam;

        // Yangi qiymatni chiqarish
        Console.WriteLine("Raqam o'zgartirildi:  " + obj.Number);
    }
}
