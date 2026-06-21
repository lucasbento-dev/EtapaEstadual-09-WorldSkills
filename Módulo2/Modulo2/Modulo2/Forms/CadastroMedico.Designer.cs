namespace Modulo2.Forms
{
    partial class CadastroMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMedico));
            btnProcurar = new Button();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnDeletar = new Button();
            btnSalvar = new Button();
            txtEspecialidade = new TextBox();
            lblEspecialidade = new Label();
            txtFormacao = new TextBox();
            lblFormacao = new Label();
            txtCRM = new TextBox();
            lblCRM = new Label();
            txtNome = new TextBox();
            lblNomeCompleto = new Label();
            pbFoto = new PictureBox();
            lblCadastro = new Label();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(71, 318);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(62, 28);
            btnProcurar.TabIndex = 45;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(68, 408);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(65, 30);
            btnCadastrar.TabIndex = 44;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(166, 408);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 30);
            btnEditar.TabIndex = 43;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(264, 408);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(62, 30);
            btnDeletar.TabIndex = 42;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(362, 408);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(62, 30);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Location = new Point(277, 318);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.Size = new Size(157, 23);
            txtEspecialidade.TabIndex = 38;
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.AutoSize = true;
            lblEspecialidade.Location = new Point(277, 300);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(78, 15);
            lblEspecialidade.TabIndex = 37;
            lblEspecialidade.Text = "Especialidade";
            // 
            // txtFormacao
            // 
            txtFormacao.Location = new Point(277, 254);
            txtFormacao.Name = "txtFormacao";
            txtFormacao.Size = new Size(157, 23);
            txtFormacao.TabIndex = 36;
            // 
            // lblFormacao
            // 
            lblFormacao.AutoSize = true;
            lblFormacao.Location = new Point(277, 236);
            lblFormacao.Name = "lblFormacao";
            lblFormacao.Size = new Size(60, 15);
            lblFormacao.TabIndex = 35;
            lblFormacao.Text = "Formação";
            // 
            // txtCRM
            // 
            txtCRM.Location = new Point(277, 190);
            txtCRM.Name = "txtCRM";
            txtCRM.Size = new Size(157, 23);
            txtCRM.TabIndex = 32;
            // 
            // lblCRM
            // 
            lblCRM.AutoSize = true;
            lblCRM.Location = new Point(277, 172);
            lblCRM.Name = "lblCRM";
            lblCRM.Size = new Size(33, 15);
            lblCRM.TabIndex = 31;
            lblCRM.Text = "CRM";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(277, 129);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(157, 23);
            txtNome.TabIndex = 30;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(277, 111);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(94, 15);
            lblNomeCompleto.TabIndex = 29;
            lblNomeCompleto.Text = "Nome completo";
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(71, 113);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(157, 186);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 26;
            pbFoto.TabStop = false;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 15F);
            lblCadastro.Location = new Point(141, 72);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(230, 28);
            lblCadastro.TabIndex = 25;
            lblCadastro.Text = "CADASTRO DE MÉDICOS\r\n";
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(87, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(337, 48);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 24;
            pbLogo.TabStop = false;
            // 
            // CadastroMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(btnProcurar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEditar);
            Controls.Add(btnDeletar);
            Controls.Add(btnSalvar);
            Controls.Add(txtEspecialidade);
            Controls.Add(lblEspecialidade);
            Controls.Add(txtFormacao);
            Controls.Add(lblFormacao);
            Controls.Add(txtCRM);
            Controls.Add(lblCRM);
            Controls.Add(txtNome);
            Controls.Add(lblNomeCompleto);
            Controls.Add(pbFoto);
            Controls.Add(lblCadastro);
            Controls.Add(pbLogo);
            Name = "CadastroMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosing += CadastroMedico_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProcurar;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnDeletar;
        private Button btnSalvar;
        private TextBox txtEspecialidade;
        private Label lblEspecialidade;
        private TextBox txtFormacao;
        private Label lblFormacao;
        private TextBox txtCRM;
        private Label lblCRM;
        private TextBox txtNome;
        private Label lblNomeCompleto;
        private PictureBox pbFoto;
        private Label lblCadastro;
        private PictureBox pbLogo;
    }
}