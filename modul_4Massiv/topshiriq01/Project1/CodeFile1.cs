using System; // Konsol bilan ishlash, int.Parse va boshqa standart funksiyalar uchun

class Program
{
    static void Main()
    {
        try
        {
            // Foydalanuvchidan massiv uzunligini so‘raymiz
            Console.Write("Massiv uzunligini kiriting: ");
            int size = int.Parse(Console.ReadLine()); // Stringdan intga o‘tkazamiz

            // Agar foydalanuvchi manfiy yoki nol kiritsa, dasturni to‘xtatamiz
            if (size <= 0)
            {
                Console.WriteLine("Massiv uzunligi musbat son bo'lishi kerak.");
                return; // Dasturni shu yerda tugatamiz
            }

            // Kiritilgan uzunlikka ega butun sonlar massivini yaratamiz
            int[] array = new int[size];

            int number = 2; // 5 ga bo‘lganda 2 qoldiq beradigan birinchi son

            // Massivni to‘ldirish: har bir keyingi son 5 ga oshadi
            for (int i = 0; i < size; i++)
            {
                array[i] = number; // Massivning i-elementiga sonni yozamiz
                number += 5;       // Keyingi sonni hisoblash uchun 5 qo‘shamiz
            }

            // Massiv elementlarini ekranga chiqaramiz
            Console.WriteLine("Massiv elementlari:");
            foreach (int item in array)
            {
                Console.Write(item + " "); // Har bir elementni yonma-yon chiqaramiz
            }
        }
        catch (FormatException)
        {
            // Agar foydalanuvchi son o‘rniga matn yoki boshqa noto‘g‘ri qiymat kiritsa
            Console.WriteLine("Xatolik: Iltimos, butun son kiriting.");
        }
        catch (Exception ex)
        {
            // Boshqa har qanday kutilmagan xatoliklar uchun
            Console.WriteLine("Xatolik yuz berdi: " + ex.Message);
        }
    }
}
