using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recebankSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form4 abrirform4 = new Form4();
            abrirform4.ShowDialog();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 abrirform5 = new Form5();
            abrirform5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 abrirform6 = new Form6();
            abrirform6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 abrirform7 = new Form7();
            abrirform7.ShowDialog();
        }
    }
}
