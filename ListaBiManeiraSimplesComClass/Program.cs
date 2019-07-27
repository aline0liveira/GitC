using ListaBiManeiraSimplesComClass.Carrega;
using ListaBiManeiraSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
   
            // Aqui chamamos o nosso objeto em memoria
            var Nicholas = new CarregarLista();

            //aqui chamamos nosso metodo para carregar lista
            Nicholas.CarregaInformacoesEListaElasEmTela();

            // CARREGAMOS NOVAMENTE MAS AGORA A CLASSE MOSTRA LISTA AONDA COLOCAMOS TODOS OS METODOS QUE SERAO DIRECIONADOS PARA MOSTRAR
            // A LISTAGEM DE INFORMACOES NA TELA DE CONSOLE
            var Felipe = new MostarLista();

            // AQUI CHAMAMOS O METODO NOVAMENTE
            Felipe.PesquisandoInformacoesNaNossaLista(Nicholas.ListaNome, "0");

            Console.ReadKey();
        }
    }
}
