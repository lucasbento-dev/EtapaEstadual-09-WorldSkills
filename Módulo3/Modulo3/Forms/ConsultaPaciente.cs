using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Modulo3.Forms
{
    public partial class ConsultaPaciente : Form
    {
        public ConsultaPaciente()
        {
            InitializeComponent();
        }

        private void ConsultaPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ConsultaPaciente_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

            conn.Open();

            string sql = @"SELECT p.CPF, p.Nome, p.Sobrenome, p.Idade, p.ALtura, p.Peso, p.TipoParto AS 'Tipo de Parto', m.Nome AS 'Nome do Médico' FROM Pacientes p INNER JOIN Medicos m ON m.Id_medico = p.Id_medico;";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);

            dgvConsulta.DataSource = table;
        }

        private void lkMedico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultaMedico consulta = new ConsultaMedico();

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
