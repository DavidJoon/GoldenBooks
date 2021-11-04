namespace LojaLivros
{
    partial class InserirLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirLivro));
            this.labelInserir = new System.Windows.Forms.Label();
            this.labelNomeIns = new System.Windows.Forms.Label();
            this.labelEditoraIns = new System.Windows.Forms.Label();
            this.labelAnoIns = new System.Windows.Forms.Label();
            this.textBoxNomeIns = new System.Windows.Forms.TextBox();
            this.textBoxEditoraIns = new System.Windows.Forms.TextBox();
            this.textBoxAnoIns = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInserir
            // 
            this.labelInserir.AutoSize = true;
            this.labelInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInserir.Location = new System.Drawing.Point(209, 37);
            this.labelInserir.Name = "labelInserir";
            this.labelInserir.Size = new System.Drawing.Size(219, 29);
            this.labelInserir.TabIndex = 0;
            this.labelInserir.Text = "Inserir Novo Livro";
            // 
            // labelNomeIns
            // 
            this.labelNomeIns.AutoSize = true;
            this.labelNomeIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeIns.Location = new System.Drawing.Point(99, 123);
            this.labelNomeIns.Name = "labelNomeIns";
            this.labelNomeIns.Size = new System.Drawing.Size(124, 18);
            this.labelNomeIns.TabIndex = 1;
            this.labelNomeIns.Text = "Nome do Livro:";
            // 
            // labelEditoraIns
            // 
            this.labelEditoraIns.AutoSize = true;
            this.labelEditoraIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditoraIns.Location = new System.Drawing.Point(156, 177);
            this.labelEditoraIns.Name = "labelEditoraIns";
            this.labelEditoraIns.Size = new System.Drawing.Size(67, 18);
            this.labelEditoraIns.TabIndex = 3;
            this.labelEditoraIns.Text = "Editora:";
            // 
            // labelAnoIns
            // 
            this.labelAnoIns.AutoSize = true;
            this.labelAnoIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnoIns.Location = new System.Drawing.Point(70, 231);
            this.labelAnoIns.Name = "labelAnoIns";
            this.labelAnoIns.Size = new System.Drawing.Size(153, 18);
            this.labelAnoIns.TabIndex = 4;
            this.labelAnoIns.Text = "Ano de Publicação:";
            // 
            // textBoxNomeIns
            // 
            this.textBoxNomeIns.Location = new System.Drawing.Point(229, 121);
            this.textBoxNomeIns.Name = "textBoxNomeIns";
            this.textBoxNomeIns.Size = new System.Drawing.Size(284, 20);
            this.textBoxNomeIns.TabIndex = 5;
            // 
            // textBoxEditoraIns
            // 
            this.textBoxEditoraIns.Location = new System.Drawing.Point(229, 175);
            this.textBoxEditoraIns.Name = "textBoxEditoraIns";
            this.textBoxEditoraIns.Size = new System.Drawing.Size(148, 20);
            this.textBoxEditoraIns.TabIndex = 6;
            // 
            // textBoxAnoIns
            // 
            this.textBoxAnoIns.Location = new System.Drawing.Point(229, 229);
            this.textBoxAnoIns.Name = "textBoxAnoIns";
            this.textBoxAnoIns.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnoIns.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(60, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.ForeColor = System.Drawing.Color.Black;
            this.buttonInserir.Location = new System.Drawing.Point(257, 300);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(110, 36);
            this.buttonInserir.TabIndex = 10;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // InserirLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(610, 365);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxAnoIns);
            this.Controls.Add(this.textBoxEditoraIns);
            this.Controls.Add(this.textBoxNomeIns);
            this.Controls.Add(this.labelAnoIns);
            this.Controls.Add(this.labelEditoraIns);
            this.Controls.Add(this.labelNomeIns);
            this.Controls.Add(this.labelInserir);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInserir;
        private System.Windows.Forms.Label labelNomeIns;
        private System.Windows.Forms.Label labelEditoraIns;
        private System.Windows.Forms.Label labelAnoIns;
        private System.Windows.Forms.TextBox textBoxNomeIns;
        private System.Windows.Forms.TextBox textBoxEditoraIns;
        private System.Windows.Forms.TextBox textBoxAnoIns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInserir;
    }
}

