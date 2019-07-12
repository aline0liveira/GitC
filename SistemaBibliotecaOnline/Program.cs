using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

        

            var opcaoMenu = MenuPrincipal();

            while(opcaoMenu !=3) // enquanto  opcao menu for diferente de 3 
            {
                if (opcaoMenu == 1) // se a alocacao for 1 mostra o menu
                    AlocarUmLivro();

                if (opcaoMenu == 2) // se a alocacao for 1 mostra o menu
                    DesalocarUmLivro();

                opcaoMenu = MenuPrincipal();
            }
            Console.ReadKey();



        }

        /// <summary>
        /// Método que apresenta o sistema. 
        /// </summary>

        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("     Bem Vindo ao Sistema de Alocação de Livros!     ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("         Desenvolvido pela indústria N.S.A                   ");
            Console.WriteLine("------------------------------------------------------");

        }
        /// <summary>
        /// Metodo que mostra o conteudo do menu e as opcoes de escolha.
        /// </summary>
        /// <returns> Retorna o valor do menu escolhido em um tipo inteiro</returns>


        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine(" Menu - Inicial");
            Console.WriteLine("O que você deseja relizar?");
            Console.WriteLine("1- Alocar um livro.");
            Console.WriteLine("2- Devolver um livro");
            Console.WriteLine("3- Sair do Sistema");
            Console.WriteLine("Digite o número dsesejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;
        }
        /// <summary>
        /// Método que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                { "Alice no país das maravilhas", "sim" },
                { "Pinóquio", "não" }
            };
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado
        /// </summary>
        /// <param name="nomeDoLivro"> Nome do Livro pesquisado</param>
        /// <returns> Retorna verdadeiro se o livro estiver livre para alocação</returns>
        public static bool? PesquisaLivroParaAlocacao( ref string nomeDoLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0);i++) // Andando dentro da lista  e GetLength(0) representa a dimensão

            {
                if (CompararNomes(nomeDoLivro,baseDeLivros[i,0] ))
                    
                {
                    Console.WriteLine($" O livro: {nomeDoLivro}" +
                        $" pode ser alocado?:{baseDeLivros[i, 1]}");
                    return baseDeLivros[i, 1] == "sim";
                }
            }
            Console.WriteLine("Nenhum livro encontrado deseja realizar a busca novamente?");
            Console.WriteLine("Digite o numero desejado: sim(1) não (0)");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            
            if(opcao ==1)
            {
                Console.WriteLine("Digite o nome do livro a ser pesquisado:");
                nomeDoLivro = Console.ReadLine();

                return PesquisaLivroParaAlocacao( ref nomeDoLivro);
            }
            return null;
        }
        
        /// <summary>
        /// Metodo para altrar a informacao de alocacao do livro.
        /// </summary>
        /// <param name="nomeDolivro"> Valor booleano que define se o livro esta ou nao disponivel.</param>
        public static void AlocarLivro(string nomeDolivro, bool alocar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeDolivro, baseDeLivros[i, 0]))
                {
                    baseDeLivros[i, 1] = alocar? "não": "sim";
                }
            }
            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Livro atualizado com sucesso!:");
        }
        /// <summary>
        /// Método que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        /// 
        public static void AlocarUmLivro()
        {
            MostrarInicialDoLivro("Alocar um livro:");

            var nomeDoLivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomeDoLivro);

            if (resultadoPesquisa !=null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o livro? para sim(1) para não(0)");

                AlocarLivro(nomeDoLivro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
            if(resultadoPesquisa ==null)
            {
                Console.WriteLine("Nenhum Resultado encontrado em nossa base de dados");
            }
        }
         
        /// <summary>
        /// Metodo que mostra a lista de livros atualizado
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de Livros:");
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponível: {baseDeLivros[i, 1]}");
            }
        }

        public static void DesalocarUmLivro()
        {
            MostrarInicialDoLivro("Desalocar um livro");
            MostrarListaDeLivros();

            var nomeDoLivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomeDoLivro);
            if (resultadoPesquisa != null && resultadoPesquisa== false)// o if só precisa de uma verdade não precisa fazer a comparação
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o livro? para sim(1) para não(0)");

                
                    AlocarLivro(nomeDoLivro, Console.ReadKey().KeyChar.ToString() == "0");
                    


                MostrarListaDeLivros();

                Console.ReadKey();

            }
            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum Resultado encontrado em nossa base de dados");
            }
        }
        public static void MostrarInicialDoLivro(string operacao)
        {
            Console.Clear();
            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro para realizar a operação");
        }
        public static bool CompararNomes( string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "")
                    == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;
        }
    }
}






