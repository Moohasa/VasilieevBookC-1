/// <summary>
/// Bu statik metod berilgan matndan (text) belgi (symbol) qayerda uchrayotganini aniqlaydi.
/// Natijada massiv qaytaradi: har bir element bu belgining matndagi pozitsiyasi (indeksi).
/// Agar belgi matnda yo‘q bo‘lsa, {-1} elementli massiv qaytariladi.
/// </summary>
using System;

class SymbolIndexFinder
{
    // Statik metod: matndan belgi indekslarini topadi
    public static int[] FindSymbolIndexes(string text, char symbol)
    {
        int[] temp = new int[text.Length];  // Maksimal o‘lchamli vaqtinchalik massiv
        int count = 0; // Nechta moslik topilganini hisoblaydi

        // Matnni boshidan oxirigacha ko‘rib chiqamiz
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == symbol)
            {
                temp[count] = i; // Belgining joylashgan indeksini saqlaymiz
                count++;         // Mosliklar sonini oshiramiz
            }
        }

        // Agar belgi topilmagan bo‘lsa, {-1} qaytaramiz
        if (count == 0)
        {
            return new int[] { -1 };
        }

        // Ayni topilgan indekslar soniga teng yangi massiv yasaymiz
        int[] result = new int[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = temp[i]; // Mos indekslarni yangi massivga nusxalaymiz
            // yoki tartib bilan birdan boshlab sanaymiz
            
        }

        return result; // Natijani qaytaramiz
    }

    static void Main()
    {
        Console.Write("Matn kiriting: ");
        string inputText = Console.ReadLine();

        Console.Write("Qaysi belgini qidiramiz: ");
        char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int[] positions = FindSymbolIndexes(inputText, symbol);

        Console.WriteLine($"\n\"{symbol}\" belgisi indekslari:");

        foreach (int pos in positions)
        {
            Console.Write(pos + " ");
        }

        Console.WriteLine();
    }
}
