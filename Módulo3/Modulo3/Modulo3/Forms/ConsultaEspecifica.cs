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
    public partial class ConsultaEspecifica : Form
    {
        public ConsultaEspecifica()
        {
            InitializeComponent();
        }

        private void ConsultaEspecifica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lkConsulta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultaMedico consulta = new ConsultaMedico();

            consulta.Show();

            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;");

            conn.Open();

            string sql = @"SELECT Nome, Sobrenome, Formacao, Especialidade, FotoPerfil FROM Medicos WHERE CRM = @CRM";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CRM", txtCRM.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (string.IsNullOrEmpty(Convert.ToString(reader["Nome"])))
                {
                    MessageBox.Show("Consulta Não Localizada!");
                    break;
                }
                else
                {
                    txtNome.Text = Convert.ToString(reader["Nome"]);
                    txtSobrenome.Text = Convert.ToString(reader["Sobrenome"]);
                    txtFormacao.Text = Convert.ToString(reader["Formacao"]);
                    txtEspecialidade.Text = Convert.ToString(reader["Especialidade"]);

                    if (string.IsNullOrEmpty(Convert.ToString(reader["FotoPerfil"])))
                    {
                        break;
                    }
                    else
                    {
                        byte[] foto = (byte[])reader["FotoPerfil"];

                        MemoryStream ms = new MemoryStream(foto);

                        pbFoto.Image = Image.FromStream(ms);

                        break;
                    }
                }
            }

            reader.Close();

            if (string.IsNullOrEmpty(Convert.ToString(cmd.ExecuteScalar())))
            {
                MessageBox.Show("Consulta Não Localizada!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ConsultaEspecifica consulta = new ConsultaEspecifica();

            consulta.Show();

            this.Hide();
        }
    }
}
