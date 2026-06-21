using Microsoft.Data.SqlClient;
using Modulo3.Forms;
using System.Data;

namespace Modulo3
{
    public partial class ConsultaMedico : Form
    {
        public ConsultaMedico()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

            conn.Open();

            string sql = @"SELECT CRM AS 'CRM do Médico', Nome, Sobrenome, Formacao AS 'Formação', Especialidade FROM Medicos;";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);

            dgvConsulta.DataSource = table;
        }

        private void lkPaciente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultaPaciente consulta = new ConsultaPaciente();

            consulta.Show();

            this.Hide();
        }

        private void lkNascimento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultaNascimento consulta = new ConsultaNascimento();

            consulta.Show();

            this.Hide();
        }

        private void lkEspecifico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultaEspecifica consulta = new ConsultaEspecifica();

            consulta.Show();

            this.Hide();
        }
    }
}
