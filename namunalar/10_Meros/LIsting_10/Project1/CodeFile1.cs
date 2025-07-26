using System;

// Ota klass: Alpha
class Alpha
{
    protected int alpha;             // Himoyalangan butun sonli maydon
    private char[] symbs;            // Faqat Alpha klassiga tegishli belgilar massivi

    // Konstruktor: son va matn qabul qiladi
    public Alpha(int a, string txt)
    {
        alpha = a;
        symbs = txt.ToCharArray();   // Stringni belgilar massiviga aylantiramiz
    }

    // virtual property: bu alpha qiymatini olish va o‘rnatish uchun
    public virtual int number
    {
        get { return alpha; }
        set { alpha = value; }
    }

    // Faqat o‘qiladigan property: belgilar massivining uzunligini qaytaradi
    public int length
    {
        get { return symbs.Length; }
    }

    // Indeksator: butun son orqali belgilar massiviga kirish
    public char this[int k]
    {
        get { return symbs[k]; }
        set { symbs[k] = value; }
    }

    // Indeksator: belgini harf orqali tanlash ('a' -> 0, 'b' -> 1...)
    public virtual int this[char s]
    {
        get { return this[s - 'a']; }                  // belgining pozitsiyasini hisoblab olib, massivdan o‘qish
        set { this[s - 'a'] = (char)value; }           // qiymatni char ko‘rinishda o‘rnatish
    }

    // ToString(): obyektni matnga aylantirishda qanday ko‘rinishini belgilaydi
    public override string ToString()
    {
        string txt = "|";
        for (int i = 0; i < this.length; i++)
        {
            txt += this[i] + "|";                      // Belgilarni |A|B|C| tarzida chiqaradi
        }
        return txt;
    }
}

// Voris klass: Bravo
class Bravo : Alpha
{
    protected int bravo;

    // Bravo konstruktor: base (Alpha) klassdan konstruktor chaqiradi
    public Bravo(int a, int b, string txt) : base(a, txt)
    {
        bravo = b;
        // alpha esa base klassdan keladi — alohida ko‘rsatishga hojat yo‘q
    }

    // number property override qilingan — alpha + bravo summasini qaytaradi
    public override int number
    {
        get { return alpha + bravo; }    // readonly tarzda ishlayapti
    }

    // Belgili indeksator override qilingan: faqat 'a' va boshqalar uchun farqlanadi
    public override int this[char s]
    {
        get
        {
            if (s == 'a')
                return alpha;
            else
                return bravo;
        }
        set
        {
            if (s == 'a')
                alpha = value;
            else
                bravo = value;
        }
    }
}

// Demo klass
class inheritPropIndexerDemo
{
    static void Main()
    {
        int i;
        char s;

        // Alpha obyektini yaratish
        Alpha A = new Alpha(100, "ABCD");
        Console.WriteLine("Obyekt A");
        Console.WriteLine(A);                       // ToString() orqali chiqariladi

        Console.WriteLine("A.number =" + A.number); // alpha qiymati
        A.number = 150;                             // alpha ni o‘zgartirish
        Console.WriteLine("A.number =" + A.number);

        // Belgilar va ularning indekslari bilan ishlash
        for (i = 0, s = 'a'; i < A.length; i++, s++)
        {
            Console.WriteLine("'{0}' simvoli {1} kodi bilan", A[i], A[s]);
            // A[i] — belgi; A[s] — indeksator orqali belgini char'dan tanlaydi
        }

        A[0] = 'E';                     // 0-indeksga yangi belgi
        A['b'] = 'A' + 10;              // 1-pozitsiyaga 'K' belgisi
        Console.WriteLine(A);          // Yangi belgilar chiqariladi

        // Bravo obyektini yaratish
        Bravo B = new Bravo(200, 300, "EFGHI");
        Console.WriteLine("Obyekt B:");
        Console.WriteLine(B);
        Console.WriteLine("B.number = " + B.number);  // alpha + bravo = 500

        // B.number = 400; — bu satrda set qilinmayapti, chunki number faqat get

        B['a'] = 10;     // alpha = 10
        B['d'] = 20;     // bravo = 20
        Console.WriteLine("B['a']=" + B['a']);  // 10
        Console.WriteLine("B['b']=" + B['b']);  // 20
        Console.WriteLine("B.number = " + B.number);  // 10 + 20 = 30

        // Belgilarni almashtirish
        for (i = 0; i < B.length; i++)
        {
            Console.Write(B[i] + " ");          // Belgilarni chiqarish
            B[i] = (char)('a' + i);             // a, b, c,... yozib chiqiladi
        }
        Console.WriteLine();
        Console.WriteLine(B);                   // Yangilangan belgilar
    }
}
