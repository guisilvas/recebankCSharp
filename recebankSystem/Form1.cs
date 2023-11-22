using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
     
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
 
            string cpf = txtLogin.Text;
            string pass = txtPass.Text;

            try
            {
                if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Os campos devem ser preenchidos.");
                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection(dataSource))
                    {
                        connection.Open();

                        string querySQL = "SELECT user_id, pass FROM user WHERE cpf = @cpf";
                        MySqlCommand command = new MySqlCommand(querySQL, connection);
                        command.Parameters.AddWithValue("@cpf", cpf);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int user_id = Convert.ToInt32(reader["user_id"]);
                                    string storedPass = reader["pass"].ToString();

                                    if (pass == storedPass)
                                    {
                                        Form3 newForm = new Form3();
                                        newForm.UserID = user_id;
                                        newForm.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Verifique os dados inseridos.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("CPF não encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 

        private void forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 abrirform2 = new Form2();
            abrirform2.ShowDialog();
        }
    }
}
