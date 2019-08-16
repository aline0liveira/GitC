using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensao
            string[,] listaDeNome = new string[5, 2];

            CarregaInformacoesEListaElasEmTela(ref listaDeNome);

            // Após carregar as informações e mostrar em tela ele espera um comando
            Console.ReadKey();

            // Indicamos que o usuario precisa informar um numero de identificação para pesquisar um registro.
            Console.WriteLine("Informe o ID do resgistro a ser pesquisado.");

            // Aqui como realizamos a pesquisa somente na chamada passamos a nossa lista normalmente pois nao iremos alterar e apenas pesquisar a infromação
            // Após a virgula temos o console readline que espera nosso identificar unico
            PesquisandoInformacoesNaNossaLista(listaDeNome, Console.ReadLine());

            Console.ReadKey();


        }



        /// <summary>
        /// Metodo que carrega as informacoes dentro da nossa lista criada no metodo MAIN
        /// </summary>
        /// <param name="arraybi"> Nossa Lista a ser caarregada</param>
        public static void CarregaInformacoesEListaElasEmTela(ref string[,] arrayBi)
        {
            //Usando um laco simples para colocar valores mas no mesmo agora utilizando o getlenght com parametro 0 para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                // carregando o que podemos chamar de ID identificador do nosso registro unico
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informacao extra para deixar legal
                arrayBi[i, 1] = $"Aline_{i}";
            }

            // lembrando que getlength é um metodo e usamos "(parametro)" com parametro ou as vezes sem para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam aprsentados
                Console.WriteLine($"ID:{arrayBi[i, 0]} Nome{arrayBi[i, 1]}");


            }
        }






        /// <summary>
        /// Metodo que realiza a pesquisa pelo identificar unico de nossa coleçao
        /// </summary>
        /// <param name="arrayBi"> Nossa colecao de informacoes</param>
        /// <param name="pId"> Nosso identificador unico</param>
        public static void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)
                {// Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida Id:{arrayBi[i, 0]} Nome{arrayBi[i, 1]}");
                    // Aqui saimos da nossa lista mas retornamos vazio return; pois estamos em um metodo vazio void que nao espera retornar algo
                    return;
                }
            }
            //Caso ele passe por esta linha identificamos que ele ao encontrou resultados compatíveis
            Console.WriteLine("Infelizmente a busca pelo id nao resultou em nenhuma informacao.");
        }

    }
}
