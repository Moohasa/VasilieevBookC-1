using System;
class ForeachDemo
{
    static void Main(string[] args)
    {
        // butun sonli Massiv
        int[] nums = { 1, 3, 4, 8, 9 };
        // simvolli massiv
        char[] symbs = { 'a', 'b', 'A', 'B', 'Ы' };
        //tekstli massive
        String[] words = { "Qizil", "Sariq", "Ko'k" };
        Console.WriteLine("Butunsonli Massiv");
        foreach(int s in nums)
        {
            Console.WriteLine(" {0}  raqami - {1}", s, s%2==0?"juft son":"toq son");
        }
        Console.WriteLine();
        Console.WriteLine("simvolli massiv");
        foreach(char s in symbs)
        {
            Console.WriteLine("Simvol kodi  {0} - {1} ", s, (int)s);
        }
        Console.WriteLine();
        Console.WriteLine("Tekstli massiv");
        foreach(String s in words)
        {
            Console.WriteLine("\"{0}\" so'zda {1} harf mavjud", s, s.Length);

        }
        Console.WriteLine();
        Console.ReadLine();

    }

}