using System;

class Program
{
    // Rekursiv metod: n gacha bo'lgan sonlar kvadratlar yig'indisi
    static int SumOfSquaresRecursive(int n)
    {
        Console.WriteLine($"Metod chaqirildi: n = {n}");

        // Bazaviy holat
        if (n <= 1)
        {
            Console.WriteLine($"Bazaviy holatga yetdik, n = {n}, natija = 1");
            return 1;
        }

        // Rekursiv chaqiriq
        int result = n * n + SumOfSquaresRecursive(n - 1);

        Console.WriteLine($"Natija hisoblandi: n = {n}, n^2 = {n * n}, yig'indiga qo'shildi, joriy natija = {result}");

        return result;
    }

    static void Main()
    {
        int n = 5;
        Console.WriteLine($"SumOfSquaresRecursive({n}) chaqirilmoqda...\n");

        int sum = SumOfSquaresRecursive(n);

        Console.WriteLine($"\nNatija: 1^2 + 2^2 + ... + {n}^2 = {sum}");
    }
}
/*Har chaqirilganda n qiymati konsolga chiqadi.

Bazaviy holatga yetganda xabar beradi va 1 ni qaytaradi.

Har bir qaytishda, ya’ni yuqoriga ko‘tarilayotganda, qanday hisoblanganini chiqaradi.

Mainda natija yakuniy ko‘rsatiladi.

Metod chaqirildi: n = 5
Metod chaqirildi: n = 4
Metod chaqirildi: n = 3
Metod chaqirildi: n = 2
Metod chaqirildi: n = 1
Bazaviy holatga yetdik, n = 1, natija = 1
Natija hisoblandi: n = 2, n^2 = 4, yig'indiga qo'shildi, joriy natija = 5
Natija hisoblandi: n = 3, n^2 = 9, yig'indiga qo'shildi, joriy natija = 14
Natija hisoblandi: n = 4, n^2 = 16, yig'indiga qo'shildi, joriy natija = 30
Natija hisoblandi: n = 5, n^2 = 25, yig'indiga qo'shildi, joriy natija = 55

Natija: 1^2 + 2^2 + ... + 5^2 = 55
Qachon va qaysi qiymat bilan metod chaqirilayotganini ko‘rasiz.

Qachon bazaviy holatga yetganini va nima qaytarayotganini ko‘rasiz.

Qaytishda natijalar qanday yig‘ilayotganini kuzatasiz.

*/