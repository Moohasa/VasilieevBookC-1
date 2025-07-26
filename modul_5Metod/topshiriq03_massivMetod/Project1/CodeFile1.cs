using System;

class Program
{
    static int[] GetInitialElements(int[] arr, int n)
    {
        if (n >= arr.Length)
        {
            // Butun massivni for sikli bilan nusxalash
            int[] copy = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }
            return copy;
        }
        else
        {
            // n ta bosh elementdan yangi massiv yaratish va ko'chirish
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = arr[i];
            }
            return result;
        }
    }

    static void Main()
    {
        int[] myArray = { 10, 20, 30, 40, 50 };

        int n = 3;
        int[] result1 = GetInitialElements(myArray, n);
        Console.WriteLine($"Birinchi {n} element:");
        PrintArray(result1);

        n = 10;
        int[] result2 = GetInitialElements(myArray, n);
        Console.WriteLine($"\n{n} element olish so'raldi, lekin massiv uzunligi {myArray.Length}, to'liq massiv qaytarildi:");
        PrintArray(result2);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int x in arr)
            Console.Write(x + " ");
        Console.WriteLine();
    }
}
