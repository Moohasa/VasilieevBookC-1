using System;
class ObjectArrayDemo
{
    static void Main()
    {
        // object tipdagi 3 o'lchamli massiv
        Object[] objs = new Object[3];
        //massiv elelmentlari 3  boshqa boshqa turda bo'ladi
        objs[0] = 123;                 //butunsonli tur
        objs[1] = 'A';                 //simvoll
        objs[2] = "uchinchi element";  //tekst
        Console.WriteLine("Massiv yaratoldi");
        //massiv tarkibini tekshirish
        for (int i = 0; i < objs.Length; i++)
        {
            Console.WriteLine(i + ":  " + objs[i]);

        }
        // elementlarning yangi qiymatlari
        objs[0] = (int)objs[0] + 111; // butun son
        objs[1] = "ikkinchi element"; //tekst
        objs[2] = 3.141552;          // haqiqiy son
        Console.WriteLine("massivni yangi qiymatlangandan so'ng");
        for (int i = 0; i < objs.Length; i++)
        {
            Console.WriteLine(i + ":  " + objs[i]);

        }
        //butun son massivi
        int[] nums = { 10, 20, 30 };
        //massivni object ga nusxa olamiz
        objs[2] = nums;
        Console.WriteLine("butun somli massiv");
        for (int i = 0;i < ((int[])objs[2]).Length; i++)
        {
            Console.Write("{0, 3}", ((int[])objs[2])[i]);

        }
        Console.WriteLine();

    }
}