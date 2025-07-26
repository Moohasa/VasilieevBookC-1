using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Interaction uchun

class Program
{
    [STAThread]  // Kerak, chunki Windows Forms ishlatilyapti
    static void Main()
    {
        string input = Interaction.InputBox("Son kiriting:", "3 ga bo‘linishini tekshirish");

        if (int.TryParse(input, out int son))
        {
            if (son % 3 == 0)
            {
                MessageBox.Show($"{son} soni 3 ga bo'linadi.", "Natija");
            }
            else
            {
                MessageBox.Show($"{son} soni 3 ga bo'linmaydi.", "Natija");
            }
        }
        else
        {
            MessageBox.Show("Iltimos, to‘g‘ri butun son kiriting!", "Xato");
        }
    }
}
