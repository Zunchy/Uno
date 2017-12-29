using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class Play : Form
    {

        Card[] cardList = new Card[62];



        public Play()
        {
            InitializeComponent();

            for(int i = 0; i < 13; i++)
            {
                cardList[i] = new Card(i, "Red");
            }

            for (int i = 13; i < 26; i++)
            {
                cardList[i] = new Card(i, "Yellow");
            }
    
            for (int i = 26; i < 39; i++)
            {
                cardList[i] = new Card(i, "Green");
            }
             
            for (int i = 39; i < 52; i++)
            {
                cardList[i] = new Card(i, "Blue");
            }


            for (int i = 52; i < 56; i++)
            {
                cardList[i] = new Card(10, "Wild");
            }

            for (int i = 56; i < 61; i++)
            {
                cardList[i] = new Card(10, "Draw4");
            }

        }
    }
}
