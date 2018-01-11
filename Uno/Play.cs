using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class Play : Form
    {

        Card[] cardListRed = new Card[25];
        Card[] cardListYellow = new Card[25];
        Card[] cardListGreen = new Card[25];
        Card[] cardListBlue = new Card[25];
        Card[] cardListWilds = new Card[8];

        FileInfo[] files = new DirectoryInfo(@"C:\Users\Dell\Documents\Visual Studio 2017\Projects\Uno\Uno\Resources").GetFiles();
        


        public Play()
        {
            InitializeComponent();

            for(int i = 0; i < 24; i++)
            {
                cardListRed[i] = new Card(i, "Red");
            }

            for (int i = 0; i < 24; i++)
            {
                cardListYellow[i] = new Card(i, "Yellow");
            }

            for (int i = 0; i < 24; i++)
            {
                cardListGreen[i] = new Card(i, "Green");
            }

            for(int i = 0; i < 24; i++)
            {
                cardListBlue[i] = new Card(i, "Blue");
            }

            for (int i = 0; i < 7; i++)
            {
                cardListWilds[i] = new Card(10, "Wild");
            }

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int index = new Random().Next(0, files.Length);
            string cardFile = @"C:\Users\Dell\Documents\Visual Studio 2017\Projects\Uno\Uno\Resources\" + files[index].Name;
            string movedFileLocation = @"C:\Users\Dell\Documents\Visual Studio 2017\Projects\Uno\Uno\UsedResources\" + files[index].Name;

            do {
                try
                {
                    File.Move(cardFile, movedFileLocation);
                }
                catch (Exception)
                {
                    index = new Random().Next(0, files.Length);
                }
            }while(File.Exists(cardFile));

            btnCard.Image = Image.FromFile(movedFileLocation);
            
        }
    }
}
