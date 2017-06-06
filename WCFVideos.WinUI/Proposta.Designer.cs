namespace WCFVideos.WinUI
{
    partial class Proposta
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
            this.Salario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Idade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Empresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QuantidadeDeParcelas = new System.Windows.Forms.ComboBox();
            this.TaxaDeJuros = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AnalisarProposta = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Salario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Idade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Empresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // Salario
            // 
            this.Salario.Location = new System.Drawing.Point(278, 79);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(124, 20);
            this.Salario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salário:";
            // 
            // Idade
            // 
            this.Idade.Location = new System.Drawing.Point(59, 79);
            this.Idade.MaxLength = 2;
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(67, 20);
            this.Idade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idade:";
            // 
            // Empresa
            // 
            this.Empresa.Location = new System.Drawing.Point(59, 51);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(343, 20);
            this.Empresa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(59, 24);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(343, 20);
            this.Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QuantidadeDeParcelas);
            this.groupBox2.Controls.Add(this.TaxaDeJuros);
            this.groupBox2.Controls.Add(this.Valor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empréstimo";
            // 
            // QuantidadeDeParcelas
            // 
            this.QuantidadeDeParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantidadeDeParcelas.FormattingEnabled = true;
            this.QuantidadeDeParcelas.Items.AddRange(new object[] {
            "12",
            "24",
            "36"});
            this.QuantidadeDeParcelas.Location = new System.Drawing.Point(141, 75);
            this.QuantidadeDeParcelas.Name = "QuantidadeDeParcelas";
            this.QuantidadeDeParcelas.Size = new System.Drawing.Size(84, 21);
            this.QuantidadeDeParcelas.TabIndex = 2;
            // 
            // TaxaDeJuros
            // 
            this.TaxaDeJuros.Location = new System.Drawing.Point(101, 49);
            this.TaxaDeJuros.Name = "TaxaDeJuros";
            this.TaxaDeJuros.Size = new System.Drawing.Size(124, 20);
            this.TaxaDeJuros.TabIndex = 1;
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(101, 23);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(124, 20);
            this.Valor.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Taxa de Juros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantidade de Parcelas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor:";
            // 
            // AnalisarProposta
            // 
            this.AnalisarProposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalisarProposta.Location = new System.Drawing.Point(292, 304);
            this.AnalisarProposta.Name = "AnalisarProposta";
            this.AnalisarProposta.Size = new System.Drawing.Size(131, 23);
            this.AnalisarProposta.TabIndex = 2;
            this.AnalisarProposta.Text = "Analisar Proposta";
            this.AnalisarProposta.UseVisualStyleBackColor = true;
            this.AnalisarProposta.Click += new System.EventHandler(this.AnalisarProposta_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Location = new System.Drawing.Point(13, 303);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(13, 17);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(96, 13);
            this.Data.TabIndex = 0;
            this.Data.Text = "Data: dd/MM/yyyy";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(343, 17);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(80, 13);
            this.Numero.TabIndex = 5;
            this.Numero.Text = "Número: 00000";
            this.Numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Proposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 339);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.AnalisarProposta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Proposta";
            this.Text = "Proposta";
            this.Load += new System.EventHandler(this.Proposta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AnalisarProposta;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Salario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Idade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox QuantidadeDeParcelas;
        private System.Windows.Forms.TextBox TaxaDeJuros;
        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}