using System;

class CharWrapper
{
    public char CharValue;  // Simvol maydoni

    // Konstruktor
    public CharWrapper(char c)
    {
        CharValue = c;
    }

    // + operatorini overload qilish
    // Ikkita CharWrapper obyekti qo'shilganda, natija string bo'ladi
    public static string operator +(CharWrapper a, CharWrapper b)
    {
        return a.CharValue.ToString() + b.CharValue.ToString();
    }

    // - operatorini overload qilish
    // Natija int (farq) qaytadi
    public static int operator -(CharWrapper a, CharWrapper b)
    {
        return a.CharValue - b.CharValue;
    }

    // ToString metodini override qilamiz, qulaylik uchun
    public override string ToString()
    {
        return CharValue.ToString();
    }

    // Operatorlarga implicit konvertatsiya qilish (casting) qo'shish:
    // CharWrapper dan char ga
    public static implicit operator char(CharWrapper c) => c.CharValue;

    // char dan CharWrapper ga
    public static implicit operator CharWrapper(char c) => new CharWrapper(c);
}

class Program
{
    static void Main()
    {
        CharWrapper a = new CharWrapper('A');
        CharWrapper b = new CharWrapper('B');

        // + operatori natijasi string bo'ladi
        string resultPlus = a + b;  // "AB"
        Console.WriteLine($"a + b = {resultPlus}");

        // - operatori natijasi int (kodlar farqi)
        int resultMinus = a - b;  // 'A' - 'B' = 65 - 66 = -1
        Console.WriteLine($"a - b = {resultMinus}");

        // += operatori (a = a + b) natijasi string, shuning uchun to'g'ridan-to'g'ri a ga yozib bo'lmaydi
        // Shuning uchun avval stringga olish mumkin
        string s = "";
        s += a + b;
        Console.WriteLine($"s += a + b => {s}");

        // -= operatorini charWrapper uchun ishlatish qiyin, chunki u int qaytaradi
        // Shu sababli bu operatorni to'g'ridan-to'g'ri a -= b; kabi ishlatish amaliy emas
        // Lekin agar xohlasangiz, o'zingiz operatorni boshqa tarzda yozishingiz mumkin.

        // Misol uchun quyidagi kodga e'tibor bering:
        // a += b; // bunday yozish kompilyator xatosi beradi, chunki operator + qaytgan tip string, CharWrapper emas.
        // Agar a ning qiymatini yangilamoqchi bo'lsangiz, siz maxsus metod yaratishingiz kerak yoki boshqa yondashuv qo'llang.

        // Shuning uchun oddiy misol:
        CharWrapper c = new CharWrapper('C');
        CharWrapper d = new CharWrapper('D');

        Console.WriteLine($"c + d = {c + d}");
        Console.WriteLine($"c - d = {c - d}");
    }
}
