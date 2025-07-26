using System;
using System.Globalization;

class MyClass
{
    private int[] num; // xususiy massiv maydoni, tashqaridan to‘g‘ridan-to‘g‘ri ko‘rinmaydi

    // Faqat o'qish mumkin bo'lgan xossa: massivdagi qiymatlarni matn shaklida qaytaradi
    public string content
    {
        get
        {
            if (num == null)
            {
                return "{ }"; // agar massiv hali yaratilmagan bo‘lsa
            }
            string txt = "{" + num[0]; // birinchi elementni qo‘shib boshlaymiz
            for (int i = 1; i < num.Length; i++)
            {
                txt += ", " + num[i]; // keyingi elementlarni vergul bilan ajratib qo‘shamiz
            }
            txt += "}"; // yakunlash
            return txt;
        }
    }

    // Faqat yozish mumkin bo'lgan xossa — har safar yangi element qo‘shiladi
    public int element
    {
        set
        {
            // agar massiv hali mavjud bo‘lmasa, uni yaratamiz va bitta qiymat yozamiz
            if (num == null)
            {
                num = new int[1];
                num[0] = value; // 🔸 value — bu set ichidagi maxsus kalit so‘z, tashqaridan kelgan qiymat
            }
            else
            {
                // massivni bittaga kattalashtirish uchun yangi massiv yaratamiz
                int[] n = new int[num.Length + 1];

                // eski massivdagi elementlarni yangi massivga ko‘chiramiz
                for (int i = 0; i < num.Length; i++)
                {
                    n[i] = num[i];
                }

                // yangi elementni oxiriga qo‘shamiz
                n[num.Length] = value;

                // yangi massivni eski o‘rniga yozamiz
                num = n;
            }
        }
    }

    // O'qish va yozish mumkin bo‘lgan xossa — to‘liq massiv bilan ishlaydi
    public int[] data
    {
        get
        {
            // yangi massivga asl massivni nusxalab qaytaradi (safely)
            int[] res = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                res[i] = num[i];
            }
            return res;
        }

        set
        {
            // tashqaridan berilgan massivni ichki `num` massivga nusxalab yozadi
            num = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                num[i] = value[i];
            }
        }
    }
}
class MoreUsingPropsDemo
{
    static void Main()
    {
        MyClass obj = new MyClass();

        // Hali hech qanday element yo‘q, shuning uchun: { }
        Console.WriteLine(obj.content);

        // 10 element sifatida qo‘shiladi
        obj.element = 10;
        Console.WriteLine(obj.content);  // {10}

        // 5 va 7 ham qo‘shiladi
        obj.element = 5;
        obj.element = 7;
        Console.WriteLine(obj.content);  // {10, 5, 7}

        // A — data xossasi orqali nusxa olingan massiv (10, 5, 7)
        int[] A = obj.data;

        // obj ga yangi element qo‘shiladi, A o‘zgarmaydi (nuqtayi nazaridan izolyatsiya)
        obj.element = 12;

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + "  ");  // 10  5  7
        }

        Console.WriteLine();
        Console.WriteLine(obj.content);  // {10, 5, 7, 12}

        // Yangi massiv B beriladi (11, 3, 6)
        int[] B = { 11, 3, 6 };
        obj.data = B;  // bu yerda obyektning `num` maydoni o‘zgartiriladi

        B[0] = 0; // obj.data o‘zgarmaydi, chunki nusxa olinadi

        // B ni konsolga chiqarish
        for (int i = 0; i < B.Length; i++)
        {
            Console.Write(B[i] + "  ");  // 0  3  6
        }

        Console.WriteLine();

        // obj content qayta: {11, 3, 6}
        Console.WriteLine(obj.content);
    }
}
