using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label1.Visible = true;
                    label1.Text = "Зима";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Зима.jpg");
                    break;
                case 1:
                    label1.Visible = true;
                    label1.Text = "Зима";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Зима.jpg");
                    break;
                case 2:
                    label1.Visible = true;
                    label1.Text = "Весна";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Весна.jpg");
                    break;
                case 3:
                    label1.Visible = true;
                    label1.Text = "Весна";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Весна.jpg");
                    break;
                case 4:
                    label1.Visible = true;
                    label1.Text = "Весна";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Весна.jpg");
                    break;
                case 5:
                    label1.Visible = true;
                    label1.Text = "Лето";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Лето.jpg");
                    break;
                case 6:
                    label1.Visible = true;
                    label1.Text = "Лето";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Лето.jpg");
                    break;
                case 7:
                    label1.Visible = true;
                    label1.Text = "Лето";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Лето.jpg");
                    break;
                case 8:
                    label1.Visible = true;
                    label1.Text = "Осень";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Осень.jpg");
                    break;
                case 9:
                    label1.Visible = true;
                    label1.Text = "Осень";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Осень.jpg");
                    break;
                case 10:
                    label1.Visible = true;
                    label1.Text = "Осень";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Осень.jpg");
                    break;
                case 11:
                    label1.Visible = true;
                    label1.Text = "Зима";
                    pictureBox1.Image = Image.FromFile(@"d:\Users\Студент\source\repos\Умматов_Конюхов\Materials\Зима.jpg");
                    break;
            }
        }
    }
}
