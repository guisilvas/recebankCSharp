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
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        string dataSource = "datasource=localhost;username=root;password=;database=recebankDB";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(dataSource);

                //string sql = "SELECT * FROM user WHERE id = 'id'"

                Conexao.Open();
                MessageBox.Show("Deu certo");
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
    }
}
