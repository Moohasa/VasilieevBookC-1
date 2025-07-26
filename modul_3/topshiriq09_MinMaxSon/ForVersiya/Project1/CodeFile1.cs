using System;

class Program
{
    static void Main()
    {
        try
        {
            // Foydalanuvchidan ikkita sonni o'qish
            Console.Write("Birinchi sonni kiriting: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ikkinchi sonni kiriting: ");
            int num2 = int.Parse(Console.ReadLine());

            // Kichik va katta sonni aniqlaymiz
            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);

            Console.WriteLine($"Oraliqdagi sonlar ({min} dan {max} gacha):");

            // for sikli yordamida kichikdan kattagacha chiqaramiz
            for (int i = min; i <= max; i++)
            {
                Console.Write(i + " ");
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
