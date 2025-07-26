using System;

class Program
{
    static void Main()
    {
        // Foydalanuvchidan hafta kunini so'raymiz
        Console.Write("Hafta kunini kiriting (masalan, dushanba): ");

        // Foydalanuvchi kiritgan matnni o'qib olamiz va kichik harflarga o'tkazamiz
        // Bu uchun, har qanday harf registridan qat'i nazar bir xil tekshirish qilish uchun kerak
        string day = Console.ReadLine().ToLower();

        // Hafta kunining raqamini saqlash uchun o'zgaruvchi yaratamiz, boshlanishda 0
        int dayNumber = 0;

        // Ichma-ich if-else shartlari orqali kiritilgan kunni tekshiramiz
        // Har bir shartda, agar kun mos kelsa, tegishli raqamni o'zgaruvchiga tayinlaymiz
        if (day == "dushanba")
            dayNumber = 1;
        else if (day == "seshanba")
            dayNumber = 2;
        else if (day == "chorshanba")
            dayNumber = 3;
        else if (day == "payshanba")
            dayNumber = 4;
        else if (day == "juma")
            dayNumber = 5;
        else if (day == "shanba")
            dayNumber = 6;
        else if (day == "yakshanba")
            dayNumber = 7;
        else
        {
            // Agar hech bir shartga mos kelmasa, demak foydalanuvchi noto'g'ri kun kiritdi
            Console.WriteLine("Bunday hafta kuni yo'q!");
            // Dastur bu yerda tugaydi, undan keyingi kod bajarilmaydi
            return;
        }

        // Agar to'g'ri kun kiritilgan bo'lsa, uning nomi va tartib raqamini ekranga chiqaramiz
        Console.WriteLine($"Hafta kuni: {day}, tartib raqami: {dayNumber}");
    }
}
