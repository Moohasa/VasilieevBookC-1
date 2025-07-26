using System;
using System.Windows.Forms;

class Program
{
    [STAThread] // MessageBox учун керак
    static void Main()
    {
        try
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Iltimos, biror butun son kiriting:", "Son kiritish", "0");
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Hech qanday ma'lumot kiritilmadi.", "Xato");
                return;
            }

            int number = int.Parse(input);

            bool divisibleBy3 = (number % 3 == 0);
            bool divisibleBy7 = (number % 7 == 0);

            string message = $"Siz kiritgan son: {number}\n";

            if (divisibleBy3 && divisibleBy7)
                message += "Bu son 3 ga ham, 7 ga ham bo'linadi.";
            else if (divisibleBy3)
                message += "Bu son faqat 3 ga bo'linadi.";
            else if (divisibleBy7)
                message += "Bu son faqat 7 ga bo'linadi.";
            else
                message += "Bu son na 3 ga, na 7 ga bo'linadi.";

            MessageBox.Show(message, "Natija");
        }
        catch (FormatException)
        {
            MessageBox.Show("Iltimos, to'g'ri son kiriting!", "Xato");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Xatolik yuz berdi: " + ex.Message, "Xato");
        }
    }
}
