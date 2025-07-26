using System;

class SubstringDemo
{
    // Statik metod: text - kiruvchi matn,
    // startIndex - qaysi indeksdan boshlash,
    // length - nechta belgi olish kerak
    public static string MySubstring(string text, int startIndex, int length)
    {
        // Natija uchun bo'sh string yaratamiz
        string result = "";

        // Chegaralarni tekshirish: indekslar matn uzunligidan oshmasligi kerak
        if (startIndex < 0 || startIndex >= text.Length || length < 0)
        {
            // Noto'g'ri indeks yoki length bo'lsa bo'sh string qaytariladi
            return result;
        }

        // length, qolgan belgilar sonidan katta bo'lsa, uni kamaytiramiz
        if (startIndex + length > text.Length)
        {
            length = text.Length - startIndex;
        }

        // Sikl orqali kerakli belgilarni birma-bir qo'shamiz
        for (int i = startIndex; i < startIndex + length; i++)
        {
            result += text[i];
        }

        // Tayyorlangan qismni qaytaramiz
        return result;
    }

    static void Main()
    {
        string text = "Salom, dunyo!";
        int start = 7;
        int len = 5;

        // MySubstring metodini chaqiramiz
        string substring = MySubstring(text, start, len);

        Console.WriteLine("Asl matn: " + text);
        Console.WriteLine("Substring: " + substring);
    }
}
