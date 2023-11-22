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
    public partial class Form5 : Form
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

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(dataSource);
                conexao.Open();

                MySqlCommand command = new MySqlCommand("SELECT name FROM user WHERE name = name",conexao);
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

    private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {

        }
    }
}
