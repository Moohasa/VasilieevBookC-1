using System;

class Program
{
    // Statik metod — massiv elementlari o'rtachasini hisoblaydi
    static double CalculateAverage(int[] numbers)
    {
        // Massiv bo'sh bo'lsa, 0 qaytaramiz (yoki istalgan boshqa qiymat)
        if (numbers.Length == 0)
            return 0;

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];  // Har bir elementni yig'ish
        }

        double average = (double)sum / numbers.Length;  // O'rtacha qiymatni hisoblash
        return average;
    }

    static void Main()
    {
        int[] myArray = { 10, 20, 30, 40, 50 }; // Misol uchun massiv
        double avg = CalculateAverage(myArray); // Metodni chaqiramiz

        Console.WriteLine("Massiv elementlari o'rtacha qiymati: " + avg);
    }
}
