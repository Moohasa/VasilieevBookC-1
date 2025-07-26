using System;

class UnikalHarfSaralash
{
    // Metod: matndan noyob harflarni ajratadi va alfavit tartibida saralaydi
    static char[] HarflarniAjratVaSarala(string text)
    {
        // Harflarni vaqtincha saqlash uchun massiv
        char[] harflar = new char[text.Length];
        int count = 0;

        // Har bir belgini ko'rib chiqamiz
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            // Agar harf katta bo‘lsa, kichikga o‘tkazamiz
            if (ch >= 'A' && ch <= 'Z')
                ch = (char)(ch + 32);

            // Faqat harf bo‘lsa (a-z oraliqda)
            if (ch >= 'a' && ch <= 'z')
            {
                // Bu harf oldin mavjudmi?
                bool mavjud = false;
                for (int j = 0; j < count; j++)
                {
                    if (harflar[j] == ch)
                    {
                        mavjud = true;
                        break;
                    }
                }

                // Agar mavjud bo'lmasa, massivga qo'shamiz
                if (!mavjud)
                {
                    harflar[count] = ch;
                    count++;
                }
            }
        }

        // Saralash (bubble sort usuli)
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (harflar[i] > harflar[j])
                {
                    char temp = harflar[i];
                    harflar[i] = harflar[j];
                    harflar[j] = temp;
                }
            }
        }

        // Natijaviy massivni yaratamiz (aniq o‘lchamda)
        char[] natija = new char[count];
        for (int i = 0; i < count; i++)
        {
            natija[i] = harflar[i];
        }

        return natija;
    }

    static void Main()
    {
        // Matn kiritamiz
        string matn = "Salom, dunyo! Salom, C#.";
        Console.WriteLine("Kiritilgan matn: " + matn);

        // Noyob harflarni ajratamiz
        char[] unikalHarflar = HarflarniAjratVaSarala(matn);

        // Natijani ekranga chiqaramiz
        Console.WriteLine("Noyob harflar (saralangan):");
        for (int i = 0; i < unikalHarflar.Length; i++)
        {
            Console.Write(unikalHarflar[i] + " ");
        }
        Console.WriteLine();
    }
}
