using System;
class GotoDemo
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine()), k = 1, s = 0;
        Console.Write("yig'indi = 1 + 3 + 5 + ... + {0} =  ", 2 * n - 1);
    mylabel:
        s += 2 * k - 1;
        k++;
        if (k<=n) goto mylabel;
        Console.WriteLine(s);
    }
}