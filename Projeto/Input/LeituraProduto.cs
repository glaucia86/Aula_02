using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Projeto.Input
{
    //Classe para leitura do classe Produto:
    public class LeituraProduto
    {
        public int LerCodigo() 
        {
            try
            {
                Console.Write("Digite o Código do Produto.....: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                if (codigo > 0)
                {
                    return codigo;
                }
                else { 
                    throw new Exception("Código Inválido!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\t Erro.....: " + e.Message);
                return LerCodigo();
            }
        }

        public string LerNome()
        {
            try
            {
                Console.Write("Digite o Nome do Produto......: ");
                string nome = Console.ReadLine();

                //Criar expressão Regular:
                Regex reg = new Regex("^[A-Za-zÀ-Üà-ü0-9\\s]{3,30}$");

                if (reg.IsMatch(nome))
                {
                    return nome;
                }
                else 
                {
                    throw new Exception("Nome Inválido!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\t Erro...: " + e.Message);
                return LerNome();
            }
        }

        public decimal LerPreco() 
        {
            try
            {
                Console.Write("Digite o Preço do Produto......: R$ ");
                decimal preco = Convert.ToDecimal(Console.ReadLine());

                if (preco > 0 && preco <= 10000)
                {
                    return preco;
                }
                else 
                {
                    throw new Exception("Preço Inválido!!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\t Erro....: " + e.Message);
                return LerPreco();
            }
        }
    }
}
