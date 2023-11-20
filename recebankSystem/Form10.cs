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
    public partial class Form10 : Form
    {
        MySqlConnection Conexao;

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                string dataSource = "dataSource=localhost;username=root;password;database=recebankDB;";
                Conexao = new MySqlConnection(dataSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
