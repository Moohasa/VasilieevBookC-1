using System.Windows.Forms;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        string haftaKuni = Interaction.InputBox("Hafta kunini kiriting:", "Hafta kuni");
        string oyNomi = Interaction.InputBox("Oy nomini kiriting:", "Oy nomi");
        string sana = Interaction.InputBox("Oydagi sanani kiriting (raqam):", "Sana");

        MessageBox.Show($"Bugungi sana: {haftaKuni}, {sana} {oyNomi}", "Natija");
    }
}
