using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Model;
using Projeto.Input;
using Projeto.Persistence;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            LeituraProduto lp = new LeituraProduto();

            //Entrada dos Dados:
            p.Codigo    = lp.LerCodigo();
            p.Nome      = lp.LerNome();
            p.Preco     = lp.LerPreco();

            //Saída dos Dados:
            Console.WriteLine("\n---------------- Dados do Produto ----------------- ");
            Console.WriteLine("Codigo do Produto......: " + p.Codigo);
            Console.WriteLine("Nome do Produto........: " + p.Nome);
            Console.WriteLine("Preço do Produto.......: " + p.Preco);

            Arquivo a = new Arquivo();
            a.GravarExcel(p);

            Console.ReadKey();

        }
    }
}
