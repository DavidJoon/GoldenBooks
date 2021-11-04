using LojaLivros.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaLivros.Controler
{
    class LivroController
    {
        public void cadastroLivro()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirAluno", conexao);
            comando.CommandType = CommandType.StoredProcedure;


            try
            {

                comando.Parameters.AddWithValue("@nome", Livro.Nomelivro);
                comando.Parameters.AddWithValue("@editora", Livro.Editoralivro);
                comando.Parameters.AddWithValue("@ano", Livro.Anolivro);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Livro cadastrado com sucesso! \n" +
                    "Deseja cadastrar outro Aluno ?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Livro.Retorno = "False";
                    return;
                }
                else
                {
                    Livro.Retorno = "True";
                    return;
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

        public void visuCodigoLivro()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoLivro", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {

                comandos.Parameters.AddWithValue("@codigo", Livro.Codigo);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    Livro.Nomelivro = tabelaDados["Livro"].ToString();
                    Livro.Editoralivro = tabelaDados["Editora"].ToString();
                    Livro.Anolivro = tabelaDados["Ano"].ToString();
                    Livro.Retorno = "True";

                }
                else
                {
                    MessageBox.Show("Livro não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Livro.Retorno = "False";
                }

            }
            catch
            {
                MessageBox.Show("Não conseguimos localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public static BindingSource visuNomeLivro()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscarLivro", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            comandos.Parameters.AddWithValue("@nome", "%" + Livro.Nomelivro + "%");
            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        public void alterarLivro()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarlivro", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Livro.Codigo);
                comandos.Parameters.AddWithValue("@nome", Livro.Nomelivro);
                comandos.Parameters.AddWithValue("@editora", Livro.Editoralivro);
                comandos.Parameters.AddWithValue("@ano", Livro.Anolivro);

                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Livro Alterado com sucesso!");
                Livro.Retorno = "True";
            }
            catch
            {
                MessageBox.Show("Livro não alterado.");
                Livro.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void deletarLivro()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarLivro", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Livro.Codigo);
                conexao.Open();
                comandos.ExecuteNonQuery();
                Livro.Retorno = "True";
                MessageBox.Show("Livro Excluido com sucesso!");

            }
            catch
            {
                MessageBox.Show("Livro não Excluido.");
                Livro.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

    }
}
