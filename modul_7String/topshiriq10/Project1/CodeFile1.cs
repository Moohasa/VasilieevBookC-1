using System;

class IntArrayHolder
{
    private int[] numbers;  // Butun sonlar massiviga havola

    // Konstruktor, massiv uzunligi argument sifatida olinadi
    public IntArrayHolder(int size)
    {
        numbers = new int[size];
        Random rnd = new Random();

        // Massivni tasodifiy sonlar bilan to'ldiramiz (masalan 0 dan 99 gacha)
        for (int i = 0; i < size; i++)
        {
            numbers[i] = rnd.Next(100);
        }
    }

    // ToString metodini qayta aniqlash
    public override string ToString()
    {
        // Elementlar yig'indisini hisoblaymiz
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        // O'rtacha qiymat
        double average = (numbers.Length > 0) ? (double)sum / numbers.Length : 0;

        // Massiv elementlarini vergul bilan ajratilgan holda satrga aylantirish
        string elementsText = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            elementsText += numbers[i];
            if (i < numbers.Length - 1)
                elementsText += ", ";
        }

        // Natija satri
        string result = $"Massiv elementlari: [{elementsText}]\n";
        result += $"Elementlar soni: {numbers.Length}\n";
        result += $"Elementlar o'rtacha qiymati: {average:F2}";

        return result;
    }
}

class Program
{
    static void Main()
    {
        IntArrayHolder obj = new IntArrayHolder(10);
        Console.WriteLine(obj);
    }
}
