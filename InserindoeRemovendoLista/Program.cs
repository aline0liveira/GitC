using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserindoeRemovendoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //criamos a nossa base de dados inicial
            string[,] baseDeDados = new string[2, 5];

            // Indicador dos registros realizados em nosso sistema
            int IndiceBaseDeDados = 0;

            //Apresentação inicial do nosso sistema
            Console.WriteLine("Iniciando sistema de lista de nome e idade:");

            // Criamos a varavel fora
            var escolhaInicial = ApresentaMenuInicial();

            //Loop infinito ate que de uma treta
            while(true)
            {
                //Iniciando a escolha do nosso menu
                switch(escolhaInicial)
                {
                    //1- Insere as informações
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    case "2": { RemoverInformacoes (ref baseDeDados); } break;
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    case "4": { MostrarInformacoes(baseDeDados, "true"); } break;
                    case "5": {
                            //Return dentro do nosso caso de escolha ele sai do nosso meto principal ou metodo que estamos dentro do contexto
                            return;
                        }
                }
                // Alimento s escolha novamente
                escolhaInicial = ApresentaMenuInicial();
            }
        }
        /// <summary>
        /// Apresenta as informações do menu inicial
        /// </summary>
        /// <returns> Retorna o menu escolhido </returns>
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1- Inserir um novo registro");
            Console.WriteLine("2- Remover um novo registro");
            Console.WriteLine("3- Listar Informações");
            Console.WriteLine("4- Listar as informações desativdas");
            Console.WriteLine("5- Sair do Sistema");

            Console.WriteLine("Digite o numero da opção desejada:");
            return Console.ReadLine();
        }

        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados 
        /// </summary>
        /// <param name="baseDeDados"> Base de dados como ref para alterar para todos os metodos</param>
        /// <param name="IndiceBaseDeDados"> Indice da nossa base como ref para alterar em todos os metodos</param>
        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int IndiceBaseDeDados)
        {
            Console.WriteLine("-----------------------Inserindo valores na lista-----------------");
            Console.WriteLine("Informe um nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            var idade = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;
                //identificamos de maneira unica nosso registro "("e")" garante que ele incremente primeiro antes de fazer a conversao para string
                baseDeDados[i, 0] = (IndiceBaseDeDados++).ToString();

                // Carregamos na segunda coluna o valor da nome
                baseDeDados[i, 1] = nome;

                //Carregamos a segunda coluna com o valor da idade
                baseDeDados[i, 2] = idade;
                // Finalizamos aqui para apenas inserir um registro por vez
                baseDeDados[i, 3] = "true";

                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss");
                break;
            }
            //Informamos para o usuario que finalizou o registro e agora o mesmo irá voltar para o menu incial
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();


        }

        public static void MostrarInformacoes(string[,] baseDeDados, string MostrarRegistrosNAtivos = "false")
        {
            
           
            Console.WriteLine("Apresentação das informações dentro da base de dados.");
            if(MostrarRegistrosNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(baseDeDados[i,3] != MostrarRegistrosNAtivos)
                Console.WriteLine($"ID{baseDeDados[i, 0]}" +
                    $" - Nome: {baseDeDados[i, 1]} " +
                    $"- Idade:{baseDeDados[i, 2]} ");
                //Finalizamos a operação e indicamos que nao existe mais operações a serem realizadas em nosso metodo
            }
            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla");
            Console.ReadKey();


        }

        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("Area de remoção de registro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {

                if(baseDeDados[i,3] !="false")
                Console.WriteLine($"ID{baseDeDados[i, 0]}" +
                        $" - Nome: {baseDeDados[i, 1]} " +
                        $"- Idade:{baseDeDados[i, 2]} ");
            }
            Console.WriteLine("Informe o id do registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(baseDeDados[i,0] !=null && baseDeDados[i,0] == id)
                {
                    baseDeDados[i, 3] = "false";
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss");
                  
                }
            }
            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial aperte qualquer tecla");
            Console.ReadKey();

        }
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            //Verifica se precisa criar uma lista maior
            var limiteDaLista = true;
            //Laço que verifica se existe registro disponivel
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Caso ainda existir registro disponivel ele seta nossa variavel "limiteDaLista" para false
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro nossa variavel ficou como true então indica que precisamos aumentar nossa lista
            if (limiteDaLista)
            {
                //criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = baseDeDados;
                //Aqui Limpamos nossa lista antigas e assinamos novamente com uma lista com mais espaços
                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador unico
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    baseDeDados[i, 2] = listaCopia[i, 2];
                    baseDeDados[i, 3] = listaCopia[i, 3];
                    baseDeDados[i, 4] = listaCopia[i, 4];
                }
                //indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }

        }
    }

    }

