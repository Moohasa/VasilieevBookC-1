using System;

class Program
{
    // Statik metod: massivni argument sifatida oladi va massiv elementlarini joylarini almashtiradi
    static void SwapPairs(char[] array)
    {
        int length = array.Length;

        // Faoliyat faqat massivning yarmigacha, chunki har bir almashtirish 2 elementni qamrab oladi
        for (int i = 0; i < length / 2; i++)
        {
            // Oxirgi indeks
            int oppositeIndex = length - 1 - i;

            // Vaqtinchalik o'zgaruvchi yordamida elementlarni almashtiramiz
            char temp = array[i];
            array[i] = array[oppositeIndex];
            array[oppositeIndex] = temp;
        }
    }

    static void Main()
    {
        // Misol uchun simvol massivi
        char[] myArray = { 'h', 'a', 's', 'a', 'n', 'b', 'o', 'y' };

        Console.WriteLine("Dastlabki massiv:");
        Console.WriteLine(string.Join(", ", myArray));

        SwapPairs(myArray);

        Console.WriteLine("Almashtirilgan massiv:");
        Console.WriteLine(string.Join(", ", myArray));
    }
}
