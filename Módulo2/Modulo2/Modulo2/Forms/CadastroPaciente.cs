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
    public partial class CadastroPaciente : Form
    {
        public CadastroPaciente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();

            this.Hide();
        }

        private void CadastroPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            if (string.IsNullOrEmpty(caminhoFoto) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtSobrenome.Text) || string.IsNullOrEmpty(txtIdade.Text) || string.IsNullOrEmpty(txtAltura.Text) || string.IsNullOrEmpty(txtPeso.Text) || string.IsNullOrEmpty(cbTipo.Text) || string.IsNullOrEmpty(txtMedico.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"INSERT INTO Pacientes (CPF, Nome, Sobrenome, Idade, Altura, Peso, TipoParto, Id_medico, FotoPerfil)
                VALUES
                (@CPF, @Nome, @Sobrenome, @Idade, @Altura, @Peso, @TipoParto, @Id_medico, @FotoPerfil);";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
                cmd.Parameters.AddWithValue("@Idade", Convert.ToInt32(txtIdade.Text));
                cmd.Parameters.AddWithValue("@Altura", Convert.ToDecimal(txtAltura.Text));
                cmd.Parameters.AddWithValue("@Peso", Convert.ToDecimal(txtPeso.Text));
                cmd.Parameters.AddWithValue("@TipoParto", cbTipo.Text);
                cmd.Parameters.AddWithValue("@Id_medico", Convert.ToInt32(txtMedico.Text));

                byte[] foto = File.ReadAllBytes(caminhoFoto);
                cmd.Parameters.AddWithValue("@FotoPerfil", foto);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Processo Cadastrado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("CPF deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"UPDATE Pacientes SET CPF = @CPF, Nome = @Nome, Sobrenome = @Sobrenome, Idade = @Idade, Altura = @Altura, Peso = @Peso, TipoParto = @TipoParto, Id_medico = @Id_medico, FotoPerfil = @FotoPerfil;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
                cmd.Parameters.AddWithValue("@Idade", Convert.ToInt32(txtIdade.Text));
                cmd.Parameters.AddWithValue("@Altura", Convert.ToDecimal(txtAltura.Text));
                cmd.Parameters.AddWithValue("@Peso", Convert.ToDecimal(txtPeso.Text));
                cmd.Parameters.AddWithValue("@TipoParto", cbTipo.Text);
                cmd.Parameters.AddWithValue("@Id_medico", Convert.ToInt32(txtMedico.Text));

                byte[] foto = File.ReadAllBytes(caminhoFoto);
                cmd.Parameters.AddWithValue("@FotoPerfil", foto);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Alteração Salva com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("CPF deve ser preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"Tem Certeza que deseja Excluir {txtCPF.Text}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

                conn.Open();

                string sql = @"DELETE Medicos WHERE CPF = @CPF;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
