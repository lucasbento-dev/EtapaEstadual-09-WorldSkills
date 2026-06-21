namespace Modulo2.Forms
{
    partial class Menu
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
            btnRecem = new Button();
            btnPaciente = new Button();
            btnMedico = new Button();
            SuspendLayout();
            // 
            // btnRecem
            // 
            btnRecem.Location = new Point(85, 207);
            btnRecem.Name = "btnRecem";
            btnRecem.Size = new Size(210, 74);
            btnRecem.TabIndex = 2;
            btnRecem.Text = "Recém-nascido";
            btnRecem.UseVisualStyleBackColor = true;
            btnRecem.Click += btnRecem_Click;
            // 
            // btnPaciente
            // 
            btnPaciente.Location = new Point(85, 127);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(210, 74);
            btnPaciente.TabIndex = 3;
            btnPaciente.Text = "Paciente";
            btnPaciente.UseVisualStyleBackColor = true;
            btnPaciente.Click += btnPaciente_Click;
            // 
            // btnMedico
            // 
            btnMedico.Location = new Point(85, 47);
            btnMedico.Name = "btnMedico";
            btnMedico.Size = new Size(210, 74);
            btnMedico.TabIndex = 4;
            btnMedico.Text = "Médico";
            btnMedico.UseVisualStyleBackColor = true;
            btnMedico.Click += btnMedico_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 329);
            Controls.Add(btnMedico);
            Controls.Add(btnPaciente);
            Controls.Add(btnRecem);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plataforma - Lyon Company Maternidades";
            FormClosing += Menu_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRecem;
        private Button btnPaciente;
        private Button btnMedico;
    }
}