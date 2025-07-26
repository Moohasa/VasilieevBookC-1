using System;

class Program
{
    static void Main()
    {
        // Yig'indini saqlash uchun o'zgaruvchi
        int sum = 0;

        // Cheksiz sikl: foydalanuvchi 0 kiritgunga qadar davom etadi
        while (true)
        {
            try
            {
                // Foydalanuvchidan son kiritishni so'raymiz
                Console.Write("Son kiriting (to'xtatish uchun 0): ");

                // Kirtilgan matnni butun songa aylantiramiz
                int number = int.Parse(Console.ReadLine());
               // char input = char.Parse(Console.ReadLine());

                // Agar foydalanuvchi 0 kiritsa, sikldan chiqamiz
                if (number == 0)
                    break;

                // Kirtilgan sonni yig'indiga qo'shamiz
                sum += number;
            }
            catch (FormatException)
            {
                // Agar foydalanuvchi noto'g'ri ma'lumot (masalan harf) kiritsa, xatolik xabarini chiqaramiz
                Console.WriteLine("Iltimos, to'g'ri butun son kiriting!");
            }
            catch (Exception ex)
            {
                // Boshqa kutilmagan xatoliklar uchun umumiy ushlash va xabar berish
                Console.WriteLine("Kutilmagan xatolik: " + ex.Message);
            }
        }

        // Sikl tugagach, umumiy yig'indini ekranga chiqaramiz
        Console.WriteLine("Sonlarning yig'indisi: " + sum);

        // Dastur tugashini bildirish va konsol oynasini yopilishidan oldin kutish
        Console.WriteLine("Dastur tugadi. Chiqish uchun Enter tugmasini bosing.");
        Console.ReadLine();
    }
}
