using System;

class MyClass
{
    // MyClass klassida ikkita maydon bor: butun son va belgili qiymat
    public int code;
    public char symb;

    // Konstruktor: obyekt yaratilganda unga qiymatlar berish imkonini beradi
    public MyClass(int n, char s)
    {
        code = n;
        symb = s;
    }

    // GetHashCode metodi: obyektning unikal raqamini (hash code) hisoblaydi
    // Bu asosan obyektni hashtable yoki dictionary ichida ajratish uchun kerak
    public override int GetHashCode()
    {
        // code va symb qiymatlarini XOR qilib hash qaytarayapti
        return code ^ symb;
    }

    // Equals metodi: ikkita obyekt tengligini solishtirish uchun
    public override bool Equals(object obj)
    {
        // object tipidagi obj parametrini MyClass tipiga "cast" qilyapmiz
        // (MyClass)obj — bu **downcasting** deyiladi
        MyClass t = (MyClass)obj;

        // if ichida solishtirilayotgan mezonlar:
        // - agar `code` lar teng bo‘lsa
        // - va `symb` lar teng bo‘lsa
        // — demak obyektlar bir xil
        if (code == t.code && symb == t.symb)
        {
            return true;
        }
        return false;
    }

    // == operatorini overload qilish: bu operator endi Equals metodiga tayandi
    public static bool operator ==(MyClass a, MyClass b)
    {
        return a.Equals(b);
    }

    // != operatorini overload qilish: == natijasini inkor qiladi
    public static bool operator !=(MyClass a, MyClass b)
    {
        return !(a == b);
    }
}
class OverridingEqualDemo
{
    static void Main()
    {
        // 4 ta MyClass obyekti yaratamiz, ularning qiymatlari har xil
        MyClass A = new MyClass(100, 'A');
        MyClass B = new MyClass(100, 'B');
        MyClass C = new MyClass(200, 'A');
        MyClass D = new MyClass(100, 'A');

        // Har bir obyektning hash-kodini chiqaramiz
        // (Xuddi shaxsiy identifikatorga o‘xshaydi)
        Console.WriteLine("A Hesh-kodi: {0}", A.GetHashCode());
        Console.WriteLine("B Hesh-kodi: {0}", B.GetHashCode());
        Console.WriteLine("C Hesh-kodi: {0}", C.GetHashCode());
        Console.WriteLine("D Hesh-kodi: {0}", D.GetHashCode());

        // Obyektlar tengligini solishtiramiz: == va != orqali
        Console.WriteLine("A==B natijasi:    {0}", A == B); // False (symb farq qiladi)
        Console.WriteLine("A!=B natijasi:    {0}", A != B); // True

        Console.WriteLine("A==C natijasi:    {0}", A == C); // False (code farq qiladi)
        Console.WriteLine("A!=C natijasi:    {0}", A != C); // True

        Console.WriteLine("A==D natijasi:    {0}", A == D); // True (code va symb teng)
        Console.WriteLine("A!=D natijasi:    {0}", A != D); // False
    }
}
