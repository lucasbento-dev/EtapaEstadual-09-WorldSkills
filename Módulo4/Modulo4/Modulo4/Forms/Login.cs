using Microsoft.Data.SqlClient;
using Modulo4.Forms;

namespace Modulo4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Os dados devem estar preenchidos");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"SELECT * FROM Funcionarios f LEFT JOIN Medicos m ON m.Id_funcionario = f.Id_funcionario WHERE Email = @Email AND Senha = @Senha;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (string.IsNullOrEmpty(Convert.ToString(reader["Id_medico"])))
                    {
                        Dashboard dashboard = new Dashboard();

                        dashboard.Show();

                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não possui acesso à aplicação");
                        break;
                    }
                }

                reader.Close();

                if (string.IsNullOrEmpty(Convert.ToString(cmd.ExecuteScalar())))
                {
                    MessageBox.Show("Informações incorretas");
                }
            }
        }
    }
}
