using System;
using System.Globalization;

// MyClass - indexatorlar turli turlarda ortiqcha yuklangan (overloaded)
class MyClass
{
    private int[] nums; // ichki massiv

    public MyClass(int size)
    {
        nums = new int[size];
        for (int i = 0; i < nums.Length; i++)
        {
            // this[i] orqali indexatorni chaqiryapti — set blokini
            this[i] = i + 1;
        }
    }

    // ToString() obyekt tarkibini chiqaradi
    public override string ToString()
    {
        string txt = "Obyekt tarkibi:\n";
        for (int i = 0; i < nums.Length; i++)
        {
            txt += this[i] + (i == nums.Length - 1 ? "\n" : " ");
        }
        return txt;
    }

    // 1-o‘lchamli int indexator: massivning i-elementini olish/berish
    public int this[int i]
    {
        get
        {
            return nums[i % nums.Length]; // indeks chegaradan chiqmasligi uchun
        }
        set
        {
            nums[i % nums.Length] = value;
        }
    }

    // char orqali indexator: harfga asoslangan indeks (a=0, b=1, ...)
    public int this[char s]
    {
        get
        {
            return this[s - 'a'];
        }
        set
        {
            this[s - 'a'] = value;
        }
    }

    // ikki parametrli indexator: [int i, string t]
    public int this[int i, string t]
    {
        get
        {
            return this[t[i]]; // t[i] — bu char, ya'ni yuqoridagi indexatorga boradi
        }
        set
        {
            this[t[i]] = value;
        }
    }

    // indekslar o‘rni almashtirilgan indexator: [string t, int i]
    public int this[string t, int i]
    {
        get
        {
            return this[i, t]; // oldingi indexatorni chaqiryapti
        }
        set
        {
            this[i, t] = value;
        }
    }
}

// Dastur boshlanishi
class OverloadIndexerDemo
{
    static void Main()
    {
        int n = 6;
        MyClass obj = new MyClass(n); // 1 dan 6 gacha qiymatlar bilan to‘lgan
        Console.WriteLine(obj);

        // Obyektdan qiymatlarni olish (hatto chegaradan tashqarida bo‘lsa ham, modulo ishlaydi)
        for (int i = 0; i < n + 3; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine("\n");

        // Indexator orqali yozish: set ishlaydi
        obj[1] = 7;       // nums[1] = 7
        obj[n + 3] = 8;   // nums[(6+3)%6 = 3] = 8
        Console.WriteLine(obj);

        // char orqali murojaat qilish (a=0, k=10)
        obj['a'] = 9;     // nums[0] = 9
        obj['k'] = 0;     // nums[10 % 6 = 4] = 0
        Console.WriteLine(obj);

        Console.WriteLine("Tekshiruv:");
        for (char s = 'a'; s < 'a' + n + 3; s++)
        {
            Console.Write(obj[s] + " ");
        }
        Console.WriteLine("\n");

        // ikki parametrli indexatorlar ishlatilmoqda
        obj[4, "alpha"] = 0;         // 'a' = t[4], indexi: 'a' - 'a' = 0
        obj["bravo", 0] = 6;         // t[0] = 'b' → index: 'b' - 'a' = 1
        Console.WriteLine(obj);

        // Har xil indexator chaqiruvlar bilan solishtirish
        string txt = "abc";
        for (int i = 0; i < txt.Length; i++)
        {
            Console.WriteLine(obj[i, txt] + " :  " + obj[txt, i]);
        }
    }
}