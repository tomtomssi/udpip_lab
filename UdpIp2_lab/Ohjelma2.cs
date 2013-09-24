using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpIp2_lab
{
    /*
     * Ohjelma odottaa ohjelman 1 lähettämää kuvaa. Kun kuva otetaan vastaan se viedään PictureBox-komponenttiin.
     */
    public partial class Ohjelma2 : Form
    {
        public Ohjelma2()
        {
            InitializeComponent();
        }

        private void savePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ohjelma tallentaa PictureBox-komponentissa olevan kuvan kiintolevylle halutussa formaatissa (bmp, jpeg, gif, png jne.)
        }
    }
}
