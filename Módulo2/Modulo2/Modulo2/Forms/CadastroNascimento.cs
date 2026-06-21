using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Modulo2.Forms
{
    public partial class CadastroNascimento : Form
    {
        public CadastroNascimento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtRegistro.Text) || string.IsNullOrEmpty(txtPeso.Text) || string.IsNullOrEmpty(txtTamanho.Text) || string.IsNullOrEmpty(Convert.ToString(dtpData.Value)) || string.IsNullOrEmpty(txtPeso.Text) || string.IsNullOrEmpty(txtObservacoes.Text) || string.IsNullOrEmpty(txtPaciente.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"INSERT INTO Nascimentos (Registro, CPFMae, Peso, Tamanho, DataNascimento, HoraNascimento, ObservacoesRelevantes, Id_paciente)
                VALUES
                (@Registro, @CPFMae, @Peso, @Tamanho, @DataNascimento, @HoraNascimento, @ObservacoesRelevantes, @Id_paciente);";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CPFMae", txtCPF.Text);
                cmd.Parameters.AddWithValue("@Registro", txtRegistro.Text);
                cmd.Parameters.AddWithValue("@Peso", Convert.ToDecimal(txtPeso.Text));
                cmd.Parameters.AddWithValue("@Tamanho", Convert.ToDecimal(txtTamanho.Text));
                cmd.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime((dtpData.Value).ToShortDateString));
                cmd.Parameters.AddWithValue("@HoraNascimento", Convert.ToDateTime((dtpData.Value).ToShortTimeString));
                cmd.Parameters.AddWithValue("@ObservacoesRelevantes", txtObservacoes.Text);
                cmd.Parameters.AddWithValue("@Id_Paciente", Convert.ToInt32(txtPaciente.Text));

                cmd.ExecuteNonQuery();
            }
        }

        private void CadastroNascimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();

            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegistro.Text))
            {
                MessageBox.Show("Registro deve ser preenchido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"UPDATE Nascimentos SET Registro = @Registro, CPFMae = @CPFMae, Peso = @Peso, Tamanho = @Tamanho, DataNascimento = @DataNascimento, HoraNascimento = @HoraNascimento, ObservacoesRelevantes = @ObservacoesRelevantes, Id_paciente = @Id_paciente WHERE Registro = @Registro;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CPFMae", txtCPF.Text);
                cmd.Parameters.AddWithValue("@Registro", txtRegistro.Text);
                cmd.Parameters.AddWithValue("@Peso", Convert.ToDecimal(txtPeso.Text));
                cmd.Parameters.AddWithValue("@Tamanho", Convert.ToDecimal(txtTamanho.Text));
                cmd.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime((dtpData.Value).ToShortDateString));
                cmd.Parameters.AddWithValue("@HoraNascimento", Convert.ToDateTime((dtpData.Value).ToShortTimeString));
                cmd.Parameters.AddWithValue("@ObservacoesRelevantes", txtObservacoes.Text);
                cmd.Parameters.AddWithValue("@Id_Paciente", Convert.ToInt32(txtPaciente.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Alteração Salva com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegistro.Text))
            {
                MessageBox.Show("Registro deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"Tem Certeza que deseja Excluir {txtRegistro.Text}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"DELETE Medicos WHERE Registro = @Registro;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Registro", txtRegistro.Text);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
