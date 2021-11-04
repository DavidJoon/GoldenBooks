using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLivros.Model
{
    class Livro
    {
        private static int codigo;
        private static string nomelivro;
        private static string editoralivro;
        private static string anolivro;
        private static string retorno;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Nomelivro { get => nomelivro; set => nomelivro = value; }
        public static string Editoralivro { get => editoralivro; set => editoralivro = value; }
        public static string Anolivro { get => anolivro; set => anolivro = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
