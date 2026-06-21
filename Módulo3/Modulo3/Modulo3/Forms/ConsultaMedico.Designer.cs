namespace Modulo3
{
    partial class ConsultaMedico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMedico));
            dgvConsulta = new DataGridView();
            pbLogo = new PictureBox();
            lblConsulta = new Label();
            lkEspecifico = new LinkLabel();
            lkPaciente = new LinkLabel();
            lkNascimento = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(57, 160);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(444, 212);
            dgvConsulta.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(25, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(519, 79);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 20F);
            lblConsulta.ForeColor = Color.SaddleBrown;
            lblConsulta.Location = new Point(132, 107);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(307, 37);
            lblConsulta.TabIndex = 2;
            lblConsulta.Text = "CONSULTA DE MÉDICOS";
            // 
            // lkEspecifico
            // 
            lkEspecifico.AutoSize = true;
            lkEspecifico.Location = new Point(57, 399);
            lkEspecifico.Name = "lkEspecifico";
            lkEspecifico.Size = new Size(103, 15);
            lkEspecifico.TabIndex = 3;
            lkEspecifico.TabStop = true;
            lkEspecifico.Text = "Médico Específico";
            lkEspecifico.LinkClicked += lkEspecifico_LinkClicked;
            // 
            // lkPaciente
            // 
            lkPaciente.AutoSize = true;
            lkPaciente.Location = new Point(247, 399);
            lkPaciente.Name = "lkPaciente";
            lkPaciente.Size = new Size(57, 15);
            lkPaciente.TabIndex = 4;
            lkPaciente.TabStop = true;
            lkPaciente.Text = "Pacientes";
            lkPaciente.LinkClicked += lkPaciente_LinkClicked;
            // 
            // lkNascimento
            // 
            lkNascimento.AutoSize = true;
            lkNascimento.Location = new Point(405, 399);
            lkNascimento.Name = "lkNascimento";
            lkNascimento.Size = new Size(96, 15);
            lkNascimento.TabIndex = 5;
            lkNascimento.TabStop = true;
            lkNascimento.Text = "Recém-Nascidos";
            lkNascimento.LinkClicked += lkNascimento_LinkClicked;
            // 
            // ConsultaMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(lkNascimento);
            Controls.Add(lkPaciente);
            Controls.Add(lkEspecifico);
            Controls.Add(lblConsulta);
            Controls.Add(pbLogo);
            Controls.Add(dgvConsulta);
            Name = "ConsultaMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plataforma - Lyon Company Maternidades";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConsulta;
        private PictureBox pbLogo;
        private Label lblConsulta;
        private LinkLabel lkEspecifico;
        private LinkLabel lkPaciente;
        private LinkLabel lkNascimento;
    }
}
