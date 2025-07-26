using System;
class KopOlchamliMassiv
{
    static void Main()
    {
        //uch o'lchamli simvolli massiv
        char[,,] symbs = new char[4,4,5];
        //bir o'lchamli simvolli massiv
        char [] s = { 'б', 'Б', 'b', 'B' };
        // uch o'lchamli massivni elementlar bilan to'ldirish 
        //va uni chop etish
        //birinchi indeks uchun sikl
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            // qavatni chop etish
            Console.WriteLine("{0}  - qavat ", i+1);
            //ikkinchi qavat uchun sikl
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                // uchinchi sikl
                for (int k = 0; k < symbs.GetLength(2); k++)
                {
                    //massiv elementlariga qiymat tayinlash
                    symbs[i, j, k] = s[i];
                    //bir o'lchamli massiv elementlrini o'zgartirsh
                    s[i]++;
                    //elementlarni chop etish
                    Console.Write(symbs [i, j, k ]+ "  ");

                }
                //keyingi qatorga o'tish
                Console.WriteLine();
            }
            //chegarani chizish
            Console.WriteLine("___________________");

        }
    }
}