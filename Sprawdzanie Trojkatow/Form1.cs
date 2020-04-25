using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprawdzanie_Trojkatow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLiczenie_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt16(textBoxBokPierwszy.Text);
            y = Convert.ToInt16(textBoxBok2.Text);
            z = Convert.ToInt16(textBoxBok3.Text);

            if (x >= (y + z) || y >= (x + z) || z >= (x + y))
            {
                MessageBox.Show("Trójkąt nie istnieje!!!");
            }
            else
            {
                if (((x * x) + (y * y) > (z * z)) && ((y * y) + (z * z) > (x * x)) && ((x * x) + (z * z) > (y * y)))
                {
                    MessageBox.Show("Trójkat jest ostrokątny.");
                }


                if (((x * x) + (y * y) < (z * z)) || ((y * y) + (z * z) < (x * x)) || ((x * x) + (z * z) < (y * y)))
                {
                    MessageBox.Show("Trójkat jest rozwartokątny.");
                }

                if (((x * x) + (y * y) == (z * z)) || ((y * y) + (z * z) == (x * x)) || ((x * x) + (z * z) == (y * y)))
                {
                    MessageBox.Show("Trójkat jest prostokątny.");
                }

                if ((x == y) && (x == z) && (y == z))
                {
                    MessageBox.Show("Dodatkowo, ten trójkat jest równoboczny.");
                }
            }
        }

        private void twórcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program stworzony przez Bartłomieja Modliszewskiego.");
        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxBokPierwszy.Text = "0";
            textBoxBok2.Text = "0";
            textBoxBok3.Text = "0";
        }
    }
}
