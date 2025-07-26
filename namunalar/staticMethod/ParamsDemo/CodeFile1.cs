using System;
class ParamsDemo
{
    //yig'gindilarni hisoblaydigon metod
    static int sum(params int[] a)
    {
        //lokal o'zgaruvchi(yig'indi boshlang'ich qiymati)
        int res = 0;
        // metod argumeti tartiblash
        for (int i = 0; i < a.Length; i++)
        {
            res += a[i];
        }
        //metod natijalari
        return res;
    }
    //matndan belgilarni ajratib oluvchi metod
    static string getText(string m, params int[] a)
    {
        // matn qatorini boshlang'ich quymati
        string res = "";
        //metod argumentini tatrtiblash
        for (int i = 0; i < a.Length; i++)
        {
            res += m[a[i]];
        }
        return res;
    }
    //argumentlarni chop etuvchi metod
    static void print(int[] a, params char[] b)
    {
        //sonli massivda elementlar miqdori
        Console.Write("sonlar:  " + a.Length + "  ");
        //sonli massivda elementlar qiymati
        for (int i = 0; i < a.Length - 1; i++)
        {
            Console.Write(a[i] + "  ");
        }
        Console.WriteLine("va  " + a[a.Length-1] + " ");
        //belgili massiv
        Console.Write("beligilar "+ b.Length + " ");
        for (int i = 0; i < b.Length -1; i++)
        {
            Console.Write(b[i] + "  ");
        }
        Console.WriteLine("va " + b[b.Length - 1] + " ");
    }
    static void Main()
    {
        //metodni chqirish namunalari
        //sonlarni yig'indisini hisoblash
        Console.WriteLine("Sonlaarni yig'indisi " + sum(1, 6,9, 2, 4));
        Console.WriteLine("sonlar yig'indisi  " + sum(5, 1, 2));
        //matnni formatlash
        Console.WriteLine(getText("Раз два три  ", 0,10,8,1));
        Console.WriteLine(getText("Бревно  ", 3, 5, 1, 5, 4));
        //argumentlarni chop etish
        print(new int[] { 1, 3, 5 }, 'A', 'B', 'C', 'D', 'E' );
        print(new int[] { 1, 3, 5, 7, 9 }, 'A', 'B', 'C','D');

    }
}
