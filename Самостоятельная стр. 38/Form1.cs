using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Самостоятельная_стр._38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum Дни_недели { Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье};
        private void button1_Click(object sender, EventArgs e)
        {
            Дни_недели day = (Дни_недели)comboBox1.SelectedIndex;
            switch(day)
            {
                case Дни_недели.Понедельник:
                    label1.Text = "Понедельник";
                    break;
                case Дни_недели.Вторник:
                    label1.Text = "Вторник";
                    break;
                case Дни_недели.Среда:
                    label1.Text = "Среда";
                    break;
                case Дни_недели.Четверг:
                    label1.Text = "Четверг";
                    break;
                case Дни_недели.Пятница:
                    label1.Text = "Пятница";
                    break;
                case Дни_недели.Суббота:
                    label1.Text = "Суббота";
                    break;
                case Дни_недели.Воскресенье:
                    label1.Text = "Воскресенье";
                    break;
                default:
                    label1.Text = "Пустота и тоска";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
