using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.IO;

namespace UdpIp_lab
{
    public partial class Ohjelma1 : Form
    {
        public Ohjelma1()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = "No image.";
            this.toolStripSplitButton1.Enabled = false;
            this.printPictureToolStripMenuItem.Enabled = false;
            this.sendPictureToolStripMenuItem.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region OPEN_PICTURE...
        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenFileDialog-dialogi -> Haetaan kuva, joka viedään formissa olevaan PictureBox-komponenttiin.
            Stream fileStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\Mika\Downloads";
            openFileDialog1.Filter = "image files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.Multiselect = false;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (fileStream)
                        {
                            pictureBox1.ImageLocation = openFileDialog1.FileName;
                        }
                        this.toolStripStatusLabel1.Text = openFileDialog1.SafeFileName;
                        this.toolStripSplitButton1.Enabled = true;
                        this.printPictureToolStripMenuItem.Enabled = true;
                        this.sendPictureToolStripMenuItem.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("VIRHE:\n" + ex.Message);
                }
            }
        }
        #endregion

        private void printPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // PictureBox-komponenttiin ladattu kuva tulostetaan printterille.
        }

        private void sendPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ohjelma lähettää PictureBox-komponenttiin ladatun kuvan toiselle ohjelmalle UDP/IP-protokollan avulla.

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = null;
            this.toolStripSplitButton1.Enabled = false;
            this.toolStripStatusLabel1.Text = "No image.";
            this.printPictureToolStripMenuItem.Enabled = false;
            this.sendPictureToolStripMenuItem.Enabled = false;
        }
    }
}