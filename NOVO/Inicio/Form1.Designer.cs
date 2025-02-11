namespace Inicio
{
    partial class Inicio
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
            this.BotaoParaEstoque = new System.Windows.Forms.Button();
            this.BotaoParaCadastroP = new System.Windows.Forms.Button();
            this.BotaoParaPedirP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione onde Você quer Ir";
            // 
            // BotaoParaEstoque
            // 
            this.BotaoParaEstoque.Location = new System.Drawing.Point(55, 52);
            this.BotaoParaEstoque.Name = "BotaoParaEstoque";
            this.BotaoParaEstoque.Size = new System.Drawing.Size(75, 60);
            this.BotaoParaEstoque.TabIndex = 1;
            this.BotaoParaEstoque.Text = "Estoque";
            this.BotaoParaEstoque.UseVisualStyleBackColor = true;
            // 
            // BotaoParaCadastroP
            // 
            this.BotaoParaCadastroP.Location = new System.Drawing.Point(136, 52);
            this.BotaoParaCadastroP.Name = "BotaoParaCadastroP";
            this.BotaoParaCadastroP.Size = new System.Drawing.Size(75, 60);
            this.BotaoParaCadastroP.TabIndex = 2;
            this.BotaoParaCadastroP.Text = "Cadastrar Produtos";
            this.BotaoParaCadastroP.UseVisualStyleBackColor = true;
            // 
            // BotaoParaPedirP
            // 
            this.BotaoParaPedirP.Location = new System.Drawing.Point(217, 52);
            this.BotaoParaPedirP.Name = "BotaoParaPedirP";
            this.BotaoParaPedirP.Size = new System.Drawing.Size(75, 60);
            this.BotaoParaPedirP.TabIndex = 3;
            this.BotaoParaPedirP.Text = "Pedir Produtos";
            this.BotaoParaPedirP.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 128);
            this.Controls.Add(this.BotaoParaPedirP);
            this.Controls.Add(this.BotaoParaCadastroP);
            this.Controls.Add(this.BotaoParaEstoque);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoParaEstoque;
        private System.Windows.Forms.Button BotaoParaCadastroP;
        private System.Windows.Forms.Button BotaoParaPedirP;
    }
}

