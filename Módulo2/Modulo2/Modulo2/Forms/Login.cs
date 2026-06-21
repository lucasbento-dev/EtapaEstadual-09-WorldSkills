using Microsoft.Data.SqlClient;
using Modulo2.Forms;

namespace Modulo2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

            conn.Open();

            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string sql = @"SELECT * FROM Funcionarios f WHERE f.Email = @Email;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                if (cmd.ExecuteScalar() != DBNull.Value)
                {
                    string sqlSenha = @"SELECT * FROM Funcionarios f WHERE f.Email = @Email AND f.Senha = @Senha;";

                    SqlCommand cmdSenha = new SqlCommand(sqlSenha, conn);

                    cmdSenha.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmdSenha.Parameters.AddWithValue("@Senha", txtSenha.Text);

                    if (cmdSenha.ExecuteScalar() != DBNull.Value)
                    {
                        MessageBox.Show("Boas vindas", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CadastroPaciente paciente = new CadastroPaciente();

                        paciente.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Email não cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
