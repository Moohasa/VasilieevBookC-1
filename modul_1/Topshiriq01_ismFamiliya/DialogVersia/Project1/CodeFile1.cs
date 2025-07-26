using System.Windows.Forms;
using Microsoft.VisualBasic;
class Program
{
    static void Main()
    {
         // Ismni olish
        string ism = Interaction.InputBox("Ismingizni kiriting:", "Ism kiritish");

        // Familiyani olish
        string familiya = Interaction.InputBox("Familiyangizni kiriting:", "Familiya kiritish");

        // Natijani chiqarish
        MessageBox.Show($"Sizning ismingiz: {ism}\nFamiliyangiz: {familiya}", "Natija");


    }
}