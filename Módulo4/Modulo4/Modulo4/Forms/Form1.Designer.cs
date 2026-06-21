namespace Modulo4.Forms
{
    partial class Form1
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
            pnlConsulta = new Panel();
            txtBusca = new TextBox();
            dgvConsulta = new DataGridView();
            lblConsulta = new Label();
            pnlPartos = new Panel();
            lblCesarea = new Label();
            lblNormal = new Label();
            lblPartos = new Label();
            pnlFuncionarios = new Panel();
            charFuncionarios = new Panel();
            lblQuantidade = new Label();
            lblFuncionarios = new Label();
            chartPartos = new Panel();
            pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            pnlPartos.SuspendLayout();
            pnlFuncionarios.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConsulta
            // 
            pnlConsulta.BorderStyle = BorderStyle.FixedSingle;
            pnlConsulta.Controls.Add(txtBusca);
            pnlConsulta.Controls.Add(dgvConsulta);
            pnlConsulta.Controls.Add(lblConsulta);
            pnlConsulta.Location = new Point(12, 224);
            pnlConsulta.Name = "pnlConsulta";
            pnlConsulta.Size = new Size(776, 214);
            pnlConsulta.TabIndex = 7;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(606, 5);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar...";
            txtBusca.Size = new Size(153, 23);
            txtBusca.TabIndex = 2;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(15, 34);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(744, 165);
            dgvConsulta.TabIndex = 1;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsulta.Location = new Point(15, 8);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(166, 15);
            lblConsulta.TabIndex = 0;
            lblConsulta.Text = "Consulta de Recém-Nascidos";
            // 
            // pnlPartos
            // 
            pnlPartos.BorderStyle = BorderStyle.FixedSingle;
            pnlPartos.Controls.Add(chartPartos);
            pnlPartos.Controls.Add(lblCesarea);
            pnlPartos.Controls.Add(lblNormal);
            pnlPartos.Controls.Add(lblPartos);
            pnlPartos.Location = new Point(418, 12);
            pnlPartos.Name = "pnlPartos";
            pnlPartos.Size = new Size(370, 197);
            pnlPartos.TabIndex = 6;
            // 
            // lblCesarea
            // 
            lblCesarea.AutoSize = true;
            lblCesarea.Location = new Point(266, 92);
            lblCesarea.Name = "lblCesarea";
            lblCesarea.Size = new Size(48, 15);
            lblCesarea.TabIndex = 3;
            lblCesarea.Text = "Cesárea";
            // 
            // lblNormal
            // 
            lblNormal.AutoSize = true;
            lblNormal.Location = new Point(266, 67);
            lblNormal.Name = "lblNormal";
            lblNormal.Size = new Size(78, 15);
            lblNormal.TabIndex = 2;
            lblNormal.Text = "Parto Normal";
            // 
            // lblPartos
            // 
            lblPartos.AutoSize = true;
            lblPartos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPartos.Location = new Point(15, 12);
            lblPartos.Name = "lblPartos";
            lblPartos.Size = new Size(145, 15);
            lblPartos.TabIndex = 0;
            lblPartos.Text = "Partos - Recém-Nascidos";
            // 
            // pnlFuncionarios
            // 
            pnlFuncionarios.BorderStyle = BorderStyle.FixedSingle;
            pnlFuncionarios.Controls.Add(charFuncionarios);
            pnlFuncionarios.Controls.Add(lblQuantidade);
            pnlFuncionarios.Controls.Add(lblFuncionarios);
            pnlFuncionarios.Location = new Point(12, 12);
            pnlFuncionarios.Name = "pnlFuncionarios";
            pnlFuncionarios.Size = new Size(391, 197);
            pnlFuncionarios.TabIndex = 5;
            // 
            // charFuncionarios
            // 
            charFuncionarios.Location = new Point(31, 30);
            charFuncionarios.Name = "charFuncionarios";
            charFuncionarios.Size = new Size(325, 137);
            charFuncionarios.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(132, 170);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(156, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade de Funcionários";
            // 
            // lblFuncionarios
            // 
            lblFuncionarios.AutoSize = true;
            lblFuncionarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFuncionarios.ImageAlign = ContentAlignment.TopLeft;
            lblFuncionarios.Location = new Point(15, 12);
            lblFuncionarios.Name = "lblFuncionarios";
            lblFuncionarios.Size = new Size(132, 15);
            lblFuncionarios.TabIndex = 0;
            lblFuncionarios.Text = "Funcionários por Setor";
            // 
            // chartPartos
            // 
            chartPartos.Location = new Point(15, 30);
            chartPartos.Name = "chartPartos";
            chartPartos.Size = new Size(157, 155);
            chartPartos.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlConsulta);
            Controls.Add(pnlPartos);
            Controls.Add(pnlFuncionarios);
            Name = "Form1";
            Text = "Form1";
            pnlConsulta.ResumeLayout(false);
            pnlConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            pnlPartos.ResumeLayout(false);
            pnlPartos.PerformLayout();
            pnlFuncionarios.ResumeLayout(false);
            pnlFuncionarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConsulta;
        private TextBox txtBusca;
        private DataGridView dgvConsulta;
        private Label lblConsulta;
        private Panel pnlPartos;
        private Label lblCesarea;
        private Label lblNormal;
        private Label lblPartos;
        private Panel pnlFuncionarios;
        private Panel charFuncionarios;
        private Label lblQuantidade;
        private Label lblFuncionarios;
        private Panel chartPartos;
    }
}