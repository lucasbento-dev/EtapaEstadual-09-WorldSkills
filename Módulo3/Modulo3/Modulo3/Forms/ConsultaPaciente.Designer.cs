namespace Modulo3.Forms
{
    partial class ConsultaPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPaciente));
            lkNascimento = new LinkLabel();
            lkMedico = new LinkLabel();
            lkEspecifico = new LinkLabel();
            lblConsulta = new Label();
            pbLogo = new PictureBox();
            dgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // lkNascimento
            // 
            lkNascimento.AutoSize = true;
            lkNascimento.Location = new Point(404, 399);
            lkNascimento.Name = "lkNascimento";
            lkNascimento.Size = new Size(96, 15);
            lkNascimento.TabIndex = 11;
            lkNascimento.TabStop = true;
            lkNascimento.Text = "Recém-Nascidos";
            lkNascimento.LinkClicked += lkNascimento_LinkClicked;
            // 
            // lkMedico
            // 
            lkMedico.AutoSize = true;
            lkMedico.Location = new Point(246, 399);
            lkMedico.Name = "lkMedico";
            lkMedico.Size = new Size(52, 15);
            lkMedico.TabIndex = 10;
            lkMedico.TabStop = true;
            lkMedico.Text = "Médicos";
            lkMedico.LinkClicked += lkMedico_LinkClicked;
            // 
            // lkEspecifico
            // 
            lkEspecifico.AutoSize = true;
            lkEspecifico.Location = new Point(56, 399);
            lkEspecifico.Name = "lkEspecifico";
            lkEspecifico.Size = new Size(103, 15);
            lkEspecifico.TabIndex = 9;
            lkEspecifico.TabStop = true;
            lkEspecifico.Text = "Médico Específico";
            lkEspecifico.LinkClicked += lkEspecifico_LinkClicked;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 20F);
            lblConsulta.ForeColor = Color.SaddleBrown;
            lblConsulta.Location = new Point(117, 106);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(322, 37);
            lblConsulta.TabIndex = 8;
            lblConsulta.Text = "CONSULTA DE PACIENTES";
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(24, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(519, 79);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(56, 160);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(444, 212);
            dgvConsulta.TabIndex = 6;
            // 
            // ConsultaPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(lkNascimento);
            Controls.Add(lkMedico);
            Controls.Add(lkEspecifico);
            Controls.Add(lblConsulta);
            Controls.Add(pbLogo);
            Controls.Add(dgvConsulta);
            Name = "ConsultaPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaPaciente";
            FormClosing += ConsultaPaciente_FormClosing;
            Load += ConsultaPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lkNascimento;
        private LinkLabel lkMedico;
        private LinkLabel lkEspecifico;
        private Label lblConsulta;
        private PictureBox pbLogo;
        private DataGridView dgvConsulta;
    }
}