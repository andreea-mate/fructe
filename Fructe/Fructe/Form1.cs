using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fructe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnClick.BackColor = Color.Black;
            btnClick.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.AliceBlue)
                this.BackColor = Color.Aqua;
            else
                this.BackColor = Color.AliceBlue;
        }
        DialogResult t;

        private void button2_Click(object sender, EventArgs e)
        {
            t = MessageBox.Show("Sigur doriti sa parasiti aplicatia?", "Exit", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           pictureBox2.Image = Properties.Resources.zmeura;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.capsuna;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.cirese;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
