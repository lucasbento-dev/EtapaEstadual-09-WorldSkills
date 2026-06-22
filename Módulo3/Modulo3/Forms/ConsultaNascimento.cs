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
    public partial class ConsultaNascimento : Form
    {
        public ConsultaNascimento()
        {
            InitializeComponent();
        }

        private void ConsultaNascimento_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

            conn.Open();

            string sql = @"SELECT n.Registro, n.CPFMae AS 'CPF da Mãe', n.Peso, n.Tamanho, n.DataNascimento AS 'Data de Nascimento', n.HoraNascimento AS 'Hora de Nascimento', n.ObservacoesRelevantes AS 'Observações Relevantes', p.Nome AS 'Nome da Mãe/Paciente' FROM Nascimentos n INNER JOIN Pacientes p ON p.Id_paciente = n.Id_paciente;";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);

            dgvConsulta.DataSource = table;
        }

        private void ConsultaNascimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lkMedicos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultaMedico consulta = new ConsultaMedico();

            consulta.Show();

            this.Hide();
        }

        private void lkPaciente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultaPaciente consulta = new ConsultaPaciente();

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
