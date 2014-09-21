using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Projeto.Model;

namespace Projeto.Persistence
{
    //Classe para manipulação de Arquivos:
    public class Arquivo
    {
        public void GravarExcel(Produto p)
        {
            try
            {
                //Classe para gravação de arquivos:
                StreamWriter sw = new StreamWriter("C:\\Users\\Glaucia\\Documents\\Visual Studio 2012\\Projects\\Exemplos Curso - Coti Informatica 2014\\Aula_02\\temp\\estoque.csv",true);

                //Escrita no Arquivo:
                sw.WriteLine(p.Codigo + ";" + p.Nome + ";" + p.Preco);
                sw.Close();

                Console.WriteLine("\nDados Gravados com Sucesso!!!");
            }
            catch (Exception e)
            {
                throw new Exception("\nErro.....: " + e.Message);
            }

        }
    }
}
