
using System;

class MyClass
{
    // 🔐 Xususiy (private) butun sonli maydon — bu yerda foydalanuvchi kiritgan son saqlanadi
    private int number;

    // 📦 Konstruktor — obyekt yaratilganda boshlang‘ich sonni oladi
    public MyClass(int n)
    {
        number = n;
    }

    // 📌 Faqat get-aksessorli indeksator — raqamning i-chi o‘ngdan chapga raqamini qaytaradi
    public int this[int i]
    {
        get
        {
            int n = number;

            // 🔁 O‘ngdan chapga qarab i-chi raqamga yetguncha sonni 10 ga bo‘lib qisqartiramiz
            for (int j = 1; j < i; j++)
            {
                n /= 10;  // Har bir qadamda oxirgi raqamni olib tashlaymiz
            }

            // 🔚 Oxirgi raqamni (i-chi raqam) olish uchun 10 ga bo‘linmaning qoldig‘ini olamiz
            return n % 10;
        }
    }
}

class WithOutSetDemo
{
    static void Main()
    {
        // 🎯 Foydalanuvchi son kiritadi (masalan: 12345678)
        Console.Write("Son kiriting: ");
        MyClass obj = new MyClass(Convert.ToInt32(Console.ReadLine()));

        // 🔄 Obyektdan ketma-ket raqamlarni chiqaramiz (i = 1 dan 8 gacha)
        for (int i = 1; i < 9; i++)
        {
            Console.Write(" | " + obj[i]);  // obj[i] — indeksator orqali i-chi raqamni olish
        }

        Console.WriteLine(" |");
    }
}
