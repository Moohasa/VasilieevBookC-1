using System;

class SplittingStringDemo
{
    static void Main()
    {
        // Asosiy matn (string)
        string txt = "Yo'lovchi yo'lni o'zlashtiradi";
        Console.WriteLine(txt); // Matnni chiqaramiz

        // ToUpper(): matnni KATTA harflarga o‘zgartiradi
        String str = txt;
        str = str.ToUpper();
        Console.WriteLine(str); // => YO'LOVCHI YO'LNI O'ZLASHTIRADI

        // ToLower(): matnni kichik harflarga o‘zgartiradi
        str = str.ToLower();
        Console.WriteLine(str); // => yo'lovchi yo'lni o'zlashtiradi

        // Split(): default bo‘yicha bo‘sh joy (space) bo‘yicha bo‘ladi
        String[] words;
        words = txt.Split();

        // Har bir so‘zni chiqaramiz
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine((i + 1) + ":" + words[i]);
        }

        Console.WriteLine();

        // Endi matnni 'o' va 'l' harflari bo‘yicha ajratamiz
        words = txt.Split('o', 'l');

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine((i + 1) + ":" + words[i]);
        }

        Console.WriteLine();

        // 'o' va 'l' harflariga qarab, Faqat 3 ta qismga ajratamiz
        words = txt.Split(new char[] { 'o', 'l' }, 3); // maksimal 3 ta bo‘lak
        Console.WriteLine();

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine((i + 1) + ":" + words[i]);
        }

        Console.WriteLine();

        // Matnni belgilarga ajratish (har bir harfni alohida olish)
        char[] symbs;
        symbs = txt.ToCharArray();

        // Belgilarni birma-bir chiqarish
        for (int i = 0; i < symbs.Length; i++)
        {
            Console.Write(symbs[i] + " ");
        }

        Console.WriteLine(); // satrni tugatish
    }
}
