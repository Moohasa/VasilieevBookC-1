using System;

class Alpha
{
    // Oddiy metod (virtual emas) — bu yashirish (new) mumkin bo‘ladi, override qilib bo‘lmaydi
    public void hello()
    {
        Console.WriteLine("Alpha klassidan hello() metodi");
    }

    // Virtual metod — bu override qilish mumkin
    public virtual void hi()
    {
        Console.WriteLine("Alpha metodidan hi() metodi");
    }

    // show() metodi — ikkala metodni ichida chaqiradi
    public void show()
    {
        hello();  // bu har doim obyektning turiga emas, o'zining klassiga bog‘liq bo‘ladi
        hi();     // bu esa virtual bo‘lganligi sababli override qilingan bo‘lsa — unga bog‘lanadi
        Console.WriteLine();
    }
}

class Bravo : Alpha
{
    // hello() — bu metod virtual emas edi, shuning uchun new bilan YASHIRIB turibdi
    new public void hello()
    {
        Console.WriteLine("Bravo klassidan hello() metodi");
    }

    // hi() — bu metod override qilinmoqda, chunki Alpha'da virtual edi
    public override void hi()
    {
        Console.WriteLine("Bravo metodidan hi() metodi");
    }
}

class HiddingAndOverrideDemo
{
    static void Main()
    {
        Alpha A = new Alpha();
        Console.WriteLine("Alpha klassi show() metodi qo'llanishi");
        A.show(); // Alpha.hello(), Alpha.hi()

        Bravo B = new Bravo();
        Console.WriteLine("Bravo klassi hello() metodi qo'llanishi");
        B.hello(); // Bravo.hello()
        Console.WriteLine("Bravo klassi hi() metodi qo'llanishi");
        B.hi();    // Bravo.hi()

        Console.WriteLine("\n \n");
        Console.WriteLine("A = B tenglangandan so‘ngi qiymat");
        A = B; // A endi Bravo obyektini ushlab turibdi, lekin turi — Alpha

        Console.WriteLine("A.hello() bajarilishi");
        A.hello(); // 👈 Bu Alpha.hello() chaqiriladi! Chunki hello() override EMAS, faqat yashirilgan.

        Console.WriteLine("A.hi() bajarilishi");
        A.hi();    // 👈 Bu Bravo.hi() chaqiriladi! Chunki hi() override qilingan.

        Console.WriteLine("A.show() bajarilishi");
        A.show();  // show() metodida: 
                   // ➤ hello() — Alpha.hello() (polimorfizm yo‘q)
                   // ➤ hi()    — Bravo.hi() (polimorfizm bor)
    }
}
