using System;
class ArrayFromMethodDemo
{
    //fibonache sonlarini qaytaradigon massivli metod
    static int [] fibonace(int n)
    {
        //massive yaratiladi
        int[] numsFib = new int[n];
        //massivni 0 chi elementi 1 ga teng bo'ladi
        numsFib[0] = 1;
        //agar fibonache sonida 2 chi element bo'lsa u 1 ga teng 
        if (numsFib.Length == 1)
        {
            return numsFib;
        }
        numsFib[1] = 1;
        //massivni qolgan elementlarini to'ldirish sikli
        for (int i = 2; i < numsFib.Length; i++)
        {
            // element qiymati o'zidan oldingi qiymatlarni 1 ga va 2 ga ayirmasini
            //yig'gindisiga teng bo'ladi
            numsFib[i] = numsFib[i - 1] + numsFib[i - 2];
        }
        //metod natijasi massivgaga havola beriladi
        return numsFib;
    }
    // elementlari tasodifiy belgilar to'ldirilgan massivni qaytaruvchi 
    //metod yaratish
    static char[] symbs(int n)
    {
        //tasodifiy qiymatlarni beruvchi obyekt chaqiramiz
        Random r = new Random();
        //massivni yaratish
        char[] blgs = new char[n];
        //massivni sikl yordamida to'ldirish
        for (int i = 0; i < blgs.Length; i++)
        {
            //massiv elemenlari tasodifiy belgilar iborat bo'ladi
            blgs[i] = (char)('A' + r.Next(26));
        }
        //metod natijasi massivga havolasi
        return blgs;

    }
    //elementlari toq butun sonli
    //ikki o'lchamli massiv metodi
    static int[,] odds(int n, int m)
    {
        //ikki o'lchamli massiv yaratiladi
        int[,] oddNums = new int[n, m]; 
        //lokal ozgaruvchi elon qilinadi
        int val = 1;
        // massiv sikl yordamida to'ldiriladi
        //massiv qatorlari uchun
        for (int i = 0; i < oddNums.GetLength(0); i++)
        {
            //massiv ustunlari uchun
            for (int j = 0; j < oddNums.GetLength(1); j++)
            {
                //element qiymati qiymatlanadi
                oddNums[i, j] = val;
                // qiymat keyingi elementga toq songa oshiriladi
                val +=2;
            }
        }
        //metod natijasi massivga havolanadi
        return oddNums;
    }
    //dastur bosh metodi
    static void Main()
    {
        //butun sonli massivga o'zgaruvchi
        int[] A;
        //belgili massivga o'zgaruvchi 
        char[] B;
        //ikki o'lchamili butunsonli massivga o'zgaruvchi
        int[,] C;
        //A massivini fibonachi sonlari bilan to'ldirish
        A = fibonace(10);
        //masissivni foreach sikli yordamida chop etish
        Console.WriteLine("fibonache sonlari:");
        foreach (int s in A)
        {
            Console.Write("|  {0}  ", s);

        }
        Console.WriteLine();
        // tasodifiy qiymatli b massivini toldirish
        B = symbs(10);
        //massivni chop  etish
        Console.WriteLine("tasodifiy belgilar");
        foreach(char s in B)
        {
            Console.Write("| {0}  ", s);

        }
        Console.WriteLine();
        // 4X6 ikki o'lchamli massivni toq sonlar bilan to'ldiramiz
        C = odds(4, 6);
        //massivni chop etish
        Console.WriteLine("ikki o'lchamli massiv");
        for (int i = 0;i < C.GetLength(0);i++)
        {
            for (int j = 0; j < C.GetLength(1); j++)
            {
                Console.Write("{0, 4}", C[i, j]);
            }
            Console.WriteLine() ;   
        }
    }
}