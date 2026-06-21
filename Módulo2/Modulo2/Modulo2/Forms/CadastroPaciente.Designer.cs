namespace Modulo2.Forms
{
    partial class CadastroPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPaciente));
            pbLogo = new PictureBox();
            lblCadastro = new Label();
            pbFoto = new PictureBox();
            lblNome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            lblSobrenome = new Label();
            txtCPF = new TextBox();
            lblCPF = new Label();
            txtMedico = new TextBox();
            lblMedico = new Label();
            txtIdade = new TextBox();
            lblIdade = new Label();
            txtAltura = new TextBox();
            label1 = new Label();
            txtPeso = new TextBox();
            lblPeso = new Label();
            btnSalvar = new Button();
            btnDeletar = new Button();
            btnEditar = new Button();
            btnCadastrar = new Button();
            btnProcurar = new Button();
            lblTipo = new Label();
            cbTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(90, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(337, 48);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 15F);
            lblCadastro.Location = new Point(144, 72);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(242, 28);
            lblCadastro.TabIndex = 1;
            lblCadastro.Text = "CADASTRO DE PACIENTES";
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(74, 113);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(131, 147);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 2;
            pbFoto.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(280, 112);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(280, 130);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(157, 23);
            txtNome.TabIndex = 4;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(280, 175);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(157, 23);
            txtSobrenome.TabIndex = 6;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(280, 157);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(68, 15);
            lblSobrenome.TabIndex = 5;
            lblSobrenome.Text = "Sobrenome";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(280, 224);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(157, 23);
            txtCPF.TabIndex = 8;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(280, 206);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 7;
            lblCPF.Text = "CPF";
            // 
            // txtMedico
            // 
            txtMedico.Location = new Point(74, 361);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(157, 23);
            txtMedico.TabIndex = 10;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Location = new Point(74, 343);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(60, 15);
            lblMedico.TabIndex = 9;
            lblMedico.Text = "Médico Id";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(280, 271);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(157, 23);
            txtIdade.TabIndex = 12;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(280, 253);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 11;
            lblIdade.Text = "Idade";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(280, 318);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(157, 23);
            txtAltura.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 300);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 13;
            label1.Text = "Altura";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(280, 361);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(157, 23);
            txtPeso.TabIndex = 16;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(280, 343);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 15;
            lblPeso.Text = "Peso";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(365, 408);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(62, 30);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(267, 408);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(62, 30);
            btnDeletar.TabIndex = 18;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(169, 408);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 30);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(71, 408);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(65, 30);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(74, 266);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(62, 28);
            btnProcurar.TabIndex = 21;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(74, 300);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(77, 15);
            lblTipo.TabIndex = 22;
            lblTipo.Text = "Tipo de parto";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Normal", "Cesária" });
            cbTipo.Location = new Point(74, 318);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(157, 23);
            cbTipo.TabIndex = 23;
            // 
            // CadastroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(cbTipo);
            Controls.Add(lblTipo);
            Controls.Add(btnProcurar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEditar);
            Controls.Add(btnDeletar);
            Controls.Add(btnSalvar);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtAltura);
            Controls.Add(label1);
            Controls.Add(txtIdade);
            Controls.Add(lblIdade);
            Controls.Add(txtMedico);
            Controls.Add(lblMedico);
            Controls.Add(txtCPF);
            Controls.Add(lblCPF);
            Controls.Add(txtSobrenome);
            Controls.Add(lblSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(pbFoto);
            Controls.Add(lblCadastro);
            Controls.Add(pbLogo);
            Name = "CadastroPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plataforma - Lyon Company Maternidades";
            FormClosing += CadastroPaciente_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblCadastro;
        private PictureBox pbFoto;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private Label lblSobrenome;
        private TextBox txtCPF;
        private Label lblCPF;
        private TextBox txtMedico;
        private Label lblMedico;
        private TextBox txtIdade;
        private Label lblIdade;
        private TextBox txtAltura;
        private Label label1;
        private TextBox txtPeso;
        private Label lblPeso;
        private Button btnSalvar;
        private Button btnDeletar;
        private Button btnEditar;
        private Button btnCadastrar;
        private Button btnProcurar;
        private TextBox textBox1;
        private Label lblTipo;
        private ComboBox cbTipo;
    }
}