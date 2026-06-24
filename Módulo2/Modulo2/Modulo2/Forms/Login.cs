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
            SqlConnection conn = new SqlConnection("Data Source=SEN577809\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

            conn.Open();

            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }
            else
            {
                string sql = @"SELECT Id_funcionario FROM Funcionarios WHERE Email = @Email AND Senha = @Senha";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

                if (string.IsNullOrEmpty(Convert.ToString(cmd.ExecuteScalar())))
                {
                    MessageBox.Show("Senha inválida.");
                }
                else
                {
                    CadastroMedico medico = new CadastroMedico();

                    medico.Show();

                    this.Hide();
                }
            }
        }
    }
}
