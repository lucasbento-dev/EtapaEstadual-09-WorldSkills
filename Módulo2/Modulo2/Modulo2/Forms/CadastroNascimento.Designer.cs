namespace Modulo2.Forms
{
    partial class CadastroNascimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroNascimento));
            lblData = new Label();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnDeletar = new Button();
            btnSalvar = new Button();
            txtPeso = new TextBox();
            lblPeso = new Label();
            txtRegistro = new TextBox();
            lblRegistro = new Label();
            txtTamanho = new TextBox();
            lblTamanho = new Label();
            txtPaciente = new TextBox();
            lblPaciente = new Label();
            txtCPF = new TextBox();
            lblCPF = new Label();
            txtObservacoes = new TextBox();
            lblObservacoes = new Label();
            lblCadastro = new Label();
            pbLogo = new PictureBox();
            dtpData = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(76, 160);
            lblData.Name = "lblData";
            lblData.Size = new Size(149, 15);
            lblData.TabIndex = 46;
            lblData.Text = "Data e hora do nascimento";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(73, 408);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(65, 30);
            btnCadastrar.TabIndex = 44;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(171, 408);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 30);
            btnEditar.TabIndex = 43;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(269, 408);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(62, 30);
            btnDeletar.TabIndex = 42;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(367, 408);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(62, 30);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(76, 326);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(157, 23);
            txtPeso.TabIndex = 40;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(76, 308);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 39;
            lblPeso.Text = "Peso";
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(76, 130);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(157, 23);
            txtRegistro.TabIndex = 38;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(76, 112);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(50, 15);
            lblRegistro.TabIndex = 37;
            lblRegistro.Text = "Registro";
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(76, 227);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(157, 23);
            txtTamanho.TabIndex = 36;
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Location = new Point(76, 209);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(56, 15);
            lblTamanho.TabIndex = 35;
            lblTamanho.Text = "Tamanho";
            // 
            // txtPaciente
            // 
            txtPaciente.Location = new Point(76, 282);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(157, 23);
            txtPaciente.TabIndex = 34;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(76, 264);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(65, 15);
            lblPaciente.TabIndex = 33;
            lblPaciente.Text = "Paciente Id";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(283, 130);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(157, 23);
            txtCPF.TabIndex = 32;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(283, 112);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(54, 15);
            lblCPF.TabIndex = 31;
            lblCPF.Text = "CPF Mãe";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(283, 206);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(157, 143);
            txtObservacoes.TabIndex = 30;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(283, 186);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(130, 15);
            lblObservacoes.TabIndex = 29;
            lblObservacoes.Text = "Observações relevantes";
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 15F);
            lblCadastro.Location = new Point(107, 74);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(312, 28);
            lblCadastro.TabIndex = 25;
            lblCadastro.Text = "CADASTRO DE RÉCEM-NASCIDOS";
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(92, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(337, 48);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 24;
            pbLogo.TabStop = false;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(76, 178);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(157, 23);
            dtpData.TabIndex = 47;
            dtpData.Value = new DateTime(2026, 6, 16, 0, 0, 0, 0);
            // 
            // CadastroNascimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(dtpData);
            Controls.Add(lblData);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEditar);
            Controls.Add(btnDeletar);
            Controls.Add(btnSalvar);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtRegistro);
            Controls.Add(lblRegistro);
            Controls.Add(txtTamanho);
            Controls.Add(lblTamanho);
            Controls.Add(txtPaciente);
            Controls.Add(lblPaciente);
            Controls.Add(txtCPF);
            Controls.Add(lblCPF);
            Controls.Add(txtObservacoes);
            Controls.Add(lblObservacoes);
            Controls.Add(lblCadastro);
            Controls.Add(pbLogo);
            Name = "CadastroNascimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroNascimento";
            FormClosing += CadastroNascimento_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblData;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnDeletar;
        private Button btnSalvar;
        private TextBox txtPeso;
        private Label lblPeso;
        private TextBox txtRegistro;
        private Label lblRegistro;
        private TextBox txtTamanho;
        private Label lblTamanho;
        private TextBox txtPaciente;
        private Label lblPaciente;
        private TextBox txtCPF;
        private Label lblCPF;
        private TextBox txtObservacoes;
        private Label lblObservacoes;
        private Label lblCadastro;
        private PictureBox pbLogo;
        private DateTimePicker dtpData;
    }
}