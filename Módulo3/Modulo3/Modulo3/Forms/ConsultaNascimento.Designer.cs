namespace Modulo3.Forms
{
    partial class ConsultaNascimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaNascimento));
            lkMedicos = new LinkLabel();
            lkPaciente = new LinkLabel();
            lkEspecifico = new LinkLabel();
            lblConsulta = new Label();
            pbLogo = new PictureBox();
            dgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // lkMedicos
            // 
            lkMedicos.AutoSize = true;
            lkMedicos.Location = new Point(447, 399);
            lkMedicos.Name = "lkMedicos";
            lkMedicos.Size = new Size(52, 15);
            lkMedicos.TabIndex = 11;
            lkMedicos.TabStop = true;
            lkMedicos.Text = "Médicos";
            lkMedicos.LinkClicked += lkMedicos_LinkClicked;
            // 
            // lkPaciente
            // 
            lkPaciente.AutoSize = true;
            lkPaciente.Location = new Point(245, 399);
            lkPaciente.Name = "lkPaciente";
            lkPaciente.Size = new Size(57, 15);
            lkPaciente.TabIndex = 10;
            lkPaciente.TabStop = true;
            lkPaciente.Text = "Pacientes";
            lkPaciente.LinkClicked += lkPaciente_LinkClicked;
            // 
            // lkEspecifico
            // 
            lkEspecifico.AutoSize = true;
            lkEspecifico.Location = new Point(55, 399);
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
            lblConsulta.Location = new Point(68, 108);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(417, 37);
            lblConsulta.TabIndex = 8;
            lblConsulta.Text = "CONSULTA DE RECÉM-NASCIDOS";
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(23, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(519, 79);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(55, 160);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(444, 212);
            dgvConsulta.TabIndex = 6;
            // 
            // ConsultaNascimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(lkMedicos);
            Controls.Add(lkPaciente);
            Controls.Add(lkEspecifico);
            Controls.Add(lblConsulta);
            Controls.Add(pbLogo);
            Controls.Add(dgvConsulta);
            Name = "ConsultaNascimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaNascimento";
            FormClosing += ConsultaNascimento_FormClosing;
            Load += ConsultaNascimento_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lkMedicos;
        private LinkLabel lkPaciente;
        private LinkLabel lkEspecifico;
        private Label lblConsulta;
        private PictureBox pbLogo;
        private DataGridView dgvConsulta;
    }
}