using System;

class MyClass
{
    // Maksimal qiymatni hisoblovchi metod
    public static int Max(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Argumentlar berilmagan.");

        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
                max = n;
        }
        return max;
    }

    // Minimal qiymatni hisoblovchi metod
    public static int Min(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Argumentlar berilmagan.");

        int min = numbers[0];
        foreach (int n in numbers)
        {
            if (n < min)
                min = n;
        }
        return min;
    }

    // O'rtacha qiymatni hisoblovchi metod
    public static double Average(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Argumentlar berilmagan.");

        int sum = 0;
        foreach (int n in numbers)
            sum += n;

        return (double)sum / numbers.Length;
    }
}

class Program
{
    static void Main()
    {
        // 1) Argümentlar sifatida butun sonlar ketma-ketligi berilishi mumkin:
        Console.WriteLine("Max: " + MyClass.Max(5, 3, 9, 1, 6));
        Console.WriteLine("Min: " + MyClass.Min(5, 3, 9, 1, 6));
        Console.WriteLine("Average: " + MyClass.Average(5, 3, 9, 1, 6));

        // 2) Yoki massiv uzatish ham mumkin:
        int[] arr = { 10, 20, 30, 40 };
        Console.WriteLine("Max (massiv): " + MyClass.Max(arr));
        Console.WriteLine("Min (massiv): " + MyClass.Min(arr));
        Console.WriteLine("Average (massiv): " + MyClass.Average(arr));
    }
}
