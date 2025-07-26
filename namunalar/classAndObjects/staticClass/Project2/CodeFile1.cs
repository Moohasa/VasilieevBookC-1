using System;

// Matematik funksiyalarni o‘zimiz yozadigan klass
class MyMath
{
    // O‘zgarmas qiymat — doimiy (pi = 3.141592)
    public const double pi = 3.141592;

    // Static butun sonli maydon — formulalar aniqligi uchun nechta had olishni bildiradi
    private static int N = 100;

    // Euler soni (e^x) ni hisoblaydigan metod
    public static double exp(double x)
    {
        double s = 0;  // yig‘indi (e^x natijasi shu yerga yig‘iladi)
        double q = 1;  // har bir had (q) bu yerda keyingi qiymatga o‘tadi

        for (int k = 0; k <= N; k++)  // 0 dan N-gacha hadlar yig‘iladi
        {
            s += q;                  // q ni s ga qo‘shamiz
            q *= x / (k + 1);        // keyingi hadni tayyorlaymiz: q * (x / (k+1))
        }

        return s;  // hisoblangan e^x qiymatini qaytaramiz
    }

    // sin(x) ni Taylor qatorlari yordamida hisoblaydigan metod
    public static double sin(double x)
    {
        double s = 0;    // yig‘indi
        double q = x;    // sin(x) ning birinchi hadi — x

        for (int k = 0; k <= N; k++)
        {
            s += q;
            // keyingi had: (-1)*x^2/(2k+2)(2k+3)
            q *= (-1) * x * x / (2 * k + 2) / (2 * k + 3);
        }

        return s;
    }
}

// Asosiy klass, bu yerda kod ishga tushadi
class StaticDemo
{
    static void Main()
    {
        double z = 1;

        // Tayyor Math kutubxonasidan e^1 hisoblayapmiz
        Console.WriteLine("exp({0}) = {1}", z, Math.Exp(z));

        // O‘zimiz yozgan metod orqali exp(1) hisoblayapmiz
        Console.WriteLine("kontrol qiymat :  {0}", MyMath.exp(z));

        // Pi/4 bu 45 gradus (sin uchun yaxshi burchak)
        z = MyMath.pi / 4;

        // O‘zimizning sin() metodimiz orqali hisoblash
        Console.WriteLine("exp({0}) = {1}", z, MyMath.sin(z));

        // Tayyor Math.Sin yordamida tekshirib ko‘ramiz
        Console.WriteLine("kontrol qiymat :  {0}", Math.Sin(z));
    }
}
/*
 Nima	Nega static?
pi (const)	Bu doimiy qiymat, hamma uchun umumiy. Obyekt yaratmasdan ishlatiladi.
N	Bu — faqat formulalarga tegishli ichki parametr, umumiy bo‘lishi kerak.
exp(double x)	Bu metod obyektga bog‘liq emas, ya’ni har qanday son uchun hisoblash funksiyasi. Obyekt yaratib o‘tirmaymiz.
sin(double x)	Xuddi yuqoridagi kabi. Umumiy matematik hisob-kitob, obyektga bog‘liq emas.

🧠 Nima uchun static to‘g‘ri tanlov bu yerda?
Bu metodlar holat (state) saqlamaydi — faqat kiritilgan qiymatga javob qaytaradi.

Sizga bu funksiyalarni chaqirish uchun obyekt yaratish hech qanday foyda bermaydi, faqat ortiqcha ish.

Har doim bir xil kirish → bir xil chiqish.

🎯 Real hayotdagi o‘xshatish:
Agar MyMath — kalkulyator bo‘lsa, unda sin(x) yoki exp(x) — tugmani bosish. Siz kalkulyatorning yangi nusxasini yaratib, har safar Sin tugmasini bosmaysiz, bir tugma hamma uchun ishlaydi.

✅ Yakuniy xulosa:
static — umumiy, holatsiz (stateless) funksiyalar uchun ideal.

Matematik hisob-kitob, log-funktsiyalar, trigonometrik funksiya, o‘zgaruvchisiz metodlar uchun ishlatiladi.

Math klassi (standart .NET klassi) ham aynan shunday ishlaydi — barcha metodlari static.

Agar xohlasangiz:

cos(x) yoki tan(x) ham qo‘shib ko‘rishimiz mumkin,

Yoki sin va exp ni grafiga chiqarish yoki tayyor metodlar bilan solishtirish aniqligi bo‘yicha test yozishimiz mumkin.

Qanday davom etamiz? 
 */