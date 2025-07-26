using System;

class Program
{
    static void Main()
    {
        object[] data = { 1, "salom", 3.14, true };
        int externalValue = 5;

        int original = 0;
        bool found = false;

        // 1. int tipidagi birinchi elementni topamiz
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] is int)
            {
                original = (int)data[i];
                found = true;
                break;
            }
        }

        if (found)
        {
            int newValue = original + externalValue;

            // 2. Yangi object[] yaratamiz: eski uzunlik + 1
            object[] newData = new object[data.Length + 1];

            // 3. Eski elementlarni yangi massivga nusxalash (qo‘lda)
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }

            // 4. Oxiriga yangi qiymatni qo‘shamiz
            newData[data.Length] = newValue;

            // 5. Chiqarish
            Console.WriteLine("Yangi massiv:");
            for (int i = 0; i < newData.Length; i++)
            {
                Console.WriteLine(newData[i]);
            }
        }
        else
        {
            Console.WriteLine("int turidagi element topilmadi.");
        }
    }
}
