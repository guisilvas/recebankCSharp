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
using MySql.Data.MySqlClient;

namespace recebankSystem
{
    public partial class Form4 : Form
    {
        MySqlConnection Conexao;
        string dataSource = "datasource=localhost;username=root;password=;database=recebankDB";
        int id = 0;
        string name = "";
        string cpf = "";
        string birthDate = "";
        string phone = "";
        string state = "";
        string city = "";
        string income = "";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(dataSource);
                Conexao.Open();
                MessageBox.Show("Deu certo");

                //string sql = "SELECT * FROM user WHERE id = 'id'"
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

        private void cmbCpf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
