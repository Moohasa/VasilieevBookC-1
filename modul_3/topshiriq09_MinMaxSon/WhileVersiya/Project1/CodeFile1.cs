using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Birinchi sonni kiriting: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ikkinchi sonni kiriting: ");
            int num2 = int.Parse(Console.ReadLine());

            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);

            Console.WriteLine($"Oraliqdagi sonlar ({min} dan {max} gacha):");

            int i = min;
            while (i <= max)
            {
                Console.Write(i + " ");
                i++;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Xato: Iltimos, butun son kiriting.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Noma'lum xato yuz berdi: " + ex.Message);
        }
    }
}
