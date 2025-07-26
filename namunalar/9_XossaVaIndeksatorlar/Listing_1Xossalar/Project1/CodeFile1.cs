using System;

// MyClass nomli klass yaratildi
class MyClass
{
    // num — ichki maydon, haqiqiy saqlovchi (kod qiymati)
    private int num;

    // min va max — qiymatlarning ruxsat etilgan oraliqlari
    private int min;
    private int max;

    // Konstruktor — obyekt yaratilganda min va max qiymatlarni o'rnatadi
    public MyClass(int a, int b)
    {
        min = a;       // minimal qiymat
        max = b;       // maksimal qiymat
        code = (max + min) / 2;  // code xossasiga boshlang'ich o'rta qiymat beriladi
    }

    // code — bu xossa (property), tashqaridan 'num' maydonini boshqarishga imkon beradi
    public int code
    {
        // get — tashqariga qiymat chiqarish (o'qish)
        get
        {
            return num;  // num qiymatini qaytaradi
        }

        // set — qiymat o'rnatishda ishlaydi
        set
        {
            // Agar berilgan qiymat min dan kichik bo'lsa
            if (value < min)
            {
                num = min;  // num ni min ga tenglaymiz
            }
            // Agar berilgan qiymat max dan katta bo'lsa
            else if (value > max)
            {
                num = max;  // num ni max ga tenglaymiz
            }
            else
                // Aks holda qiymatni num ga o'rnatamiz
                num = value;
        }
    }
}

// Asosiy klass — dasturni ishga tushiradi
class UsingPropsDemo
{
    static void Main()
    {
        // MyClass dan yangi obyekt yaratamiz,
        // min = 1, max = 9 qiymatlar bilan
        MyClass obj = new MyClass(1,9);

        // Boshlang'ich qiymatni chiqaramiz — konstruktor o'rta qiymatni qo'ygan
        Console.WriteLine("code Xossasi  " + obj.code);

        // code ga 7 ni beramiz — bu oraliq ichida, shuning uchun 7 o'rnatiladi
        obj.code = 7;
        Console.WriteLine("code Xossasi  " + obj.code);

        // code ga 20 beramiz — 20 max dan katta, shuning uchun num = max = 9 bo'ladi
        obj.code = 20;
        Console.WriteLine("code Xossasi  " + obj.code);

        // code ga -10 beramiz — -10 min dan kichik, shuning uchun num = min = 1 bo'ladi
        obj.code = -10;
        Console.WriteLine("code Xossasi  " + obj.code);
    }
}
