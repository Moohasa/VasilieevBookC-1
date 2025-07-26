using System;

class Program
{
    static void Main()
    {
        try
        {
            // Foydalanuvchidan butun son kiritishni so'raymiz
            Console.Write("Iltimos, biror butun son kiriting: ");
            string input = Console.ReadLine();

            // Kirtilgan satrni butun songa aylantiramiz
            int number = int.Parse(input);

            // Sonning 3 ga bo'linishini tekshiramiz
            bool divisibleBy3 = (number % 3 == 0);

            // Sonning 7 ga bo'linishini tekshiramiz
            bool divisibleBy7 = (number % 7 == 0);

            // Shartlarga qarab natijani chiqaramiz
            if (divisibleBy3 && divisibleBy7)
            {
                Console.WriteLine("Bu son 3 ga ham, 7 ga ham bo'linadi.");
            }
            else if (divisibleBy3)
            {
                Console.WriteLine("Bu son faqat 3 ga bo'linadi.");
            }
            else if (divisibleBy7)
            {
                Console.WriteLine("Bu son faqat 7 ga bo'linadi.");
            }
            else
            {
                Console.WriteLine("Bu son na 3 ga, na 7 ga bo'linadi.");
            }
        }
        // Agar foydalanuvchi son o'rniga noto'g'ri ma'lumot kiritsa, xato tutamiz
        catch (FormatException)
        {
            Console.WriteLine("Iltimos, to'g'ri butun son kiriting!");
        }
        // Boshqa kutilmagan xatolarni ham tutib, xabar beramiz
        catch (Exception ex)
        {
            Console.WriteLine("Xatolik yuz berdi: " + ex.Message);
        }

        // Dastur oxirida foydalanuvchi natijani ko'rishi uchun kutamiz
        Console.WriteLine("Dastur tugadi. Chiqish uchun Enter tugmasini bosing.");
        Console.ReadLine();
    }
}
