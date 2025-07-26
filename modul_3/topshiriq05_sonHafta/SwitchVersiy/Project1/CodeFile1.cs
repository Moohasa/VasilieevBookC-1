using System;

class Program
{
    static void Main()
    {
        // Foydalanuvchidan hafta kunini so'raymiz
        Console.Write("Hafta kunini kiriting (masalan, dushanba): ");

        // Kirtilgan satrni kichik harflarga o'tkazamiz, bu keyingi tekshiruvni osonlashtiradi
        string day = Console.ReadLine().ToLower();

        // Hafta kunining tartib raqamini saqlovchi o'zgaruvchi
        int dayNumber;

        // Switch operatori, day qiymatiga qarab tegishli case ishlaydi
        switch (day)
        {
            case "dushanba":
                dayNumber = 1; // agar "dushanba" bo'lsa, dayNumber = 1
                break;         // break case tugaganini bildiradi, keyingi case'ga o'tilmaydi
            case "seshanba":
                dayNumber = 2;
                break;
            case "chorshanba":
                dayNumber = 3;
                break;
            case "payshanba":
                dayNumber = 4;
                break;
            case "juma":
                dayNumber = 5;
                break;
            case "shanba":
                dayNumber = 6;
                break;
            case "yakshanba":
                dayNumber = 7;
                break;
            default:
                // Agar hech qaysi case ga mos kelmasa, default ishlaydi
                Console.WriteLine("Bunday hafta kuni yo'q!");
                return; // dastur tugaydi
        }

        // Agar hafta kuni to'g'ri kiritilgan bo'lsa, uning nomi va raqamini chiqaramiz
        Console.WriteLine($"Hafta kuni: {day}, tartib raqami: {dayNumber}");
    }
}
