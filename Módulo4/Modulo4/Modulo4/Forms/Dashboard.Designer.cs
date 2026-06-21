using System.Windows.Forms.DataVisualization.Charting;

namespace Modulo4.Forms
{
    partial class Dashboard
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
            chartFuncionarios = new Chart();
            chartPartos = new Chart();
            pnlFuncionarios = new Panel();
            lblQuantidade = new Label();
            lblFuncionarios = new Label();
            pnlPartos = new Panel();
            lblCesarea = new Label();
            lblNormal = new Label();
            lblPartos = new Label();
            pnlConsulta = new Panel();
            txtBusca = new TextBox();
            dgvConsulta = new DataGridView();
            lblConsulta = new Label();
            lblCor = new Label();
            label1 = new Label();
            label2 = new Label();
            pnlFuncionarios.SuspendLayout();
            pnlPartos.SuspendLayout();
            pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();



            chartPartos.Location = new Point(15, 30);
            chartPartos.Name = "chartPartos";
            chartPartos.Size = new Size(157, 157);
            ChartArea areaPartos = new ChartArea();
            chartPartos.ChartAreas.Add(areaPartos);



            chartFuncionarios.Location = new Point(31, 30);
            chartFuncionarios.Name = "chartFuncionarios";
            chartFuncionarios.Size = new Size(325, 137);
            ChartArea area = new ChartArea();
            chartFuncionarios.ChartAreas.Add(area);
            // 
            // pnlFuncionarios
            // 
            pnlFuncionarios.BorderStyle = BorderStyle.FixedSingle;
            pnlFuncionarios.Controls.Add(label2);
            pnlFuncionarios.Controls.Add(lblQuantidade);
            pnlFuncionarios.Controls.Add(lblFuncionarios);
            pnlFuncionarios.Location = new Point(12, 12);
            pnlFuncionarios.Name = "pnlFuncionarios";
            pnlFuncionarios.Size = new Size(391, 197);
            pnlFuncionarios.TabIndex = 0;
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
            // pnlPartos
            // 
            pnlPartos.BorderStyle = BorderStyle.FixedSingle;
            pnlPartos.Controls.Add(label1);
            pnlPartos.Controls.Add(lblCor);
            pnlPartos.Controls.Add(lblCesarea);
            pnlPartos.Controls.Add(lblNormal);
            pnlPartos.Controls.Add(lblPartos);
            pnlPartos.Controls.Add(chartPartos);
            pnlPartos.Location = new Point(418, 12);
            pnlPartos.Name = "pnlPartos";
            pnlPartos.Size = new Size(370, 197);
            pnlPartos.TabIndex = 3;
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
            // pnlConsulta
            // 
            pnlConsulta.BorderStyle = BorderStyle.FixedSingle;
            pnlConsulta.Controls.Add(txtBusca);
            pnlConsulta.Controls.Add(dgvConsulta);
            pnlConsulta.Controls.Add(lblConsulta);
            pnlFuncionarios.Controls.Add(chartFuncionarios);
            pnlConsulta.Location = new Point(12, 224);
            pnlConsulta.Name = "pnlConsulta";
            pnlConsulta.Size = new Size(776, 214);
            pnlConsulta.TabIndex = 4;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(606, 5);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar...";
            txtBusca.Size = new Size(153, 23);
            txtBusca.TabIndex = 2;
            txtBusca.TextChanged += TextChanged_txtBusca;
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
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCor.ForeColor = Color.Gold;
            lblCor.Location = new Point(226, 74);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(34, 37);
            lblCor.TabIndex = 4;
            lblCor.Text = "o";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(226, 49);
            label1.Name = "label1";
            label1.Size = new Size(34, 37);
            label1.TabIndex = 5;
            label1.Text = "o";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(92, 152);
            label2.Name = "label2";
            label2.Size = new Size(34, 37);
            label2.TabIndex = 6;
            label2.Text = "o";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlConsulta);
            Controls.Add(pnlPartos);
            Controls.Add(pnlFuncionarios);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Lyon Company Maternidades";
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            pnlFuncionarios.ResumeLayout(false);
            pnlFuncionarios.PerformLayout();
            pnlPartos.ResumeLayout(false);
            pnlPartos.PerformLayout();
            pnlConsulta.ResumeLayout(false);
            pnlConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFuncionarios;
        private Label lblQuantidade;
        private Chart chartFuncionarios;
        private Label lblFuncionarios;
        private Panel pnlPartos;
        private Label lblCesarea;
        private Label lblNormal;
        private Chart chartPartos;
        private Label lblPartos;
        private Panel pnlConsulta;
        private DataGridView dgvConsulta;
        private Label lblConsulta;
        private TextBox txtBusca;
        private Label label2;
        private Label label1;
        private Label lblCor;
    }
}