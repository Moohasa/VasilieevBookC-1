using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
class YoshAniqlash
{
    static void Main()
    {
        string yoshText;
        int yil = 2024,  yosh, tugilganYil;
        yoshText = Interaction.InputBox(" tug'ilgan yilingizni kiriting",
            "yilni kiritish");
        tugilganYil = Int32.Parse(yoshText);
        yosh = yil - tugilganYil;
        MessageBox.Show("sizning yoshingiz  " + yosh + " da",
              "sizning yoshingiz");



    }
}