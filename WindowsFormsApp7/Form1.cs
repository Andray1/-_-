using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Зима.jpg");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Весна.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Лето.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Осень.jpg");
                    break;

            }
        }
    }
}
