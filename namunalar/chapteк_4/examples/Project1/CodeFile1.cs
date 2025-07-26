using System;
class ArrayRandomTest
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] tasodidfiy = new int[10];
        char [] Symbs = new char[10];
        for (int i = 0; i < tasodidfiy.Length; i++)
        {
            tasodidfiy[i] = random.Next(1,100);
    
        }
        for (int i = 0;i < tasodidfiy.Length; i++) {
            Console.WriteLine(i + " " + tasodidfiy[i]);
        }
    }
    
}