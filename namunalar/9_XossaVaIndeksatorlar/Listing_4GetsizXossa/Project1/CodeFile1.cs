using System;

// MyClass nomli klass e'lon qilinmoqda
class MyClass
{
    // xususiy (private) string maydon – binary kod shu yerda saqlanadi
    private string code;

    // ToString() metodi obyektni matn shaklida ifodalashga xizmat qiladi
    // Bu metod override bo‘lgan – ya'ni System.Object'dagi versiyasini almashtiryapti
    public override string ToString()
    {
        return code; // obyekt ekranga chiqarilganda, code matni chiqadi
    }

    // number xossasi — faqat yozish (set) mumkin, o‘qib bo‘lmaydi
    public uint number
    {
        set
        {
            // Kiritilgan son value orqali olinadi va local o‘zgaruvchiga beriladi
            uint num = value;
            code = ""; // oldingi kodni tozalaymiz

            // Sonni 2lik (binar) kodga aylantirish
            do
            {
                code = (num % 2) + code; // qoldiqni oldinga qo‘shib boramiz
                num >>= 1;               // num ni o‘ngga siljitamiz (ya'ni 2 ga bo‘lamiz)
            }
            while (num != 0); // num nol bo‘lguncha davom etadi
        }
    }

    // Konstruktor — obyekt yaratishda boshlang‘ich son qabul qiladi
    public MyClass(uint n)
    {
        number = n; // bu orqali set ishlaydi va code generatsiya bo‘ladi
    }
}
class WithoutGetdemo
{
    static void Main()
    {
        // son bilan obyekt yaratildi — konstruktor orqali set ishladi
        MyClass obj = new MyClass(Convert.ToUInt32(Console.ReadLine()));

        // son ning 2lik ko‘rinishini konsolga chiqaramiz (obj orqali ToString() chaqiriladi)
        Console.WriteLine(" soninni binar codi\t" + obj);

        // Endi xossaga 45 soni yoziladi — faqat set ishlaydi
        obj.number = 45;

        // Yangi 2lik kod ToString() orqali konsolga chiqariladi
        Console.WriteLine("45 sonini binar kodi\t" + obj);
    }
}
