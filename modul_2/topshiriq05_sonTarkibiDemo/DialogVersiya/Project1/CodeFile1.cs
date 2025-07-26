using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        string input = Microsoft.VisualBasic.Interaction.InputBox("Son kiriting:", "Minglik raqamini aniqlash");

        if (long.TryParse(input, out long number))
        {
            number = Math.Abs(number);
            long thousandsDigit = (number / 1000) % 10;
            MessageBox.Show($"Sonning mingliklar o'rni: {thousandsDigit}", "Natija");
        }
        else
        {
            MessageBox.Show("Iltimos, to'g'ri son kiriting.", "Xato");
        }
    }
}
