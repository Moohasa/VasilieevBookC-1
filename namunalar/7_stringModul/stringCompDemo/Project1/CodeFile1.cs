using System;

class CompStringDemo
{
    // Qo‘lda yozilgan stringlarni taqqoslash funksiyasi
    static bool StrCmp(String X, String Y)
    {
        // Uzunligi teng bo‘lmasa, teng emas
        if (X.Length != Y.Length) { return false; }

        // Har bir belgini taqqoslaymiz
        for (int i = 0; i < X.Length; i++)
        {
            if (X[i] != Y[i]) { return false; } // Belgilar bir-biriga teng bo‘lmasa — false
        }

        return true; // Hammasi teng bo‘lsa — true
    }

    static void Main()
    {
        // Belgilar massivi
        char[] smb = { 'C', '#', ' ', 'T', 'i', 'l', 'i' };

        // A: oddiy string
        String A = "C# Tili";
        Console.WriteLine("A:  \"{0}\"", A); // C# Tili

        // B: char[] massivdan string yaratildi
        String B = new String(smb);
        Console.WriteLine("B:  \"{0}\"", B); // C# Tili

        // C: C harfi kirillcha bilan yozilgan (visually almost identical to Latin C)
        String C = "С# Tili"; // ❗ Bu yerda 'C' harfi kirill alifbosidagi 'С' (U+0421)
        Console.WriteLine("C:  \"{0}\"", C); // С# Tili (ko‘rinishda farq sezilmaydi, lekin aslida boshqa)

        Console.WriteLine("Qatorlarni Tenglashtirish");

        // A == B → Ha, bu yerda matnlar bir xil (va bir xil turlardan)
        Console.WriteLine("A==B:  {0}", A == B); // True

        // O‘zimiz yozgan solishtirish metodi bilan
        Console.WriteLine("StrCmp(A, B): {0}", StrCmp(A, B)); // True

        // A == C → ❌ noto‘g‘ri, chunki bu yerda 'C' va 'С' (kirill) harflari farq qiladi
        Console.WriteLine("A==C: {0}", A == C); // False

        // Qo‘lda taqqoslaganda ham xuddi shunday
        Console.WriteLine("StrCmp(A, C): {0}", StrCmp(A, C)); // False

        // B != C → ha, turlicha
        Console.WriteLine("B!=C: {0}", B != C); // True

        // A ni "C#" bilan taqqoslash → uzunligi turlicha
        Console.WriteLine("StrCmp(A, \"C#\"): {0}", StrCmp(A, "C#")); // False
    }
}
