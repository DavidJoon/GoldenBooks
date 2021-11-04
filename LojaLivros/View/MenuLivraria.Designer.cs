namespace LojaLivros
{
    partial class MenuLivraria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLivraria));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelGolden = new System.Windows.Forms.Label();
            this.labelPesqMenu = new System.Windows.Forms.Label();
            this.textBoxPesqMenu = new System.Windows.Forms.TextBox();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPesqMenu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesqCod = new System.Windows.Forms.TextBox();
            this.labelDigCod = new System.Windows.Forms.Label();
            this.textBoxAnoIns = new System.Windows.Forms.TextBox();
            this.textBoxEditoraIns = new System.Windows.Forms.TextBox();
            this.textBoxNomeIns = new System.Windows.Forms.TextBox();
            this.labelAnoIns = new System.Windows.Forms.Label();
            this.labelEditoraIns = new System.Windows.Forms.Label();
            this.labelNomeIns = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.labelCodRes = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem1});
            this.livrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.BackColor = System.Drawing.Color.DarkRed;
            this.adicionarToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem1.Text = "Adicionar";
            this.adicionarToolStripMenuItem1.Click += new System.EventHandler(this.adicionarToolStripMenuItem1_Click);
            // 
            // labelGolden
            // 
            this.labelGolden.AutoSize = true;
            this.labelGolden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGolden.Location = new System.Drawing.Point(229, 42);
            this.labelGolden.Name = "labelGolden";
            this.labelGolden.Size = new System.Drawing.Size(178, 29);
            this.labelGolden.TabIndex = 1;
            this.labelGolden.Text = "Golden Books";
            // 
            // labelPesqMenu
            // 
            this.labelPesqMenu.AutoSize = true;
            this.labelPesqMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesqMenu.ForeColor = System.Drawing.Color.Gold;
            this.labelPesqMenu.Location = new System.Drawing.Point(58, 57);
            this.labelPesqMenu.Name = "labelPesqMenu";
            this.labelPesqMenu.Size = new System.Drawing.Size(130, 18);
            this.labelPesqMenu.TabIndex = 2;
            this.labelPesqMenu.Text = "Pesquisar Livro:";
            // 
            // textBoxPesqMenu
            // 
            this.textBoxPesqMenu.Location = new System.Drawing.Point(194, 58);
            this.textBoxPesqMenu.Name = "textBoxPesqMenu";
            this.textBoxPesqMenu.Size = new System.Drawing.Size(237, 20);
            this.textBoxPesqMenu.TabIndex = 3;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.editora,
            this.ano});
            this.dataGridViewMenu.GridColor = System.Drawing.Color.Black;
            this.dataGridViewMenu.Location = new System.Drawing.Point(3, 126);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.Size = new System.Drawing.Size(536, 158);
            this.dataGridViewMenu.TabIndex = 4;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // editora
            // 
            this.editora.HeaderText = "Editora";
            this.editora.Name = "editora";
            this.editora.Width = 150;
            // 
            // ano
            // 
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            // 
            // buttonPesqMenu
            // 
            this.buttonPesqMenu.BackColor = System.Drawing.Color.Gold;
            this.buttonPesqMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesqMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesqMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonPesqMenu.Location = new System.Drawing.Point(446, 58);
            this.buttonPesqMenu.Name = "buttonPesqMenu";
            this.buttonPesqMenu.Size = new System.Drawing.Size(75, 30);
            this.buttonPesqMenu.TabIndex = 5;
            this.buttonPesqMenu.Text = "Pesquisar";
            this.buttonPesqMenu.UseVisualStyleBackColor = false;
            this.buttonPesqMenu.Click += new System.EventHandler(this.buttonPesqMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(34, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 284);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBoxPesqCod);
            this.tabPage2.Controls.Add(this.labelDigCod);
            this.tabPage2.Controls.Add(this.textBoxAnoIns);
            this.tabPage2.Controls.Add(this.textBoxEditoraIns);
            this.tabPage2.Controls.Add(this.textBoxNomeIns);
            this.tabPage2.Controls.Add(this.labelAnoIns);
            this.tabPage2.Controls.Add(this.labelEditoraIns);
            this.tabPage2.Controls.Add(this.labelNomeIns);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Código";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(238, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPesqCod
            // 
            this.textBoxPesqCod.Location = new System.Drawing.Point(161, 24);
            this.textBoxPesqCod.Name = "textBoxPesqCod";
            this.textBoxPesqCod.Size = new System.Drawing.Size(71, 20);
            this.textBoxPesqCod.TabIndex = 18;
            // 
            // labelDigCod
            // 
            this.labelDigCod.AutoSize = true;
            this.labelDigCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigCod.ForeColor = System.Drawing.Color.Gold;
            this.labelDigCod.Location = new System.Drawing.Point(22, 26);
            this.labelDigCod.Name = "labelDigCod";
            this.labelDigCod.Size = new System.Drawing.Size(133, 18);
            this.labelDigCod.TabIndex = 17;
            this.labelDigCod.Text = "Código do Livro:";
            // 
            // textBoxAnoIns
            // 
            this.textBoxAnoIns.Location = new System.Drawing.Point(191, 189);
            this.textBoxAnoIns.Name = "textBoxAnoIns";
            this.textBoxAnoIns.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnoIns.TabIndex = 15;
            // 
            // textBoxEditoraIns
            // 
            this.textBoxEditoraIns.Location = new System.Drawing.Point(191, 135);
            this.textBoxEditoraIns.Name = "textBoxEditoraIns";
            this.textBoxEditoraIns.Size = new System.Drawing.Size(148, 20);
            this.textBoxEditoraIns.TabIndex = 14;
            // 
            // textBoxNomeIns
            // 
            this.textBoxNomeIns.Location = new System.Drawing.Point(191, 81);
            this.textBoxNomeIns.Name = "textBoxNomeIns";
            this.textBoxNomeIns.Size = new System.Drawing.Size(311, 20);
            this.textBoxNomeIns.TabIndex = 13;
            // 
            // labelAnoIns
            // 
            this.labelAnoIns.AutoSize = true;
            this.labelAnoIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnoIns.ForeColor = System.Drawing.Color.Gold;
            this.labelAnoIns.Location = new System.Drawing.Point(32, 191);
            this.labelAnoIns.Name = "labelAnoIns";
            this.labelAnoIns.Size = new System.Drawing.Size(153, 18);
            this.labelAnoIns.TabIndex = 12;
            this.labelAnoIns.Text = "Ano de Publicação:";
            // 
            // labelEditoraIns
            // 
            this.labelEditoraIns.AutoSize = true;
            this.labelEditoraIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditoraIns.ForeColor = System.Drawing.Color.Gold;
            this.labelEditoraIns.Location = new System.Drawing.Point(118, 137);
            this.labelEditoraIns.Name = "labelEditoraIns";
            this.labelEditoraIns.Size = new System.Drawing.Size(67, 18);
            this.labelEditoraIns.TabIndex = 11;
            this.labelEditoraIns.Text = "Editora:";
            // 
            // labelNomeIns
            // 
            this.labelNomeIns.AutoSize = true;
            this.labelNomeIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeIns.ForeColor = System.Drawing.Color.Gold;
            this.labelNomeIns.Location = new System.Drawing.Point(61, 83);
            this.labelNomeIns.Name = "labelNomeIns";
            this.labelNomeIns.Size = new System.Drawing.Size(124, 18);
            this.labelNomeIns.TabIndex = 10;
            this.labelNomeIns.Text = "Nome do Livro:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.textBoxCod);
            this.groupBox1.Controls.Add(this.buttonDeletar);
            this.groupBox1.Controls.Add(this.labelCodRes);
            this.groupBox1.Controls.Add(this.buttonAlterar);
            this.groupBox1.Location = new System.Drawing.Point(22, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 169);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(421, 65);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.ReadOnly = true;
            this.textBoxCod.Size = new System.Drawing.Size(59, 20);
            this.textBoxCod.TabIndex = 21;
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.Red;
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletar.ForeColor = System.Drawing.Color.Black;
            this.buttonDeletar.Location = new System.Drawing.Point(399, 113);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(81, 37);
            this.buttonDeletar.TabIndex = 24;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // labelCodRes
            // 
            this.labelCodRes.AutoSize = true;
            this.labelCodRes.BackColor = System.Drawing.Color.Black;
            this.labelCodRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodRes.ForeColor = System.Drawing.Color.Gold;
            this.labelCodRes.Location = new System.Drawing.Point(348, 64);
            this.labelCodRes.Name = "labelCodRes";
            this.labelCodRes.Size = new System.Drawing.Size(67, 18);
            this.labelCodRes.TabIndex = 20;
            this.labelCodRes.Text = "Código:";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.Color.Black;
            this.buttonAlterar.Location = new System.Drawing.Point(303, 113);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(81, 37);
            this.buttonAlterar.TabIndex = 23;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.buttonPesqMenu);
            this.tabPage1.Controls.Add(this.dataGridViewMenu);
            this.tabPage1.Controls.Add(this.textBoxPesqMenu);
            this.tabPage1.Controls.Add(this.labelPesqMenu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por Nome";
            // 
            // MenuLivraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(625, 385);
            this.Controls.Add(this.labelGolden);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuLivraria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Livraria";
            this.Load += new System.EventHandler(this.MenuLivraria_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.Label labelGolden;
        private System.Windows.Forms.Label labelPesqMenu;
        private System.Windows.Forms.TextBox textBoxPesqMenu;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button buttonPesqMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesqCod;
        private System.Windows.Forms.Label labelDigCod;
        private System.Windows.Forms.TextBox textBoxAnoIns;
        private System.Windows.Forms.TextBox textBoxEditoraIns;
        private System.Windows.Forms.TextBox textBoxNomeIns;
        private System.Windows.Forms.Label labelAnoIns;
        private System.Windows.Forms.Label labelEditoraIns;
        private System.Windows.Forms.Label labelNomeIns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Label labelCodRes;
        private System.Windows.Forms.Button buttonAlterar;
    }
}