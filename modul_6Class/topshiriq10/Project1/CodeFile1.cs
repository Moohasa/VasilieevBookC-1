using System;

class MathApproximations
{
    // Faktoriyalni hisoblovchi yordamchi metod
    private static long Factorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    // Kosinusni Taylor qatori bo'yicha hisoblash
    // cos(x) = 1 - x^2/2! + x^4/4! - x^6/6! + ... + ((-1)^n)*(x^(2n))/(2n)!
    public static double Cos(double x, int nTerms)
    {
        double sum = 0;
        for (int n = 0; n < nTerms; n++)
        {
            // (-1)^n
            double sign = (n % 2 == 0) ? 1 : -1;

            // x^(2n)
            double power = Math.Pow(x, 2 * n);

            // (2n)!
            long fact = Factorial(2 * n);

            sum += sign * power / fact;
        }
        return sum;
    }

    // Giperbolik sinusni hisoblash
    // sh(x) = x + x^3/3! + x^5/5! + ... + x^(2n+1)/(2n+1)!
    public static double Sh(double x, int nTerms)
    {
        double sum = 0;
        for (int n = 0; n < nTerms; n++)
        {
            // x^(2n+1)
            double power = Math.Pow(x, 2 * n + 1);

            // (2n+1)!
            long fact = Factorial(2 * n + 1);

            sum += power / fact;
        }
        return sum;
    }

    // Giperbolik kosinusni hisoblash
    // ch(x) = 1 + x^2/2! + x^4/4! + ... + x^(2n)/(2n)!
    public static double Ch(double x, int nTerms)
    {
        double sum = 0;
        for (int n = 0; n < nTerms; n++)
        {
            // x^(2n)
            double power = Math.Pow(x, 2 * n);

            // (2n)!
            long fact = Factorial(2 * n);

            sum += power / fact;
        }
        return sum;
    }
}
/*
 Factorial metodi:

Factorial(int n) — berilgan n uchun n! (faktoriyal) ni hisoblaydi.

Misol: 5! = 12345 = 120.

Bu qiymatlarni Cos, Sh, Ch funksiyalarida formulalar uchun kerak bo‘ladi.

Cos metodi:

Cos(double x, int nTerms) — Taylor qatori yordamida kosinus qiymatini hisoblaydi.

Har bir qo‘shiladigan had quyidagicha: ((-1)^n) * x^(2n) / (2n)!.

nTerms — qatorning qancha elementini hisoblashni belgilaydi (necha marta aylanish).

Sh metodi (Giperbolik sinus):

Sh(double x, int nTerms) — hyperbolic sinus qiymatini hisoblaydi.

Formulaga ko‘ra: x + x^3/3! + x^5/5! + ....

Har bir qo‘shiladigan had: x^(2n+1)/(2n+1)!.

Ch metodi (Giperbolik kosinus):

Ch(double x, int nTerms) — hyperbolic cosinus qiymatini hisoblaydi.

Formulaga ko‘ra: 1 + x^2/2! + x^4/4! + ....

Har bir qo‘shiladigan had: x^(2n)/(2n)!.

Main metodi:

x = 1.0 qiymati uchun har uchala funksiyani hisoblaydi.

terms = 10 — ya’ni Taylor qatorining 10 ta elementi hisobga olinadi, bu aniq natija beradi.

So‘ngra natijalarni standart .NET kutubxona funksiyalari bilan taqqoslab beradi.
 */
class Program
{
    static void Main()
    {
        double x = 1.0; // hisoblash uchun argument (radianlarda)

        int terms = 10; // qatordagi elementlar soni (qancha ko'p, shuncha aniq)

        Console.WriteLine($"Cos({x}) = {MathApproximations.Cos(x, terms)}");
        Console.WriteLine($"Sh({x}) = {MathApproximations.Sh(x, terms)}");
        Console.WriteLine($"Ch({x}) = {MathApproximations.Ch(x, terms)}");

        // Taqqoslash uchun standart kutubxona funksiyalari
        Console.WriteLine($"Math.Cos({x}) = {Math.Cos(x)}");
        Console.WriteLine($"Math.Sinh({x}) = {Math.Sinh(x)}");
        Console.WriteLine($"Math.Cosh({x}) = {Math.Cosh(x)}");
    }
}
