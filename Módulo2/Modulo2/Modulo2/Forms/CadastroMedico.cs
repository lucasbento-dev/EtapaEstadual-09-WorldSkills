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
    public partial class CadastroMedico : Form
    {
        public CadastroMedico()
        {
            InitializeComponent();
        }

        private void CadastroMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();

            this.Hide();
        }

        string caminhoFoto = "";

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofd.FileName);
                caminhoFoto = ofd.FileName;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoFoto) || string.IsNullOrEmpty(txtCRM.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtFormacao.Text) || string.IsNullOrEmpty(txtEspecialidade.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"INSERT INTO Medicos (CRM, NomeCompleto, Formacao, Especialidade, FotoPerfil)
                VALUES
                (@CRM, @NomeCompleto, @Formacao, @Especialidade, @FotoPerfil);";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CRM", txtCRM.Text);
                cmd.Parameters.AddWithValue("@NomeCompleto", txtNome.Text);
                cmd.Parameters.AddWithValue("@Formacao", txtFormacao.Text);
                cmd.Parameters.AddWithValue("@Especialidade", txtEspecialidade.Text);

                byte[] foto = File.ReadAllBytes(caminhoFoto);
                cmd.Parameters.AddWithValue("@FotoPerfil", foto);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Processo Cadastrado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCRM.Text))
            {
                MessageBox.Show("CRM deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"UPDATE Medicos SET CRM = @CRM, NomeCompleto = @NomeCompleto, Formacao = @Formacao, Especialidade = @Especialidade, FotoPerfil = @FotoPerfil;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CRM", txtCRM.Text);
                cmd.Parameters.AddWithValue("@NomeCompleto", txtNome.Text);
                cmd.Parameters.AddWithValue("@Formacao", txtFormacao.Text);
                cmd.Parameters.AddWithValue("@Especialidade", txtEspecialidade.Text);

                byte[] foto = File.ReadAllBytes(caminhoFoto);
                cmd.Parameters.AddWithValue("@FotoPerfil", foto);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Alteração Salva com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCRM.Text))
            {
                MessageBox.Show("CRM deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"Tem Certeza que deseja Excluir {txtCRM.Text}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"DELETE Medicos WHERE CRM = @CRM;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CRM", txtCRM.Text);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
