using System;

// === Asosiy klass ===
class Alpha
{
    // Himoyalangan matnli maydon
    protected string text;

    // 1) Oddiy konstruktor: matnga boshlang'ich qiymat berish
    public Alpha(string t)
    {
        text = t;
    }

    // 2) Nusxalovchi konstruktor
    public Alpha(Alpha obj)
    {
        this.text = obj.text;
    }

    // 3) Virtual metod: matnni o‘qish (hosila klass override qilishi mumkin)
    public virtual string getText()
    {
        return text;
    }

    // 4) Overload metod: matnni o‘zgartirish
    public string setText(string t)
    {
        text = t;
        return text;
    }

    // 5) Read-only property: matn uzunligi
    public int length
    {
        get { return text.Length; }
    }

    // 6) Read-only indeksator: belgini indeks bo‘yicha olish
    public char this[int index]
    {
        get { return text[index]; }
    }
}

// === Hosila klass ===
class Bravo : Alpha
{
    // Yangi public butun sonli maydon
    public int code;

    // 1) Konstruktor: ikkita argument (int va string)
    public Bravo(int n, string t) : base(t)
    {
        code = n;
    }

    // 2) Nusxalovchi konstruktor
    public Bravo(Bravo obj) : base(obj)
    {
        code = obj.code;
    }

    // 3) Matnni o‘qish — override qilingan versiya
    public override string getText()
    {
        return text;
    }

    // 4) Matnni o‘zgartirish — overload qilingan versiya
    public string setText(string t)
    {
        text = t;
        return text;
    }

    // 5) Kodni o‘qish
    public int setCode()
    {
        return code;
    }

    // 6) Kodni o‘zgartirish
    public int setCode(int n)
    {
        code = n;
        return code;
    }
}

// === Main metod (test) ===
class Program
{
    static void Main()
    {
        // Alpha obyektini yaratish
        Alpha A = new Alpha("Salom");
        Console.WriteLine(A.getText());         // Salom
        Console.WriteLine(A[0] + " " + A[1] + " " + A[2] + " " + A[3] + " " + A[4]);  // S a l o m

        // Bravo obyektini yaratish
        Bravo B = new Bravo(123, "dunyo");
        Console.WriteLine(B.getText() + " " + B.setCode()); // dunyo 123

    }
}
