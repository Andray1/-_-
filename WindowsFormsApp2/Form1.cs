using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            openFileDialog1.Filter = "Изображения (*.bmp;*.gif;*.jpg;*.jpeg;*.tif)|";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
