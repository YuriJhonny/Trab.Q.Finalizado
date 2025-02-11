namespace NOVO
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DataCadastro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QndEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QndFalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeP = new System.Windows.Forms.TextBox();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.NumericQnd = new System.Windows.Forms.NumericUpDown();
            this.BotaoC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQnd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // DataCadastro
            // 
            this.DataCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Tipo,
            this.QndEstoque,
            this.QndFalta});
            this.DataCadastro.Location = new System.Drawing.Point(12, 58);
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Size = new System.Drawing.Size(543, 289);
            this.DataCadastro.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // QndEstoque
            // 
            this.QndEstoque.HeaderText = "Qnd em Estoque";
            this.QndEstoque.Name = "QndEstoque";
            // 
            // QndFalta
            // 
            this.QndFalta.HeaderText = "Qnd em Falta";
            this.QndFalta.Name = "QndFalta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qnd a Cadastrar:";
            // 
            // NomeP
            // 
            this.NomeP.Location = new System.Drawing.Point(234, 353);
            this.NomeP.Name = "NomeP";
            this.NomeP.Size = new System.Drawing.Size(112, 20);
            this.NomeP.TabIndex = 5;
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Bebida",
            "Comida"});
            this.ComboTipo.Location = new System.Drawing.Point(234, 378);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(112, 21);
            this.ComboTipo.TabIndex = 6;
            this.ComboTipo.Text = "Bebida ou Comida";
            // 
            // NumericQnd
            // 
            this.NumericQnd.Location = new System.Drawing.Point(234, 405);
            this.NumericQnd.Name = "NumericQnd";
            this.NumericQnd.Size = new System.Drawing.Size(112, 20);
            this.NumericQnd.TabIndex = 7;
            // 
            // BotaoC
            // 
            this.BotaoC.Location = new System.Drawing.Point(352, 353);
            this.BotaoC.Name = "BotaoC";
            this.BotaoC.Size = new System.Drawing.Size(80, 70);
            this.BotaoC.TabIndex = 8;
            this.BotaoC.Text = "Cadastrar\r\nProduto\r\n";
            this.BotaoC.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 427);
            this.Controls.Add(this.BotaoC);
            this.Controls.Add(this.NumericQnd);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.NomeP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataCadastro);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.DataCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QndEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn QndFalta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomeP;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.NumericUpDown NumericQnd;
        private System.Windows.Forms.Button BotaoC;
    }
}

