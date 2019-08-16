using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Inserindo Manualmente
namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da nossa lista
            string[,] listaDeNome = new string[2, 2];

            //Aqui vamos criar uma forma externa de identificar nossos registros
            int IdParaLista = 0;

            InsereRegistro(ref listaDeNome, ref IdParaLista);
            Console.ReadKey();

            InsereRegistro(ref listaDeNome, ref IdParaLista);
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que insere novo registro
        /// </summary>
        /// <param name="listaDeNome"></param>
        /// <param name="IdParaLista"></param>
        public static void InsereRegistro(ref string[,] listaDeNome, ref int IdParaLista)
        {
            //Aqui estaremos em m laco para informar nossos registros
            for (int i = 0; i < listaDeNome.GetLength(0); i++)

            {
                if (listaDeNome[i, 0] != null)
                    continue;
                //Indicamos que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("Informe um nome para adicionar um registro:");
                var nome = Console.ReadLine();
                //Criamos o nosso identificador unico com um objeto externo que mesmo apos sairmos do nosso laco ainda poderar ser incrementado
                listaDeNome[i, 0] = (IdParaLista++).ToString();
                //Aqui colocamos nosso nome na lista
                listaDeNome[i, 1] = nome;


                //identificamos se o mesmo ainda deseja inserir registros dentro da nossa lista
                Console.WriteLine("Deseja inserir um novo registro? sim(1) ou Não(0");

                //O readKey So espera um aunica tecla e no sretorna a tecla que foi acionadae não o valor dela por isso usamos o keychar para pegar esse valor e converter
                var continuar = Console.ReadKey().KeyChar.ToString();

                // Aqui validamos a condicao se o mesmo deve ou não continuar a add o registro até que a nossa lista esteja completa de informacoes

                if (continuar == "0")
                    break; //Break e uma palavra reservada do c# que para , por isso break, todo laco de repeticao ou sequenciador logico o.0.
                AumentaTamanhoLista(ref listaDeNome);

            }
            Console.WriteLine("Registro adicionados com sucesso, segue a lista de informacoes adicionadas:");

            //Mas agora a coisa muda,
            for (int i = 0; i < listaDeNome.GetLength(0); i++)

                //Utilizamos o string format, basicamente ele faz da mesma forma que o sifrao a diferenca entre eles é que este e um cara em grande quantidades acaba sendo mais rapido
                Console.WriteLine(string.Format("Registro ID{0} Nome:{1}", listaDeNome[i, 0], listaDeNome[i, 1]));



        }
        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {
            // Verifica se precisa criar uma lista maior
            var limiteDaLista = true;

            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                if (ListaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }
            // caso nao tenha mais registro nossa variavel ficou como true entao indica que presamos aumentar a lista
             if(limiteDaLista)
            {
                //Criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = ListaDeNome;
                //Aqui Limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                }
                Console.WriteLine("O tamanho da lista foi atualizado");
            }
        }

    }
}
