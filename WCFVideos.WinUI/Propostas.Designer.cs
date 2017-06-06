namespace WCFVideos.WinUI
{
    partial class Propostas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RelacaoDePropostas = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoDePropostas)).BeginInit();
            this.SuspendLayout();
            // 
            // RelacaoDePropostas
            // 
            this.RelacaoDePropostas.AllowUserToAddRows = false;
            this.RelacaoDePropostas.AllowUserToDeleteRows = false;
            this.RelacaoDePropostas.AllowUserToResizeColumns = false;
            this.RelacaoDePropostas.AllowUserToResizeRows = false;
            this.RelacaoDePropostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RelacaoDePropostas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Valor,
            this.Parcelas,
            this.Juros,
            this.Cliente,
            this.Salario});
            this.RelacaoDePropostas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelacaoDePropostas.Location = new System.Drawing.Point(12, 12);
            this.RelacaoDePropostas.MultiSelect = false;
            this.RelacaoDePropostas.Name = "RelacaoDePropostas";
            this.RelacaoDePropostas.ReadOnly = true;
            this.RelacaoDePropostas.RowHeadersVisible = false;
            this.RelacaoDePropostas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RelacaoDePropostas.Size = new System.Drawing.Size(577, 263);
            this.RelacaoDePropostas.TabIndex = 0;
            // 
            // Data
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Data.Width = 80;
            // 
            // Valor
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Valor.Width = 80;
            // 
            // Parcelas
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Parcelas.DefaultCellStyle = dataGridViewCellStyle3;
            this.Parcelas.HeaderText = "Parcelas";
            this.Parcelas.Name = "Parcelas";
            this.Parcelas.ReadOnly = true;
            this.Parcelas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Parcelas.Width = 60;
            // 
            // Juros
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            this.Juros.DefaultCellStyle = dataGridViewCellStyle4;
            this.Juros.HeaderText = "Juros";
            this.Juros.Name = "Juros";
            this.Juros.ReadOnly = true;
            this.Juros.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Juros.Width = 60;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cliente.Width = 214;
            // 
            // Salario
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Salario.DefaultCellStyle = dataGridViewCellStyle5;
            this.Salario.HeaderText = "Salário";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Salario.Width = 80;
            // 
            // Propostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 287);
            this.Controls.Add(this.RelacaoDePropostas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Propostas";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Relação de Propostas";
            this.Load += new System.EventHandler(this.Propostas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoDePropostas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RelacaoDePropostas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;

    }
}