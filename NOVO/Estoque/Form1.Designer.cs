namespace Estoque
{
    partial class Form1
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
            this.DataEstoque = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QndEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QndFalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PV = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // DataEstoque
            // 
            this.DataEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Tipo,
            this.QndEstoque,
            this.QndFalta});
            this.DataEstoque.Location = new System.Drawing.Point(12, 72);
            this.DataEstoque.Name = "DataEstoque";
            this.DataEstoque.Size = new System.Drawing.Size(543, 289);
            this.DataEstoque.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produtos em Estoque e Produtos a Vir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo para \r\na Entrega:";
            // 
            // Dias
            // 
            this.Dias.Location = new System.Drawing.Point(661, 136);
            this.Dias.Name = "Dias";
            this.Dias.Size = new System.Drawing.Size(100, 20);
            this.Dias.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pedidos Vindo:";
            // 
            // PV
            // 
            this.PV.FormattingEnabled = true;
            this.PV.Location = new System.Drawing.Point(561, 199);
            this.PV.Name = "PV";
            this.PV.Size = new System.Drawing.Size(200, 121);
            this.PV.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 373);
            this.Controls.Add(this.PV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataEstoque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QndEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn QndFalta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox PV;
    }
}

