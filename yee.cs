using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double ph;
        string str, caption = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox5.Image = new Bitmap("WinXP.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = new Bitmap("WinXP.jpg");
            Stretch();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = new Bitmap("Win7.jpg");
            Stretch();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = new Bitmap("Win10.jpg");
            Stretch();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = new Bitmap("Win11.jpg");
            Stretch();
        }

        private void Stretch()
        {
            for(int h=0; h < 177; h += 5)
            {
                pictureBox5.Size = new Size(298, h);
                DateTime now = DateTime.Now;
                do
                {
                    Application.DoEvents();
                }while((DateTime.Now - now).TotalSeconds < 0.1);
            }

        }

    }
}
