using System;

class MyClass
{
    private int[] num;  // 🔹 Obyekt ichidagi yashirin (private) butun sonli massiv

    // 🔹 Konstruktor: n ta elementli massivni 0 bilan to‘ldiradi
    public MyClass(int n)
    {
        num = new int[n];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = 0;
        }
    }

    // 🔹 ToString() metodi: obyektdan stringga o‘tishda ko‘rinadigan format
    public override string ToString()
    {
        string txt = "{" + num[0];
        for (int i = 1; i < num.Length; i++)
        {
            txt += ", " + num[i];  // 🔹 Massiv elementlarini vergul bilan ajratib chiqaradi
        }
        txt += "}";
        return txt;
    }

    // 🔹 Faqat o‘qiladigan xossa (getter): massiv uzunligi
    public int length
    {
        get
        {
            return num.Length;
        }
    }

    // ✅ INDEKSATOR — `this[int i]`
    public int this[int i]
    {
        get
        {
            return num[i];     // 🔹 Indeks orqali qiymatni o‘qish imkonini beradi
        }
        set
        {
            num[i] = value;   // 🔹 Indeks orqali qiymat yozish imkonini beradi
        }
    }
}
class UsingIndexDemo
{
    static void Main()
    {
        MyClass obj = new MyClass(5);   // 🔹 5 elementli ob'ekt yaratildi (massiv)
        Console.WriteLine(obj);         // 🔹 ToString() avtomatik chaqiriladi → {0, 0, 0, 0, 0}

        // 🔹 Har bir elementga qiymat yozamiz: 1, 3, 5, 7, 9
        for (int i = 0; i < obj.length; i++)
        {
            obj[i] = 2 * i + 1;
        }

        Console.WriteLine(obj);         // 🔹 Yangi holatda chiqariladi → {1, 3, 5, 7, 9}

        // 🔹 Har bir elementni alohida chiqaramiz
        for (int i = 0; i < obj.length; i++)
        {
            Console.Write("  " + obj[i]);  // 🔹 obj[i] — bu yerda indeksator ishlatilmoqda
        }
        Console.WriteLine();
    }
}
