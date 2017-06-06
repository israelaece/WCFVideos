namespace WCFVideos.WinUI
{
    partial class Principal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalDeRecurso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VisualizarPropostas = new System.Windows.Forms.Button();
            this.CriarNovaProposta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalDeRecurso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crédito";
            // 
            // TotalDeRecurso
            // 
            this.TotalDeRecurso.AutoSize = true;
            this.TotalDeRecurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDeRecurso.Location = new System.Drawing.Point(161, 34);
            this.TotalDeRecurso.Name = "TotalDeRecurso";
            this.TotalDeRecurso.Size = new System.Drawing.Size(52, 13);
            this.TotalDeRecurso.TabIndex = 1;
            this.TotalDeRecurso.Text = "R$ 0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Recurso Disponível:";
            // 
            // VisualizarPropostas
            // 
            this.VisualizarPropostas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisualizarPropostas.Location = new System.Drawing.Point(313, 106);
            this.VisualizarPropostas.Name = "VisualizarPropostas";
            this.VisualizarPropostas.Size = new System.Drawing.Size(134, 23);
            this.VisualizarPropostas.TabIndex = 1;
            this.VisualizarPropostas.Text = "Visualizar Propostas";
            this.VisualizarPropostas.UseVisualStyleBackColor = true;
            this.VisualizarPropostas.Click += new System.EventHandler(this.VisualizarPropostas_Click);
            // 
            // CriarNovaProposta
            // 
            this.CriarNovaProposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriarNovaProposta.Location = new System.Drawing.Point(13, 105);
            this.CriarNovaProposta.Name = "CriarNovaProposta";
            this.CriarNovaProposta.Size = new System.Drawing.Size(134, 23);
            this.CriarNovaProposta.TabIndex = 2;
            this.CriarNovaProposta.Text = "Criar Nova Proposta";
            this.CriarNovaProposta.UseVisualStyleBackColor = true;
            this.CriarNovaProposta.Click += new System.EventHandler(this.CriarNovaProposta_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 145);
            this.Controls.Add(this.CriarNovaProposta);
            this.Controls.Add(this.VisualizarPropostas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Sistema de Gestão de Crédito";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VisualizarPropostas;
        private System.Windows.Forms.Button CriarNovaProposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalDeRecurso;
    }
}