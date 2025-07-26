using System;
class Task4_3
{
    static void Main()
    {
        int b = 13; char c = 'A';
        char[] a = new char[b];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = c++;
            c++;
            Console.Write(a[i]+"  ");
        }
        Console.WriteLine();
        Console.WriteLine();

        for (int i = a.Length - 1; i >= 0; i--)
        {
            Console.Write(a[i]+"  ");
        }
    }
}