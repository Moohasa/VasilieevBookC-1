using System;

class ReplaceStringDemo
{
    static void Main()
    {
        // Asl matn: dastlabki satr
        String txt = "Biz C#ni o'rganayapmiz";
        Console.WriteLine(txt); // ➜ Ekranga chiqariladi

        // Matn uzunligini aniqlash uchun
        int n = txt.Length;
        Console.WriteLine(n); // ➜ 25 (matndagi belgi soni)

        // str degan yangi string o'zgaruvchiga txt qiymatini nusxalash
        String str;
        str = txt;
        Console.WriteLine(str); // ➜ "Biz C#ni o'rganayapmiz"

        // Matnga 15-pozitsiyaga "m" ni qo‘shamiz va "C#" so‘zini "Java"ga almashtiramiz
        str = str.Insert(15, "m").Replace("C#", "Java");
        // ➜ "Biz Javani o'rgmanayapmiz"

        Console.WriteLine(str);

        // Bo‘sh joylarni (_) belgisi bilan almashtirish
        str = str.Replace(' ', '_');
        // ➜ "Biz_Javani_o'rgmanayapmiz"

        Console.WriteLine(str);

        // Matndan faqat 0-indeksdan boshlab 10 ta belgini ajratib olish
        str = str.Substring(0, 10); // ➜ "Biz_Javani"
        Console.WriteLine(str);

        // Asl txt o'zgaruvchisi hali o'zgarmaganini ko'rish uchun yana chiqaramiz
        Console.WriteLine(txt); // ➜ "Biz C#ni o'rganayapmiz"
    }
}
