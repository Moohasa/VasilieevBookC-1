using System;
class ProArgsDemo
{
    static void Main(string[] args) {
        //kerakli miqdorda parametrlar aniqlanadi
        Console.WriteLine("{0} paramaterlar jo'natildi" , args.Length);
        // parametr miqdorlarini chop etish
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("{0}  -  parametr  {1}", (i+1), args[i] );
        }
        Console.WriteLine("dastur nixoyasiga yetdi");
    }
}