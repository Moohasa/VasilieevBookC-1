using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        string input = Interaction.InputBox("Son kiriting (o'nlik):", "Bit tekshiruvi");

        if (int.TryParse(input, out int number))
        {
            int thirdBit = (number >> 2) & 1;
            MessageBox.Show($"Sonning o'ngdan uchinchi biti: {thirdBit}", "Natija");
        }
        else
        {
            MessageBox.Show("Iltimos, to'g'ri butun son kiriting.", "Xato");
        }
    }
}
