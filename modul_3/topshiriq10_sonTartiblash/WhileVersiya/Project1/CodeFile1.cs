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
            int i = 1;

            Console.WriteLine("Mos keluvchi sonlar:");

            while (count < n)
            {
                if (i % 5 == 2 || i % 3 == 1)
                {
                    Console.Write(i + " ");
                    sum += i;
                    count++;
                }
                i++;
            }

            Console.WriteLine($"\nYig'indisi: {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Xato: butun son kiriting.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Xatolik: " + ex.Message);
        }
    }
}
