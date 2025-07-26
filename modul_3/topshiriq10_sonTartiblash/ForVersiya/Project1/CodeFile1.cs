using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nechta mos son topilsin (n): ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;

            Console.WriteLine("Mos keluvchi sonlar:");

            for (int i = 1; count < n; i++)
            {
                // 5 ga bo‘lganda qoldiq 2 yoki 3 ga bo‘lganda qoldiq 1
                if (i % 5 == 2 || i % 3 == 1)
                {
                    Console.Write(i + " ");
                    sum += i;
                    count++;
                }
            }

            Console.WriteLine($"\nYig'indisi: {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Xato: faqat butun son kiriting.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Xatolik: " + ex.Message);
        }
    }
}
