using System;
class ArgsDemo
{
    //birinchi metod. argumenti butun son
    static void alpha(int n)
    {
        //argument tekshirish uchun chop etish
        Console.WriteLine("alfa() metodi. chiqish  " +  n);
        //miqdorni o'zgartishga uruinish
        n++;
        //miqdor o'zgargandan so'ng qayta tekshirish
        Console.WriteLine("alfa() metodi. chiqish  " + n);

    }
    //ikkinchi metod. argumenti massivga havola
    static void bravo(int[] n)
    {
        //massiv tarkibini tekshirish
        Console.WriteLine("bravo() metodi. chiqish  " + ArrayToText(n));//ArrayToText qaytaruvchi metod keyinroq yoziladi
        //massivni elementlarini tartiblash uchun sikl
        for (int i = 0; i < n.Length; i++)
        {
            //massiv elementini miqdorini o'zgartirishga urunush
            n[i]++;
        }
        //massiv miqdorini qayta tekshirish
        Console.WriteLine("bravo metodi. chiqish:  " + ArrayToText(n)); 
    }
    //uchinchi metod. argumenti massivga havola
    static void charlie(int[] n)
    {
        //massiv tarkibini tekshirish
        Console.WriteLine("charlie() metodi. chiqish:  " + ArrayToText(n));
        //yangi massiv yaratish
        int[] m = new int[n.Length];
        //elementlarni tartiblash uchun sikl
        for (int i = 0; i < n.Length; i ++)
        {
            m[i] = n[i] + 1;
        }
        //yangi miqdorni argumentga tenglashga urinish
        n=m;
        //metodni tekshirish
        Console.WriteLine("charlie() metodi. chiqish:  " + ArrayToText(n));
    }
    //massivni chop etuvchi ArrayToText()ni yaratish
    static string ArrayToText(int[] n)
    {
        //matnli o'zgaruvchi elon qilamiz
        string res = "[" + n[0];
        //elementlarni tartiblaymiz(0 chi indeksdan tashqari)
        for (int i = 1; i < n.Length; i++)
        {
            //matnni matnli o'zgaruvchida yozish
            res += "," + n[i];

        }
        res = res + "]";
        return res;
    }
    
    
    
    static void Main()
    {
        //Argumentni uzatish uchun o'zgaruvchi
        int A = 100;
        Console.WriteLine("alfa() metodigacha A = " +  A);
        //metodni chaqirish
        alpha(A);
        Console.WriteLine("alfa() metodi chaqirilgandan so'ng A =  " + A);
        //Argumentga uzatish uchun massiv
        int[] B = { 1, 3, 5 };
        //tekshirish
        Console.WriteLine("bravo() metodigacha B = " + ArrayToText(B));
        //metodni chaqirish
        bravo(B);
        //metod chaqirilgandan keyin tekshirish
        Console.WriteLine("bravo() metodidan so'ng B = " + ArrayToText(B) );
        //metodga uzatish uchun ikkinchi C massivi
        int[] C = { 2, 4, 6 };
        Console.WriteLine("charlie() metodigacha C = " + ArrayToText(C));
        charlie(C);
        Console.WriteLine("charlie metodi chaqirilgandan so'ng C = " + ArrayToText(C));

    }
}
/*chiqish:
 * alfa() metodigacha A = 100
alfa() metodi. chiqish  100
alfa() metodi. chiqish  101
alfa() metodi chaqirilgandan so'ng A =  100
bravo() metodigacha B = [1,3,5]
bravo() metodi.chiqish[1, 3, 5]
bravo metodi. chiqish: [2,4,6]
bravo() metodidan so'ng B = [2,4,6]
charlie() metodigacha C = [2,4,6]
charlie() metodi.chiqish:  [2,4,6]
charlie() metodi.chiqish:  [3,5,7]
charlie metodi chaqirilgandan so'ng C = [2,4,6]
Для продолжения нажмите любую клавишу . . .

 o'zgaruvchi miqdorlari faqatgina metod ichida o'zgargan
Main() dastur bosh metodi o'zgarmay qolyapdi. dastur to'gri ishlashi uchun 
keyingi RefArgsDemo dasturiga qaralsin
 */