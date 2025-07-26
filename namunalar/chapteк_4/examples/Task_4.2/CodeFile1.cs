using System;
class Task_2
{
    static void Main(string[] args)
    {
        int p = 0, a = 10;
        int[] twoPow = new int[a];
        Console.WriteLine("ikkini darajalari");
        for (int i = 0; i <= twoPow.Length; i++)
        {
            p*=2;

            if (p == 0) { p = 1; }
            Console.WriteLine("ikkini {0} chi darajasi {1} ga teng  ",  i, p);
        }
        
        }
}