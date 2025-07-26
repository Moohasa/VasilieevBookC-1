using System;
class SortArrayDemo
{
    static void Main()
    {
        Console.WriteLine("massivni Tartiblash");
        Console.WriteLine();
        // simvolli o'zgaruvchi
        char s;
        // simvolli massiv
        char[] symbs = { 'Q', 'Ы', 'a', 'B', 'R', 'A', 'r', 'q', 'b' };
        // massiv ko'rinishi
        Console.WriteLine("massivni tartiblanmagan ko'rinishi");
        for (int i = 0; i < symbs.Length; i++)
        {
            Console.WriteLine(symbs[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        //massivni elementlarini tartiblash
        for (int i = 1; i < symbs.Length; i++)
        {
            // ELEMENTLARMI qayta tartiblash
            for (int j = 0; j < symbs.Length - i; j++)
            {
                //agar chapdagi element katta bo'lsa qiymat o'nga siljiydi
                if (symbs[j] > symbs[j + 1])
                {
                    s = symbs[j+1];
                    symbs[j+1] = symbs[j];
                    symbs[j] = s;
                }
            }
        }
        // tartiblangan massivni ko'rinishi
        Console.WriteLine("Tartiblashgan masssiv") ;
        for (int i = 0;i < symbs.Length; i++)
        {
            Console.WriteLine(symbs[i] + "  ") ;
        }
        Console.WriteLine();
    }
}