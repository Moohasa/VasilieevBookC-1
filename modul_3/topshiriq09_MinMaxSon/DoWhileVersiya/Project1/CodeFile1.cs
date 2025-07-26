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

            // Agar min > max bo'lsa, sikl hech qachon ishlamaydi
            if (min > max)
            {
                Console.WriteLine("Kichik son katta sondan katta bo'lishi mumkin emas.");
            }
            else
            {
                do
                {
                    Console.Write(i + " ");
                    i++;
                } while (i <= max);
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
