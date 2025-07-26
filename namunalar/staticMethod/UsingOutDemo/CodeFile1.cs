using System;
class UsingOutDemo
{
    static int getMin(int[] n, out int index)
    {
        index = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] < n[index])
            {
                index = i;
            }
        }
        return n[index];

    }
    static void Main()
    {
        int[] A = { 12, 7, 8, 3, 8, 4, 1, 3, 4, 1, 7, 15 };
        foreach (int i in A)
        {
            Console.Write("|  {0}", i);
        }
        Console.WriteLine("|");

        int val, k;
        val = getMin(A, out k);
        Console.WriteLine("eng kichik qiymat  " + val);
        Console.WriteLine("qiymat indeksi:   " + k);
        Console.WriteLine("tekshirish:   A[{0}] = {1}", k, A[k]);
    }
}