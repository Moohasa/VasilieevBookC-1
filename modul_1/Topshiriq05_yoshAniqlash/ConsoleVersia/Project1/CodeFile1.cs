using System;

class Program
{
    static void Main()
    {
        Console.Write("Tug‘ilgan yilingizni kiriting: ");
        string input = Console.ReadLine();

        // Tug'ilgan yilni butun songa aylantirish
        if (int.TryParse(input, out int tugilganYil))
        {
            int joriyYil = DateTime.Now.Year;
            int yosh = joriyYil - tugilganYil;

            if (yosh < 0 || yosh > 150)
            {
                Console.WriteLine("Kiritilgan yil noto‘g‘ri.");
            }
            else
            {
                Console.WriteLine($"Sizning yoshingiz: {yosh} yosh.");
            }
        }
        else
        {
            Console.WriteLine("Iltimos, to‘g‘ri raqam kiriting.");
        }
    }
}










/*____________________________________________
 * Topshiriq 5: Foydalanuvchining yoshini aniqlash
🎯 Vazifa:

Foydalanuvchi tug‘ilgan yilini kiritadi

Dastur yoshini hisoblab beradi (joriy yil asosida)

❗ Faqat konsol versiyasi talab qilinmoqda.
    ________________________________________________


    DateTime.Now.Year orqali joriy yil olinadi.

int.TryParse foydalanuvchi noto‘g‘ri yozsa (harf yoki bo‘sh joy), xatolikdan saqlaydi.

if (yosh < 0 || yosh > 150) orqali absurd natijalardan saqlaniladi.*/

