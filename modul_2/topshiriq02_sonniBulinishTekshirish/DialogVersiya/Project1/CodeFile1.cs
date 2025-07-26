using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Program
{
    [STAThread]
    static void Main()
    {
        string input = Interaction.InputBox("Son kiriting:", "Shartlarni tekshirish");

        if (int.TryParse(input, out int son))
        {
            if (son % 5 == 2 && son % 7 == 1)
            {
                MessageBox.Show($"{son} soni 5 ga bo‘lganda qoldiq 2 va 7 ga bo‘lganda qoldiq 1 beradi.", "Natija");
            }
            else
            {
                MessageBox.Show($"{son} soni shartlarga mos kelmaydi.", "Natija");
            }
        }
        else
        {
            MessageBox.Show("Iltimos, to‘g‘ri butun son kiriting!", "Xato");
        }
    }
}
