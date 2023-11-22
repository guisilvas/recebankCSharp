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
    public partial class Form6 : Form
    {
        MySqlConnection Conexao;
        string dataSource = "datasource=localhost;username=root;password=root;database=recebankDB";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(dataSource);
                Conexao.Open();
                MessageBox.Show("Deu certo");

                MySqlCommand command = new MySqlCommand("SELECT name FROM user WHERE name = name", Conexao);
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
                Conexao.Close();
            }
        }

    private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
