namespace Modulo4
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
            pbLogo = new PictureBox();
            lblTitulo = new Label();
            lblBem = new Label();
            lblAcesse = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            cbLembrar = new CheckBox();
            lkEsqueci = new LinkLabel();
            btnEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(108, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(588, 85);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(222, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(353, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Controle de Maternidades";
            // 
            // lblBem
            // 
            lblBem.AutoSize = true;
            lblBem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBem.Location = new Point(346, 153);
            lblBem.Name = "lblBem";
            lblBem.Size = new Size(99, 21);
            lblBem.TabIndex = 2;
            lblBem.Text = "Bem-vindo!";
            // 
            // lblAcesse
            // 
            lblAcesse.AutoSize = true;
            lblAcesse.Font = new Font("Segoe UI", 10F);
            lblAcesse.Location = new Point(295, 185);
            lblAcesse.Name = "lblAcesse";
            lblAcesse.Size = new Size(206, 19);
            lblAcesse.TabIndex = 3;
            lblAcesse.Text = "Acesse sua conta para continuar";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(196, 234);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(109, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail corporativo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(196, 252);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(398, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(196, 305);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(398, 23);
            txtSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSenha.Location = new Point(196, 287);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(41, 15);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // cbLembrar
            // 
            cbLembrar.AutoSize = true;
            cbLembrar.Location = new Point(196, 338);
            cbLembrar.Name = "cbLembrar";
            cbLembrar.Size = new Size(92, 19);
            cbLembrar.TabIndex = 8;
            cbLembrar.Text = "Lembrar-me";
            cbLembrar.UseVisualStyleBackColor = true;
            // 
            // lkEsqueci
            // 
            lkEsqueci.AutoSize = true;
            lkEsqueci.Location = new Point(476, 339);
            lkEsqueci.Name = "lkEsqueci";
            lkEsqueci.Size = new Size(118, 15);
            lkEsqueci.TabIndex = 9;
            lkEsqueci.TabStop = true;
            lkEsqueci.Text = "Esqueci minha senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ActiveCaptionText;
            btnEntrar.Font = new Font("Segoe UI", 11F);
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Location = new Point(190, 381);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(404, 39);
            btnEntrar.TabIndex = 10;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(lkEsqueci);
            Controls.Add(cbLembrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblAcesse);
            Controls.Add(lblBem);
            Controls.Add(lblTitulo);
            Controls.Add(pbLogo);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lyon Company Controle de Maternidades";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblTitulo;
        private Label lblBem;
        private Label lblAcesse;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblSenha;
        private CheckBox cbLembrar;
        private LinkLabel lkEsqueci;
        private Button btnEntrar;
    }
}
