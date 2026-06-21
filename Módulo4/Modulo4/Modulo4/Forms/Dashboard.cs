using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modulo4.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

            conn.Open();

            string sql = @"SELECT COUNT(f.Id_funcionario) AS 'Administração', COUNT(m.Id_funcionario) AS 'Médicos' FROM Funcionarios f LEFT JOIN Medicos m ON m.Id_funcionario = f.Id_funcionario;";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            Series series = new Series();

            series.ChartType = SeriesChartType.Column;

            while (reader.Read())
            {
                series.Points.AddXY("Administrativo", Convert.ToInt32(reader["Administração"]) - Convert.ToInt32(reader["Médicos"]));
                series.Points.AddXY("Saúde", Convert.ToInt32(reader["Médicos"]));

                break;
            }

            chartFuncionarios.Series.Clear();

            chartFuncionarios.Series.Add(series);

            reader.Close();

            string sqlConsultas = @"SELECT m.Nome AS 'Médico Responsável', p.Nome AS 'Nome da Mãe', n.Peso AS 'Peso (kg)', n.Tamanho AS 'Tamanho (m)', n.DataNascimento AS 'Data de Nascimento', n.HoraNascimento AS 'Hora de Nascimento', n.ObservacoesRelevantes AS 'Observações Relevantes' FROM Nascimentos n INNER JOIN Pacientes p ON p.Id_paciente = n.Id_paciente INNER JOIN Medicos m ON m.Id_medico = p.Id_medico;";

            SqlCommand cmdConsultas = new SqlCommand(sqlConsultas, conn);

            SqlDataReader readerConsultas = cmdConsultas.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(readerConsultas);

            dgvConsulta.DataSource = table;

            readerConsultas.Close();

            string sqlPartos1 = @"SELECT COUNT(*) AS 'Quantidade' FROM Pacientes WHERE TipoParto = 'Normal';";
            string sqlPartos2 = @"SELECT COUNT(*) AS 'Quantidade' FROM Pacientes WHERE TipoParto = 'Cesárea';";

            SqlCommand cmdPartos1 = new SqlCommand(sqlPartos1, conn);
            SqlCommand cmdPartos2 = new SqlCommand(sqlPartos2, conn);
            

            Series seriesPartos1 = new Series();

            seriesPartos1.ChartType = SeriesChartType.Pie;

            chartPartos.Series.Clear();

            seriesPartos1.Points.AddXY("Normal", Convert.ToInt32(cmdPartos1.ExecuteScalar()));

            seriesPartos1.Points.AddXY("Cesárea", Convert.ToInt32(cmdPartos2.ExecuteScalar()));

            chartPartos.Series.Add(seriesPartos1);
        }

        private void TextChanged_txtBusca(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

            conn.Open();

            string sqlConsultas = @"SELECT m.Nome AS 'Médico Responsável', p.Nome AS 'Nome da Mãe', n.Peso AS 'Peso (kg)', n.Tamanho AS 'Tamanho (m)', n.DataNascimento AS 'Data de Nascimento', n.HoraNascimento AS 'Hora de Nascimento', n.ObservacoesRelevantes AS 'Observações Relevantes' FROM Nascimentos n INNER JOIN Pacientes p ON p.Id_paciente = n.Id_paciente INNER JOIN Medicos m ON m.Id_medico = p.Id_medico WHERE p.Nome = @Nome;";

            SqlCommand cmdConsultas = new SqlCommand(sqlConsultas, conn);

            cmdConsultas.Parameters.AddWithValue("@Nome", txtBusca.Text + "%");

            SqlDataReader readerConsultas = cmdConsultas.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(readerConsultas);

            dgvConsulta.DataSource = table;
        }
    }
}
