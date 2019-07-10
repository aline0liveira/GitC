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

            MostrarSejaBemVindo();

            if (MenuInicial() == 1) // MenuInicial esta dentro do if se for 1 faz o menu inicial
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Menu - Alocação de Livros");
                Console.WriteLine("Digite o nome do livro a ser alocado:");

                var nomeDoLivro = Console.ReadLine();
                if (PesquisaLivroParaAlocacao(nomeDoLivro)) // o if só precisa de uma verdade não precisa fazer a comparação
                {
                    Console.Clear();
                    Console.WriteLine("Você deseja alocar o livro? para sim(1) para não(0)");
                    if (Console.ReadKey().KeyChar.ToString() == "1")
                    {
                        AlocarLivro(nomeDoLivro);
                        Console.Clear();
                        Console.WriteLine("Livro Alocado:");
                    }
                    else
                        Console.Clear();

                    Console.WriteLine("Listagem de Livros:");
                    for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                    {
                        Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponível: {baseDeLivros[i, 1]}");
                    }
                }





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


        public static int MenuInicial()
        {
            Console.WriteLine(" \r\nMenu - Inicial");
            Console.WriteLine("O que você deseja relizar?");
            Console.WriteLine("1- Alocar um livro.");
            Console.WriteLine("2- Sair do Sistema");
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
        public static bool PesquisaLivroParaAlocacao(string nomeDoLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++) // Andando dentro da lista  e GetLength(0) representa a dimensão

            {
                if (nomeDoLivro == baseDeLivros[i, 0])// representa a coluna
                {
                    Console.WriteLine($" O livro: {nomeDoLivro}" +
                        $" pode ser alocado?:{baseDeLivros[i, 1]}");
                    return baseDeLivros[i, 1] == "sim";
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeDolivro"> Nome do livro a ser locado</param>
        public static void AlocarLivro(string nomeDolivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeDolivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "não";
            }
        }
    }
}


