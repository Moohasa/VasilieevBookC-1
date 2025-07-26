using System;
class StatMethodDemo
{
    //static metod tekstni chop etish uchun
    //qavs ichida argument 
    static void print(string txt)
    {
        Console.WriteLine(txt);
    }
    //yana bir static metod faktorialni hisoblab beruvchi
    //metodni yo'naltiruvchi argument bilan
    static int factorial(int n)
    {
        //lokal o'zgaruvchi yaratiladi
        int a = 1;
        // hisoblash sikli
        for (int i = 1; i <= n; i++) {
            a *= i;
        }
        //metodni qaytuvchi natijasi
        return a;
    }
    //sonni darjafga ko'taruvchi static metod
    // son va daraja ko'rsatkichi metodni argumentiga yo'naltiriladi
    static double power(double x, int n) 
    {
        //lokal o'zgaruvchilar(daraja miqdori)
        double s = 1;
        //natijani hisoblash
        for(int i = 0;i < n;i++)
        {
            s *= x;
        }
        //metodni qaytuvchi natijasi
        return s;

    }
    //dasturni bosh metodi
    static void Main()
    {
        //static metodlani bir boshdan chaqiramiz
        //konsolga tekst chop etishdan boshlaymiz
        print("hisoblaymiz");
        int m = 5;
        double n = 3;
        //faktorialni hisoblovchi static metodni
        //chop etuvchi metod argumentiga chaqiramiz
        print(m + "  ni faktoriali   " + factorial(m));
        // darjani hisoblovchi metod ham huddi shu zaylda
        print(n + "  ni " + m + "  chi  darajasi   " + power(n, m));
    }
}