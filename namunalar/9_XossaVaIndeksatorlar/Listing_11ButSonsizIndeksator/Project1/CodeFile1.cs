using System;

// MyClass klassi
class MyClass
{
    public int code; // public butun sonli maydon

    // Konstruktor: obyekt yaratilganda code maydoniga qiymat beriladi
    public MyClass(int n)
    {
        code = n;
    }

    // ❗ Indeksator: int emas, MyClass obyektini indeks sifatida qabul qiladi
    public int this[MyClass obj]
    {
        // get - o'qish: ikkita obyektning code farqini qaytaradi
        get
        {
            return code - obj.code;
        }

        // set - yozish: boshqa obyektning code qiymatiga value ni qo‘shib, code ni yangilaydi
        set
        {
            code = obj.code + value;
        }
    }
}

// Sinov uchun demo klass
class NonIntIndeksDemo
{
    static void Main()
    {
        // A obyektini yaratamiz va code = 100
        MyClass A = new MyClass(100);
        Console.WriteLine("Obyekt A:  {0}", A.code);

        // B obyektini yaratamiz va code = 150
        MyClass B = new MyClass(150);
        Console.WriteLine("Obyekt B:  {0}", B.code);

        // ❗ A obyektini B orqali indekslaymiz: A[B] = A.code - B.code = 100 - 150 = -50
        int num = A[B];
        Console.WriteLine("Ifoda A[B]:  {0}", num);  // -50

        // ❗ B obyektini A orqali indekslaymiz: B[A] = 150 - 100 = 50
        Console.WriteLine("Ifoda B[A]:  {0}", B[A]); // 50

        // ❗ A[B] = 200: bu set{} chaqiradi → A.code = B.code + 200 = 150 + 200 = 350
        A[B] = 200;

        // Endi A.code 350 bo‘ldi
        Console.WriteLine("Obyekt A:  {0}", A.code);  // 350
    }
}
