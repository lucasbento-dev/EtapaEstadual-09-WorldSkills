using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Modulo2.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            CadastroPaciente paciente = new CadastroPaciente();

            paciente.Show();

            this.Hide();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            CadastroMedico medico = new CadastroMedico();

            medico.Show();

            this.Hide();
        }

        private void btnRecem_Click(object sender, EventArgs e)
        {
            CadastroNascimento nascimento = new CadastroNascimento();

            nascimento.Show();

            nascimento.Hide();
        }
    }
}
