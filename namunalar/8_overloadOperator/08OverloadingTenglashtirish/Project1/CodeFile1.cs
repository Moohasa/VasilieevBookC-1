using System;

class MyClass
{
    public int code;

    // Konstruktor – obyekt yaratilganda 'code' qiymatini o'rnatadi
    public MyClass(int n)
    {
        code = n;
    }

    // '+' operatorini overload qilish – ikki obyektni qo‘shib, yangi obyekt qaytaradi
    public static MyClass operator +(MyClass x, MyClass y)
    {
        return new MyClass(x.code + y.code); // qo‘shilgan qiymat bilan yangi obyekt
    }

    // '*' operatorini overload qilish – bu safar int qiymat qaytaradi
    public static int operator *(MyClass x, MyClass y)
    {
        return x.code * y.code; // int natija qaytadi
    }

    // Implicit konvertatsiya: int -> MyClass
    // Masalan: MyClass m = 10; // bu holatda implicit ishlaydi
    public static implicit operator MyClass(int n)
    {
        return new MyClass(n); // int qiymatdan MyClass obyekti yaratadi
    }
}
class OverloadingAndAssigningDemo
{
    static void Main()
    {
        MyClass A = new MyClass(7); // code = 7
        Console.WriteLine("A obyekt:  {0}", A.code);

        MyClass B = new MyClass(8); // code = 8
        Console.WriteLine("B obyekt:   {0}", B.code);

        // A += B; — bu aynan shunday: A = A + B;
        // operator+ mavjud bo‘lgani uchun bu ishlaydi
        A += B;
        Console.WriteLine("A obyekt    {0}", A.code); // 7 + 8 = 15

        // A *= B; => A = A * B; bu yerda operator* int qaytaradi,
        // lekin A tipida int saqlanmaydi. SHUNING UCHUN:
        // int natijani MyClass ga implicit orqali konvertatsiya qiladi
        // ya'ni: A = (MyClass)(A * B);
        A *= B;
        Console.WriteLine("A Obyekt:  {0}", A.code); // 15 * 8 = 120
    }
}
