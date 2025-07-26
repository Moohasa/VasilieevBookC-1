using System;

// MyClass nomli sinf
class MyClass
{
    private string text; // Matn saqlovchi yopiq maydon

    // Konstruktor: obyekt yaratilganda matn qabul qiladi
    public MyClass(string t)
    {
        text = t;
    }

    // Implicit operator: string turidan to'g'ridan-to'g'ri MyClass obyektini yaratishga imkon beradi
    public static implicit operator MyClass(string t)
    {
        return new MyClass(t);
    }

    // ToString() metodi: obyektni string ko‘rinishida chiqaradi (masalan: Console.WriteLine(txt))
    public override string ToString()
    {
        return text;
    }

    // Indeksator: faqat yozish (set) uchun mo‘ljallangan, o‘qib bo‘lmaydi (get yo‘q)
    public char this[int k]
    {
        set
        {
            // Agar indeks matndan tashqarida bo‘lsa (manfiy yoki uzunlikdan katta) hech narsa qilmaydi
            if (k < 0 || k >= text.Length)
                return; // qiymat qaytarmaydi, faqat chiqib ketadi

            string t = ""; // yangi vaqtinchalik matn

            // Indeksga qadar matnni qo‘shamiz
            for (int i = 0; i < k; i++)
            {
                t += text[i];
            }

            t += value; // value — bu tashqaridan kiritilgan yangi belgi

            // Indeksdan keyingi matn qismini qo‘shamiz
            for (int i = k + 1; i < text.Length; i++)
            {
                t += text[i];
            }
            
            // Yangi yig‘ilgan matnni text maydoniga qayta yozamiz
            text = t;
        }
    }
}

// Test sinf
class WithOutGetDemo
{
    static void Main()
    {
        MyClass txt = "Pasha"; // string dan avtomatik MyClass obyektiga o'tdi
        Console.WriteLine(txt); // => Pasha

        txt[-1] = 'M'; // noto‘g‘ri indeks => hech narsa bo‘lmaydi
        Console.WriteLine(txt); // => Pasha

        txt[8] = 'x'; // noto‘g‘ri indeks => hech narsa bo‘lmaydi
        Console.WriteLine(txt); // => Pasha

        txt[0] = 'H'; // 'P' o‘rniga 'H' yoziladi
        Console.WriteLine(txt); // => Hasha

        txt[3] = 't'; // 3-pozitsiyadagi 'h' o‘rniga 't'
        Console.WriteLine(txt); // => Hasta

        txt[2] = 't'; // 2-pozitsiyadagi 's' o‘rniga 't'
        txt[4] = 'o'; // 4-pozitsiyadagi 'a' o‘rniga 'o'
        Console.WriteLine(txt); // => Hatto
    }
}
