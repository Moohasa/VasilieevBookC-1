using System;

class Program
{
    // Statik metod: params yordamida istalgancha butun son qabul qiladi
    public static int[] FindMinMax(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Metodga kamida bitta argument berilishi kerak.");
        }

        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return new int[] { max, min };
    }

    static void Main()
    {
        int[] result = FindMinMax(3, 5, 1, 9, 2, 7);

        Console.WriteLine($"Eng katta: {result[0]}");
        Console.WriteLine($"Eng kichik: {result[1]}");
    }
}
