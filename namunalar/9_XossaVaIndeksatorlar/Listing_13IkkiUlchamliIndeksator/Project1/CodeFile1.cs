using System;

class MyClass
{
    private int[] vals;        // Qiymatlar massivlari
    private char[] ckey;       // Kalitning birinchi qismi (char)
    private string[] skey;     // Kalitning ikkinchi qismi (string)

    // Yangi qiymat qo'shish uchun metod
    private void add(char a, string b, int n)
    {
        int size;
        char[] s;
        string[] t;
        int[] v;

        // Massivlar mavjud emasmi? Demak birinchi element qo‘shilmoqda
        if (vals == null)
            size = 1;
        else
            size = vals.Length + 1; // Yangi element uchun +1 joy kerak

        // Yangi massivlar yaratamiz
        s = new char[size];
        t = new string[size];
        v = new int[size];

        // Oxirgi joyga yangi qiymat joylashtiramiz
        s[s.Length - 1] = a;
        t[t.Length - 1] = b;
        v[v.Length - 1] = n;

        // Eski qiymatlarni ko‘chirib chiqamiz
        for (int i = 0; i < size - 1; i++)
        {
            s[i] = ckey[i];
            t[i] = skey[i];
            v[i] = vals[i];
        }

        // Yangilangan massivlarni obyektga bog‘laymiz
        ckey = s;
        skey = t;
        vals = v;
    }

    // Obyektdan string sifatida foydalanilganda chiqariladi
    public override string ToString()
    {
        string text = "Obyekt tarkibi:\n";
        if (vals != null)
        {
            for (int i = 0; i < ckey.Length; i++)
            {
                text += ckey[i] + ":  " + skey[i] + ":  " + vals[i] + "\n";
            }
        }
        else
            text += "Obyekt bo'sh\n";

        return text;
    }

    // Ikki o‘lchovli indexator (char + string)
    public int this[char a, string b]
    {
        get
        {
            if (vals != null)
            {
                for (int i = 0; i < ckey.Length; i++)
                {
                    if (a == ckey[i] && b == skey[i])
                    {
                        return vals[i];
                    }
                }
            }
            // Topilmasa, yangi qiymat qo‘shiladi (default = 0)
            int res = 0;
            add(a, b, res);
            return res;
        }
        set
        {
            if (vals != null)
            {
                for (int i = 0; i < ckey.Length; i++)
                {
                    if (a == ckey[i] && b == skey[i])
                    {
                        vals[i] = value; // Eski qiymatni yangilash
                        return;
                    }
                }
            }
            // Yangi qiymat qo‘shish
            add(a, b, value);
        }
    }
}

class UsingTwoDimIndexerDemo
{
    static void Main()
    {
        MyClass obj = new MyClass();

        Console.WriteLine(obj);

        // Indexator orqali qiymat olish (yo‘q bo‘lsa, 0 bilan qo‘shiladi)
        Console.WriteLine("Element qiymat:  " + obj['A', "Birinchi"] + "\n");

        Console.WriteLine(obj);

        // Yangi qiymatlarni o‘rnatish
        obj['B', "Ikkinchi"] = 200;
        obj['C', "Uchinchi"] = 300;

        Console.WriteLine(obj);

        // Turli indexator so‘rovlar
        Console.WriteLine("Element qiymat:  " + obj['B', "Birinchi"] + "\n"); // Yo‘q – 0
        Console.WriteLine("Element qiymat:  " + obj['B', "Ikkinchi"] + "\n"); // Bor – 200
        Console.WriteLine("Element qiymat:  " + obj['A', "Uchinchi"] + "\n"); // Yo‘q – 0

        Console.WriteLine(obj);

        // Eski qiymatni yangilash
        obj['A', "Birinchi"] = 100;

        Console.WriteLine(obj);
        Console.WriteLine("Element qiymat:  " + obj['A', "Birinchi"] + "\n"); // 100
    }
}