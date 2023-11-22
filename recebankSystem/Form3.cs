using MySql.Data.MySqlClient;
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
        //Pegando o userID
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private int userID;

        //Conexão com o banco
        MySqlConnection conexao;
        string dataSource = "datasource=localhost;username=root;password=;database=recebankDB";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            Form4 abrirform4 = new Form4();
            abrirform4.ShowDialog();
            Application.Exit();
            this.Hide();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Form5 abrirform5 = new Form5();
            abrirform5.ShowDialog();
            this.Hide();
        }

        private void btnFinancing_Click(object sender, EventArgs e)
        {
            Form6 abrirform6 = new Form6();
            abrirform6.ShowDialog();
            this.Hide();
        }

        private void btnInsurence_Click(object sender, EventArgs e)
        {
            Form7 abrirform7 = new Form7();
            abrirform7.ShowDialog();
            this.Hide();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            userID = 0;
            Form1 abrirform1 = new Form1();
            abrirform1.ShowDialog();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form8 abrirform8 = new Form8();
            abrirform8.ShowDialog();
            this.Hide();
        }
    }
}
