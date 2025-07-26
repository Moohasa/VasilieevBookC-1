using System;

class Program
{
    static void Main()
    {
        try
        {
            // Foydalanuvchidan birinchi sonni kiritishni so'raymiz
            Console.Write("Birinchi butun sonni kiriting: ");
            int firstNumber = int.Parse(Console.ReadLine());

            // Foydalanuvchidan ikkinchi sonni kiritishni so'raymiz
            Console.Write("Ikkinchi butun sonni kiriting: ");
            int secondNumber = int.Parse(Console.ReadLine());

            // Sonlarni taqqoslaymiz va natijani chiqaramiz
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Birinchi son katta.");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("Ikkinchi son katta.");
            }
            else
            {
                Console.WriteLine("Sonlar teng.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Xato: Iltimos, butun sonlarni to‘g‘ri kiriting!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Kutilmagan xatolik yuz berdi: " + ex.Message);
        }

        // Dastur yakunlandi, natijani ko‘rish uchun kutamiz
        Console.WriteLine("Dastur tugadi. Chiqish uchun Enter tugmasini bosing.");
        Console.ReadLine();
    }
}
