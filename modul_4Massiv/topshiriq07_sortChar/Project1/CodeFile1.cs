using System;

class Program
{
    static void Main()
    {
        // Belgilar massivining o'lchami
        int size = 10;

        // Belgilar massivini e'lon qilish
        char[] chars = new char[size];

        // Massivni harflar bilan to'ldirish (masalan, 'a' dan boshlanib ketma-ket harflar)
        for (int i = 0; i < size; i++)
        {
            chars[i] = (char)('a' + i); // 'a', 'b', 'c' ...
        }

        // Boshlang'ich massivni chiqarish
        Console.WriteLine("Boshlang'ich massiv:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(chars[i] + " ");
        }
        Console.WriteLine();

        // Massivni teskari tartibga o'zgartirish
        // 2 indeks o'rtasida almashtirish amalga oshiriladi: boshidan va oxiridan boshlab
        for (int i = 0; i < size / 2; i++)
        {
            char temp = chars[i];
            chars[i] = chars[size - 1 - i];
            chars[size - 1 - i] = temp;
        }

        // Teskari tartibga o'zgartirilgan massivni chiqarish
        Console.WriteLine("Teskari tartibdagi massiv:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(chars[i] + " ");
        }
        Console.WriteLine();
    }
}
