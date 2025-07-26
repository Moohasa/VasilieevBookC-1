using System;

class MyClass
{
    // MyClass klassi 3 ta maydonga ega:
    public int code;     // butun son (raqamli) maydon
    public char symb;    // bitta belgi
    public String text;  // matn (string) maydoni

    // Konstruktor: obyekt yaratishda barcha maydonlarni boshlang'ich qiymatlar bilan to‘ldiradi
    public MyClass(int n, char s, String t)
    {
        code = n; symb = s; text = t;
    }

    // Obyektni stringga aylantirishda qanday ko‘rinishda chiqishini belgilaydi
    public override string ToString()
    {
        String txt = "Obyekt maydoni :\n";
        txt += "Butun sonli maydon:  " + code + "\n";
        txt += "Simvolli maydon:  \'" + symb + "\' \n";
        txt += "Matnli maydon:    \"" + text + "\"\n";
        txt += "__________________________________________________";
        return txt;
    }

    // ---------- ↓↓↓ Conversion (Turlarni o‘zgartirish) operatorlari ↓↓↓ ----------

    // EXPLICIT: MyClass → String (faqat text maydonini beradi)
    public static explicit operator String(MyClass obj)
    {
        return obj.text;
    }

    // IMPLICIT: MyClass → int (code qiymatini avtomatik olib beradi)
    public static implicit operator int(MyClass obj)
    {
        return obj.code;
    }

    // IMPLICIT: MyClass → char (symb qiymatini avtomatik olib beradi)
    public static implicit operator char(MyClass obj)
    {
        return obj.symb;
    }

    // IMPLICIT: int → MyClass
    public static implicit operator MyClass(int n)
    {
        // int berilganda MyClass obyektiga aylantiradi
        // Belgisi 'B' va matni "Bravo" bo‘ladi (doimiy qiymatlar)
        MyClass t = new MyClass(n, 'B', "Bravo");
        return t;
    }

    // EXPLICIT: char → MyClass
    public static explicit operator MyClass(char s)
    {
        // char berilganda MyClass obyektiga aylantiradi
        // code = 300, matn = "Charlie" qilib beradi
        return new MyClass(300, s, "Charlie");
    }

    // IMPLICIT: string → MyClass
    public static implicit operator MyClass(String t)
    {
        // Matn uzatilsa:
        // 1) code — matn uzunligi
        // 2) symb — matnning birinchi harfi
        // 3) text — matnning o‘zi
        return new MyClass(t.Length, t[0], t);
    }

    // ----------------------------------------------
    // Barcha operatorlar quyidagicha ishlaydi:
    //  - `implicit` operator: avtomatik konvertatsiya
    //  - `explicit` operator: (Tip)obj tarzida qo‘lda konvertatsiya
    // Bu operatorlar klassni boshqa turlarga yoki boshqa turlardan klassga aylantirish uchun ishlatiladi
}
class OverloadingImplExpDemo
{
    static void Main()
    {
        // Oddiy konstruktor orqali obyekt yaratildi
        MyClass A = new MyClass(100, 'A', "Alpha");
        Console.WriteLine("Obyekt A:  " + A); // ToString() orqali chiqariladi

        // int tipidan avtomatik MyClass obyektiga o‘tmoqda => implicit operator ishladi
        MyClass B = 200;
        Console.WriteLine("Obyekt B:   " + B);  // code = 200, symb = 'B', text = "Bravo"

        // char dan MyClass ga o'tish => bu explicit operator, shuning uchun (MyClass) deb yozilgan
        MyClass C = (MyClass)'C'; // code = 300, symb = 'C', text = "Charlie"
        Console.WriteLine("Obyekt C:   " + C);

        // string dan MyClass ga o'tish => implicit bo‘lgani uchun hech qanday kasting (MyClass) kerak emas
        MyClass D = "Delta"; // code = 5, symb = 'D', text = "Delta"
        Console.WriteLine("Obyekt D:    " + D);

        // MyClass dan oddiy turlarga o'tish (barchasi cast bilan)
        Console.WriteLine("Yana bir bor A obyekti:");
        Console.WriteLine("Butun son:  " + (int)A);    // code
        Console.WriteLine("Simvol:     " + (char)A); // symb
        Console.WriteLine("Matn:       " + (String)A); // text

        Console.WriteLine();
        Console.WriteLine("Boshqa amallar");

        // A + B => ikkala MyClass obyektidan int qiymat olinadi (implicit operator int)
        int n;
        n = A + B;  // int + int bo‘lib ishlaydi
        Console.WriteLine("A+B qiymati teng  " + n); // 100 + 200 = 300

        // B obyektidan char olib beriladi
        char s = B;
        Console.WriteLine("Simvol:  " + s); // 'B'

        // string "Echo" → MyClass (implicit), so'ngra → int (implicit)
        // "Echo" uzunligi = 4
        Console.WriteLine("Butun son:  " + (int)(MyClass)"Echo"); // natija: 4
    }
}
