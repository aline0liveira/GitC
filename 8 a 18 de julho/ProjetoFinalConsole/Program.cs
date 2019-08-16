using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 5];

            int Indice = 0;
            Console.WriteLine("Sistema Biblioteca");

            var escolha = MenuInicial();

            while (true)

            {
                switch (escolha)
                {
                    case "1": { InsereValor(ref baseDeDados, ref Indice); } break;
                    case "2": { RemoveValor(ref baseDeDados); } break;
                    case "3": { MostrarInfos(baseDeDados); } break;
                    case "4": { MostrarInfos(baseDeDados, "true"); } break;
                    case "5": { return; }


                }
                escolha = MenuInicial();
            }
        }
        public static string MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("               Menu de Opções  \n          ");
            Console.WriteLine("1 - Inseir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Lista as informações desativadas.");
            Console.WriteLine("5 - Sair ");
            Console.WriteLine("Digite o número da opção que corresponde ao que dejesa:");
            return Console.ReadLine();
        }
        public static void InsereValor(ref string[,] baseDeDados, ref int IndiceDaBase)
        {
            Console.WriteLine(" Inserindo os valores na Lista ");
            Console.WriteLine("Insira o Nome do livro:");
            var nomeDoLivro = Console.ReadLine();

            Console.WriteLine(" Insira o Autor do Livro:");
            var autor = Console.ReadLine();

            AumentaLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (IndiceDaBase++).ToString();
                baseDeDados[i, 1] = nomeDoLivro;
                baseDeDados[i, 2] = autor;
                baseDeDados[i, 3] = "true";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                break;

            }
            Console.WriteLine(" Cadastro feito com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }
        public static void MostrarInfos(string[,] baseDeDados, string RegistroNAtivos = "false")
        {
            Console.WriteLine("Apresentação das informações na Base de dados");
            if (RegistroNAtivos == "true")
                Console.WriteLine("Registros que estão Desativados.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != RegistroNAtivos)
                    Console.WriteLine($"id {baseDeDados[i, 0]} " + $"- Nome do Livro:{baseDeDados[i, 1]} " + $"- Autor:{baseDeDados[i, 2]}" + $"- Data de Alteração:{baseDeDados[i, 4]}");
            }
            Console.WriteLine("Resultados feitos com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();
        }

        public static void RemoveValor(ref string[,] baseDeDados)
        {
            Console.WriteLine("Removendo o Registro do sistema");
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != "false")
                    Console.WriteLine($"Id:{baseDeDados[i, 0]} " +
                 $"- Nome do Livro:{baseDeDados[i, 1]} " +
                 $"- Autor:{baseDeDados[i, 2]})" +
                 $"- Data de Alteração:{baseDeDados[i, 3]}");
            }
            Console.WriteLine(" Escolha o ID para remoção");
            var ID = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == ID)
                {
                    baseDeDados[i, 3] = "false";
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            Console.WriteLine("Finalizado.");
            Console.WriteLine("Para retornar ao menu inicial apertar uma tecla.");
            Console.ReadKey();
        }
        public static void AumentaLista(ref string[,] baseDeDados)
        {
            var LimiteLista = true;
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] == null)
                    LimiteLista = false;
            }
            if (LimiteLista)
            {
                var CopiaLista = baseDeDados;
                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];

                for (int i = 0; i < CopiaLista.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = CopiaLista[i, 0];
                    baseDeDados[i, 1] = CopiaLista[i, 1];
                    baseDeDados[i, 2] = CopiaLista[i, 2];
                    baseDeDados[i, 3] = CopiaLista[i, 3];
                    baseDeDados[i, 4] = CopiaLista[i, 4];
                }

                Console.WriteLine("O tamanho da lista foi atualizada com sucesso");
            }
        }
    }

}
