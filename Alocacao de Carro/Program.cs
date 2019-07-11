using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alocacao_de_Carro
{
    class Program

    {
        static string[,] baseDeCarros;
        static void Main(string[] args)
        {
            baseDeDados();
            var opcaoMenu = MenuPrincipalDoSistema();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                if(opcaoMenu == 3)
                {
                    MostrarListaDeCarros();
                    Console.Read();
                }
                opcaoMenu = MenuPrincipalDoSistema();
            }
            Console.ReadKey();
        

        }
        public static void SejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("         Sistema de alocação de Alocacao de Carros.");
            Console.WriteLine("________________________________________________");

            Console.WriteLine(" _______________");
            Console.WriteLine("|  __        __|____");
            Console.WriteLine("| |__|      |__|    |");
            Console.WriteLine("|__    ______  _____ |");
            Console.WriteLine("   (0)      (0)    ");



        }

        public static int MenuPrincipalDoSistema()
        {
            Console.Clear();

            SejaBemVindo();

            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um Carro.");
            Console.WriteLine("2 - Fazer a devolução do Carro.");
            Console.WriteLine("3 - Listar Carros.");
            Console.WriteLine("4 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        public static void baseDeDados()
        {
            baseDeCarros = new string[2, 3] // 2 linhas 3 colunas
            {
                { "Gol", "2015" , "sim"},
                { "Uno", "2017", "não"},
            };

        }
        public static bool PesquisaParaAlocar(string nomeDoCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeDoCarro == baseDeCarros[i, 0])
                {
                    Console.WriteLine($"O Carro: {nomeDoCarro}" +
                          $" Do Ano: {baseDeCarros[i, 1]}" +
                          $" Está Disponível para Alocacão: {baseDeCarros[i, 2]}");

                    return baseDeCarros[i, 2] == "sim";
                }
            }

            return false;
        }
        public static void AtualizarCarro(string nomeDoCarro, bool alocar)

        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {


                if (nomeDoCarro == baseDeCarros[i, 0])
                {

                    baseDeCarros[i, 2] = alocar ? "não" : "sim";
                }
            }

            Console.Clear();
            SejaBemVindo();
            Console.WriteLine("Carro atualizado com Sucesso!!!");


        }
        public static void AlocarUmCarro()
        {
            MostrarMenuInicialCarros("Alocar um Carro");

            var nomeDoCarro = Console.ReadLine();
            if (PesquisaParaAlocar(nomeDoCarro))
            {
                Console.Clear();
                SejaBemVindo();
                Console.WriteLine("Você deseja alocar um Carro? Sim(1) para Não(0)");
                AtualizarCarro(nomeDoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }
        public static void MostrarListaDeCarros()
        {
            Console.WriteLine("Listagem de Carros:");
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)

            {

                Console.WriteLine($"Nome:{baseDeCarros[i, 0]} Ano:{baseDeCarros[i, 1]} Disponível:{baseDeCarros[i, 2]} "); 

            }

        }
        public static void DesalocarUmCarro()
        {
            MostrarMenuInicialCarros("Desalocar um Livro:");

            MostrarListaDeCarros();

            var nomeDoCarro = Console.ReadLine();
            if (!PesquisaParaAlocar(nomeDoCarro))
            {
                Console.Clear();
                SejaBemVindo();
                Console.WriteLine("Você deseja desalocar o Carro? Sim(1) Não(0)");

                AtualizarCarro(nomeDoCarro, Console.ReadKey().KeyChar.ToString() == "2");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();

            SejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.Write("Digite o nome do Carro para realizar a operação:");
        }
    }
}
