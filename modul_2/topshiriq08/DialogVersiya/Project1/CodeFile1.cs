using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        string input = Interaction.InputBox("Butun son kiriting:", "3-bitni 1 qilish");

        if (int.TryParse(input, out int number))
        {
            int newNumber = number | (1 << 2);

            string message = $"Yangi son: {newNumber}\nBinary ko‘rinishi: {Convert.ToString(newNumber, 2).PadLeft(8, '0')}";
            MessageBox.Show(message, "Natija");
        }
        else
        {
            MessageBox.Show("Iltimos, butun son kiriting.", "Xatolik");
        }
    }
}
