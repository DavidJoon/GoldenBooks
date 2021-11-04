using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LojaLivros
{
    public partial class InserirLivro : Form
    {
        public InserirLivro()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirLivro", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@nome", textBoxNomeIns.Text);
                comando.Parameters.AddWithValue("@editora", textBoxEditoraIns.Text);
                comando.Parameters.AddWithValue("@ano", textBoxAnoIns.Text);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Livro cadastrado com sucesso., Deseja cadastrar outro livro ou sair?", "Novo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    textBoxNomeIns.Clear();
                    textBoxEditoraIns.Clear();
                    textBoxAnoIns.Clear();
                }
                else
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Livro não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }
    }
}
