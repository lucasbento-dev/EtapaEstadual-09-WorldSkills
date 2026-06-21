namespace Modulo2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblBemVindo = new Label();
            lblAcessar = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            cbLembrar = new CheckBox();
            lkEsqueci = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(173, 402);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(470, 27);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(470, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(241, 132);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(327, 37);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Controle de Maternidades";
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblBemVindo.Location = new Point(334, 169);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(122, 28);
            lblBemVindo.TabIndex = 3;
            lblBemVindo.Text = "Bem-vindo!";
            // 
            // lblAcessar
            // 
            lblAcessar.AutoSize = true;
            lblAcessar.Location = new Point(305, 207);
            lblAcessar.Name = "lblAcessar";
            lblAcessar.Size = new Size(177, 15);
            lblAcessar.TabIndex = 4;
            lblAcessar.Text = "Acesse sua conta para continuar";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(173, 259);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "E-mail corporativo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 277);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu e-mail";
            txtEmail.Size = new Size(470, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(173, 337);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(470, 23);
            txtSenha.TabIndex = 8;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(173, 319);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // cbLembrar
            // 
            cbLembrar.AutoSize = true;
            cbLembrar.Location = new Point(173, 367);
            cbLembrar.Name = "cbLembrar";
            cbLembrar.Size = new Size(92, 19);
            cbLembrar.TabIndex = 9;
            cbLembrar.Text = "Lembrar-me";
            cbLembrar.UseVisualStyleBackColor = true;
            // 
            // lkEsqueci
            // 
            lkEsqueci.AutoSize = true;
            lkEsqueci.Location = new Point(525, 371);
            lkEsqueci.Name = "lkEsqueci";
            lkEsqueci.Size = new Size(118, 15);
            lkEsqueci.TabIndex = 10;
            lkEsqueci.TabStop = true;
            lkEsqueci.Text = "Esqueci minha senha";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lkEsqueci);
            Controls.Add(cbLembrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblAcessar);
            Controls.Add(lblBemVindo);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntrar);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lyon Company Controle de Maternidades";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblBemVindo;
        private Label lblAcessar;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblSenha;
        private CheckBox cbLembrar;
        private LinkLabel lkEsqueci;
    }
}
