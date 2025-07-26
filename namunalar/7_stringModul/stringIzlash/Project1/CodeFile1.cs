using System;

class StrinIzlash
{
    static void Main()
    {
        // Asosiy matn
        string txt = "hullas, ikkiga qo'shuv ikki va ko'paytiruv ikki teng oltiga bo'ladi";

        // Konsolga matnni chiqaramiz
        Console.WriteLine("Kiritilgan matn:");
        Console.WriteLine("\"{0}\"", txt); // "hullas, ikkiga qo'shuv ikki va ko'paytiruv ikki teng oltiga bo'ladi"

        // Izlanadigan substring
        string str = "ikki";

        Console.WriteLine("Izlash uchun qator:");
        Console.WriteLine("\"{0}\"", str); // "ikki"

        Console.WriteLine();

        int index;

        // 1. Matnda "ikki" so'zining birinchi uchragan pozitsiyasi
        index = txt.IndexOf(str);
        Console.WriteLine("Birinchi o'xshashlik: {0}", index); // 8

        Console.WriteLine();

        // 2. Keyingi uchragan pozitsiya (avvalgi topilgan joydan keyin)
        index = txt.IndexOf(str, index + 1);
        Console.WriteLine("Ikkinchi o'xshashlik: {0}", index); // 23

        Console.WriteLine();

        // 3. Matnda "ikki" ning oxirgi uchragan joyi
        index = txt.LastIndexOf(str);
        Console.WriteLine("Oxirgi o'xshashlik: {0}", index); // 43

        Console.WriteLine();

        // 4. Berilgan oraliqda substring qidirish
        int a = 7, b = 9;
        Console.WriteLine("{0} - indeksdan {1} ta belgi ichida izlash", a, b);
        index = txt.IndexOf(str, a, b); // 7-indeksdan boshlab, 9 ta belgigacha qidir
        Console.WriteLine("Interval bo‘yicha o'xshashlik: {0}", index); // 8

        Console.WriteLine();

        // 5. Orqadan qarab belgilangan oraliqda substring qidirish
        b = 3;
        Console.WriteLine("{0} - indeksdan {1} ta belgi ichida (qayta)", a, b);
        index = txt.LastIndexOf(str, a + b - 1, b); // 7 + 3 -1 = 9 pozitsiyadan orqaga qarab
        Console.WriteLine("Interval bo‘yicha oxirgi o'xshashlik: {0}", index); // -1 (topilmadi)

        Console.WriteLine();

        // 6. Bitta harfni izlash: 'a'
        char symb = 'a';
        Console.WriteLine("Endi '{0}' harfi bo‘yicha izlaymiz:", symb); 

        Console.WriteLine();

        // Birinchi uchragan 'a'
        index = txt.IndexOf(symb);
        Console.WriteLine("Birinchi o'xshashlik: {0}", index); // 4

        Console.WriteLine();

        // Ikkinchi 'a'
        index = txt.IndexOf(symb, index + 1);
        Console.WriteLine("Ikkinchi o'xshashlik: {0}", index); // 13

        Console.WriteLine();

        // Oxirgi 'a'
        index = txt.LastIndexOf(symb);
        Console.WriteLine("Oxirgi o'xshashlik: {0}", index); // 58

        Console.WriteLine();

        // Oxirgidan oldingi 'a'
        index = txt.LastIndexOf(symb, index - 1);
        Console.WriteLine("Oxirgidan oldingi o'xshashlik: {0}", index); // 35

        Console.WriteLine();

        // Berilgan oraliqda 'a' ni izlash
        index = txt.IndexOf(symb, a, b);
        Console.WriteLine("{0} va {1} intervalidan indeks izlash", a, a + b - 1);
        Console.WriteLine("Intervaldagi birinchi o'xshashlik: {0}", index); // -1 (bu oraliqda 'a' yo'q)

        Console.WriteLine();

        // 7. 'b' harfini izlash
        symb = 'b';
        Console.WriteLine("'{0}' harfi bo‘yicha izlaymiz:", symb);

        Console.WriteLine();

        index = txt.IndexOf(symb);
        Console.WriteLine("Birinchi o'xshashlik: {0}", index); // -1 (topilmadi)

        Console.WriteLine();

        index = txt.IndexOf(symb, index + 1);
        Console.WriteLine("Ikkinchi o'xshashlik: {0}", index); // -1

        Console.WriteLine();

        // 8. Bir nechta harflardan birini izlash
        char[] s = { 'i', 'k', 'o' };
        Console.WriteLine("'{0}' harflari (yoki 'k', 'o') bo‘yicha izlaymiz:", s[0]);

        Console.WriteLine();

        // 1) Harflardan birinchisi qayerda uchraydi
        index = txt.IndexOfAny(s);
        Console.WriteLine("Birinchi o'xshashlik: {0}", index); // 8 (i)

        Console.WriteLine();

        // 2) Ikkinchi o'xshashlikni topish (keyingi pozitsiyadan boshlab)
        index = txt.LastIndexOfAny(s, index + 1);
        Console.WriteLine("Ikkinchi o'xshashlik (keyingi pozitsiyadan): {0}", index); // 9 (k)

        Console.WriteLine();

        // 3) Oxirgi o‘xshashlik
        index = txt.LastIndexOfAny(s);
        Console.WriteLine("Oxirgi o'xshashlik: {0}", index); // 56 (i)

        Console.WriteLine();

        // 4) Belgilangan oraliqda qidirish
        Console.WriteLine("{0} dan {1} gacha intervalda izlash:", a, a + b - 1);
        index = txt.IndexOfAny(s, a, b); // 7 dan 9 gacha
        Console.WriteLine("Intervaldagi birinchi o'xshashlik: {0}", index); // 8 (i)

        Console.WriteLine();

        index = txt.LastIndexOfAny(s, a + b - 1, b);
        Console.WriteLine("Intervaldagi oxirgi o'xshashlik: {0}", index); // 9 (k)
    }
}
