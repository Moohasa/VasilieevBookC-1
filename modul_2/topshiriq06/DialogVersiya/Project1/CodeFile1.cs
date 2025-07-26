using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        string input = Microsoft.VisualBasic.Interaction.InputBox("Son kiriting (o'nlik):", "Sakkizlik raqam tekshiruvi");

        if (int.TryParse(input, out int number))
        {
            if (number < 0)
            {
                MessageBox.Show("Iltimos, manfiy bo'lmagan son kiriting.", "Xato");
                return;
            }

            string octal = Convert.ToString(number, 8);

            if (octal.Length >= 2)
            {
                char secondFromRight = octal[octal.Length - 2];
                MessageBox.Show(octal);              
                MessageBox.Show($"Sakkizlik ko'rinishda o'ngdan ikkinchi raqam: {secondFromRight}", "Natija");
            }
            else
            {
                MessageBox.Show("Sakkizlik ko'rinishda o'ngdan ikkinchi raqam mavjud emas.", "Natija");
            }
        }
        else
        {
            MessageBox.Show("Iltimos, to'g'ri butun son kiriting.", "Xato");
        }
    }
}
