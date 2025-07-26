using System;

class Program
{
    // Birinchi versiya: ikki butun sonni oladi, oraliqdagi sonlar massivini qaytaradi
    public static int[] CreateArray(int start, int end)
    {
        if (start > end)
        {
            // Agar start katta bo'lsa end dan, ularni almashtiramiz
            int temp = start;
            start = end;
            end = temp;
        }

        int length = end - start + 1; // massiv uzunligini hisoblaymiz
        int[] result = new int[length];// massiv yaratamiz

        for (int i = 0; i < length; i++)
        {
            result[i] = start + i;
        }

        return result;
    }

    // Ikkinchi versiya: ikkita char oladi, oraliqdagi simvollar massivini qaytaradi
    public static char[] CreateArray(char start, char end)
    {
        if (start > end)
        {
            // Agar start keyingi simvoldan katta bo'lsa, ularni almashtiramiz
            char temp = start;
            start = end;
            end = temp;
        }

        int length = end - start + 1;
        char[] result = new char[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = (char)(start + i);
        }

        return result;
    }

    static void Main()
    {
        // Butun sonlar bilan test
        int[] numbers = CreateArray(2, 10);


        Console.WriteLine("Butun sonlar massiv:");
        Console.WriteLine(string.Join(", ", numbers));  // Chiqaradi: 2, 3, 4

        // Simvollar bilan test
        char[] chars = CreateArray('B', 'W');


        Console.WriteLine("Simvollar massiv:");
        Console.WriteLine(string.Join(", ", chars));  // Chiqaradi: B, C, D
    }
}
