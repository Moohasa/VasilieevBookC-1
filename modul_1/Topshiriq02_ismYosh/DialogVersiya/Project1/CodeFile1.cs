using System.Windows.Forms;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        string ism = Interaction.InputBox("Ismingizni kiriting:", "Ism kiritish");
        string yosh = Interaction.InputBox("Yoshingizni kiriting:", "Yosh kiritish");

        MessageBox.Show($"Sizning ismingiz: {ism}, yoshingiz: {yosh} da", "Natija");
    }
}
