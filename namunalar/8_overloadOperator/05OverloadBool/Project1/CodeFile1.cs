using System;
using System.Diagnostics.Eventing.Reader;

class MyClass
{
    public int code;

    // Konstruktor — code qiymatini o‘rnatish uchun
    public MyClass(int n)
    {
        code = n;
    }

    // 'true' operatorini overload qilish
    public static bool operator true(MyClass obj)
    {
        // ❓ Savol: Qachondan beri bool operator?
        // ➤ C#'da 'if', 'while' kabi shartli operatorlarda ishlatiladigan qiymat aslida 'bool' turida bo'lishi kerak.
        // ➤ Agar siz o‘zingiz yaratgan klassni 'if(obj)' yoki 'while(obj)' kabi yozmoqchi bo‘lsangiz — true/false operatorlarini overload qilishingiz kerak.

        // ➤ Bu yerda obyektning .code qiymati >= 5 bo‘lsa, u "true" deb baholanadi
        if (obj.code >= 5)
        {
            return true;
        }
        else
            return false;
    }

    // 'false' operatorini overload qilish
    public static bool operator false(MyClass obj)
    {
        // ❓ Savol: Nega murakkablashtirilmoqda?
        // ➤ Sababi: C# da 'if' yoki 'while' ishlaganda faqat 'true' emas, 'false' operatori ham mavjudligini talab qiladi.
        // ➤ Bu yerda 'false' operatori 'true' operatoriga teskari natija qaytaradi

        // Agar obj "true" bo‘lsa, demak bu yerda "false" qaytishi kerak
        if (obj)
        {
            return false;
        }
        else
            return true;
    }
}
class OverloadingTrueFalseDemo
{
    static void Main()
    {
        MyClass obj = new MyClass(10); // code = 10

        // Bu yerda 'obj' obyekt boolean qiymatga o‘xshab ishlatilmoqda
        // Bu faqat true/false operatorlari overload qilingani sababli ishlayapti
        while (obj)
        {
            Console.Write(obj.code + "   "); // 10, 9, 8, ..., 5

            obj.code--;  // ❓ Savol: Nega '--' overload qilinmasa ham ishlayapti?
            // ➤ Javob: obj.code — bu int tipidagi oddiy maydon.
            // ➤ int tipida '--' (decrement) operator allaqachon mavjud bo‘lgani uchun, bu int qiymatga ishlayapti.
            // ➤ Agar siz "obj--" (ya'ni butun obyektga) yozgan bo‘lsangiz, shunda alohida overload kerak bo‘lardi.
        }
    }
}
