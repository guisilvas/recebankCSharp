using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace recebankSystem
{
    public partial class Form4 : Form
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

        //ID do produto
        int productID = 1;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(dataSource);
                conexao.Open();
                MessageBox.Show("Deu certo");

                MySqlCommand command = new MySqlCommand("SELECT name FROM user WHERE name = name", conexao);
                command.Parameters.AddWithValue("@id", 1);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Preencha a textLabel com o dado
                        lblName.Text = reader["name"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 openform3 = new Form3();
            openform3.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection(dataSource);
            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao;

            // preparando o INSERT no bando de dados
            cmd.CommandText = "INSERT INTO user_product (user_id, product_id) VALUES (@userID, @productID)";
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@productID", productID);

            // executando a query no sql
            cmd.ExecuteNonQuery();

            // deu certo
            MessageBox.Show("Produto requerido com sucesso!");

            this.Hide();
            Form3 openform3 = new Form3();
            openform3.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
