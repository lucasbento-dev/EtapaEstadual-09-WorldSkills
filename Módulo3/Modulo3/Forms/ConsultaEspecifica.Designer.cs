namespace Modulo3.Forms
{
    partial class ConsultaEspecifica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEspecifica));
            pbFoto = new PictureBox();
            pbLogo = new PictureBox();
            lblCRM = new Label();
            txtCRM = new TextBox();
            btnConsultar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            txtFormacao = new TextBox();
            txtEspecialidade = new TextBox();
            btnLimpar = new Button();
            lblSobrenome = new Label();
            lblFormacao = new Label();
            lblEspecialidade = new Label();
            lkConsulta = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(26, 109);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(129, 161);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 1;
            pbFoto.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(26, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(519, 79);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // lblCRM
            // 
            lblCRM.AutoSize = true;
            lblCRM.ForeColor = Color.BlueViolet;
            lblCRM.Location = new Point(185, 125);
            lblCRM.Name = "lblCRM";
            lblCRM.Size = new Size(96, 15);
            lblCRM.TabIndex = 3;
            lblCRM.Text = "CRM do Médico:";
            // 
            // txtCRM
            // 
            txtCRM.Location = new Point(185, 143);
            txtCRM.Name = "txtCRM";
            txtCRM.Size = new Size(173, 23);
            txtCRM.TabIndex = 4;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.BlueViolet;
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConsultar.ForeColor = SystemColors.ButtonHighlight;
            btnConsultar.Location = new Point(393, 136);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(152, 34);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.Highlight;
            lblNome.Location = new Point(26, 292);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(26, 310);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(214, 23);
            txtNome.TabIndex = 8;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(331, 310);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(214, 23);
            txtSobrenome.TabIndex = 10;
            // 
            // txtFormacao
            // 
            txtFormacao.Location = new Point(26, 362);
            txtFormacao.Name = "txtFormacao";
            txtFormacao.Size = new Size(214, 23);
            txtFormacao.TabIndex = 12;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Location = new Point(331, 362);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.Size = new Size(214, 23);
            txtEspecialidade.TabIndex = 14;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Goldenrod;
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpar.Location = new Point(185, 219);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(173, 34);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.ForeColor = SystemColors.Highlight;
            lblSobrenome.Location = new Point(331, 292);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(71, 15);
            lblSobrenome.TabIndex = 16;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // lblFormacao
            // 
            lblFormacao.AutoSize = true;
            lblFormacao.ForeColor = SystemColors.Highlight;
            lblFormacao.Location = new Point(26, 344);
            lblFormacao.Name = "lblFormacao";
            lblFormacao.Size = new Size(63, 15);
            lblFormacao.TabIndex = 17;
            lblFormacao.Text = "Formação:";
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.AutoSize = true;
            lblEspecialidade.ForeColor = SystemColors.Highlight;
            lblEspecialidade.Location = new Point(331, 344);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(81, 15);
            lblEspecialidade.TabIndex = 18;
            lblEspecialidade.Text = "Especialidade:";
            // 
            // lkConsulta
            // 
            lkConsulta.AutoSize = true;
            lkConsulta.Location = new Point(493, 409);
            lkConsulta.Name = "lkConsulta";
            lkConsulta.Size = new Size(52, 15);
            lkConsulta.TabIndex = 19;
            lkConsulta.TabStop = true;
            lkConsulta.Text = "Médicos";
            lkConsulta.LinkClicked += lkConsulta_LinkClicked;
            // 
            // ConsultaEspecifica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(lkConsulta);
            Controls.Add(lblEspecialidade);
            Controls.Add(lblFormacao);
            Controls.Add(lblSobrenome);
            Controls.Add(btnLimpar);
            Controls.Add(txtEspecialidade);
            Controls.Add(txtFormacao);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnConsultar);
            Controls.Add(txtCRM);
            Controls.Add(lblCRM);
            Controls.Add(pbLogo);
            Controls.Add(pbFoto);
            Name = "ConsultaEspecifica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaEspecifica";
            FormClosing += ConsultaEspecifica_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFoto;
        private PictureBox pbLogo;
        private Label lblCRM;
        private TextBox txtCRM;
        private Button btnConsultar;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private TextBox txtFormacao;
        private TextBox txtEspecialidade;
        private Button btnLimpar;
        private Label lblSobrenome;
        private Label lblFormacao;
        private Label lblEspecialidade;
        private LinkLabel lkConsulta;
    }
}