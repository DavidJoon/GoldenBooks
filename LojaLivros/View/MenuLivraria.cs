using LojaLivros.Controler;
using LojaLivros.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaLivros
{
    public partial class MenuLivraria : Form
    {
        public MenuLivraria()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InserirLivro inserelivro = new InserirLivro();
            inserelivro.Show();
        }

        private void buttonPesqMenu_Click(object sender, EventArgs e)
        {
            if (textBoxPesqMenu.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca", "Atenção");
                textBoxPesqMenu.Focus();

                return;
            }

            Livro.Nomelivro = textBoxPesqMenu.Text;
            dataGridViewMenu.DataSource = LivroController.visuNomeLivro();

            dataGridViewMenu.Columns[0].Visible = false;
            dataGridViewMenu.Columns[1].Visible = false;
            dataGridViewMenu.Columns[2].Visible = false;
            dataGridViewMenu.Columns[3].Visible = false;
            dataGridViewMenu.Columns[4].HeaderCell.Value = "Código";
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Livro.Codigo = Convert.ToInt32(textBoxCod.Text);
            Livro.Nomelivro = textBoxNomeIns.Text;
            Livro.Editoralivro = textBoxEditoraIns.Text;
            Livro.Anolivro = textBoxAnoIns.Text;

            LivroController LivroController = new LivroController();
            LivroController.alterarLivro();

            limpaTudo();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {

            Livro.Codigo = Convert.ToInt32(textBoxPesqCod.Text);

            LivroController livroController = new LivroController();
            livroController.deletarLivro();

            limpaTudo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPesqCod.Text == "")
            {
                MessageBox.Show("Digite um código para a busca", "Atenção");
                textBoxPesqCod.Focus();
                textBoxCod.Clear();
                textBoxNomeIns.Clear();
                textBoxEditoraIns.Clear();
                textBoxAnoIns.Clear();
                return;
            }
            else
            {
                Livro.Codigo = Convert.ToInt32(textBoxPesqCod.Text);
                LivroController livro = new LivroController();
                livro.visuCodigoLivro();
                textBoxNomeIns.Text = Livro.Nomelivro;
                textBoxEditoraIns.Text = Livro.Editoralivro;
                textBoxAnoIns.Text = Livro.Anolivro;
                textBoxCod.Text = Livro.Codigo.ToString();
                buttonAlterar.Enabled = true;
                buttonDeletar.Enabled = true;
            }

            if (Livro.Retorno == "False")
            {

                limpaTudo();
            }
        }

        private void MenuLivraria_Load(object sender, EventArgs e)
        {
            buttonDeletar.Enabled = false;
            buttonAlterar.Enabled = false;
        }
        private void limpaTudo()
        {

            Livro.Codigo = 0;
            Livro.Nomelivro = "";
            Livro.Editoralivro = "";
            Livro.Anolivro = "";
            textBoxNomeIns.Clear();
            textBoxEditoraIns.Clear();
            textBoxAnoIns.Clear();
            textBoxCod.Clear();

            buttonAlterar.Enabled = false;
            buttonDeletar.Enabled = false;

        }
    }

}