using System.Windows.Forms;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        string oy = Interaction.InputBox("Oy nomini kiriting:", "Oy nomi");
        string kunlar = Interaction.InputBox("Oyda nechta kun bor?", "Kunlar soni");

        if (oy == "" || kunlar == "")
        {
            MessageBox.Show("Iltimos, barcha ma'lumotlarni kiriting.", "Xatolik");
        }
        else
        {
            MessageBox.Show($"{oy} oyida {kunlar} kun bor.", "Natija");
        }
    }
}
