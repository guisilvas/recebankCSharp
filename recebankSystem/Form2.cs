using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace recebankSystem
{
    public partial class Form2 : Form
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
        string dataSource = "datasource=localhost;username=root;password=root;database=recebankDB";

        //ID do produto
        int productID = 1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(dataSource);
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                // preparando o INSERT no bando de dados
                cmd.CommandText = "INSERT INTO user (name, cpf, birth_date, state, city, phone, pass) VALUES (@name, @cpf, @birth_date, @state, @city, @phone, @pass)";

                // adicionando os parametros no banco de dados
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@birth_date", txtDate.Text);
                cmd.Parameters.AddWithValue("@state", lbState.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                //cmd.Parameters.AddWithValue("@income", txtIncome.Text);

                // executando a query no sql
                cmd.ExecuteNonQuery();

                // deu certo
                MessageBox.Show("Usuário registrado com sucesso!");

                this.Hide();
                Form1 openform1 = new Form1();
                openform1.ShowDialog();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txNomeReg_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
