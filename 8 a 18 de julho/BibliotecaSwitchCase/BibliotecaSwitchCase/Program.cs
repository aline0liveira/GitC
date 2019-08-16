using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados= new string[2, 3];

            int IndiceBaseDeDados = 0;

            Console.WriteLine("Iniciando sistema de lista de Livro e Ano.");

            var inicio = ApresentaMenuInicial();

            while (true)
            {
                switch (inicio)
                {

                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;

                    case "2": { RemoverInformacoes(ref baseDeDados); } break;

                    case "3": { MostrarInformacoes(baseDeDados); } break;

                    case "4": { return; }
                }

            }
            inicio = ApresentaMenuInicial();
        }
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu Biblioteca");
            Console.WriteLine("1 - Inseir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");

            return Console.ReadLine();
        }
        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("---------Inserindo valores na lista---------");

            Console.WriteLine("Informe o nome do Livro:");

            var nome = Console.ReadLine();

            Console.WriteLine("Informe o Ano do Livro");

            var ano = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (indiceBase++).ToString();

                baseDeDados[i, 1] = nome;

                baseDeDados[i, 2] = ano;

                break;
            }
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }
        public static void MostrarInformacoes(string[,] baseDeDados)
        {
            
            Console.WriteLine("Apresentação das informações dentro da base de dados.");
          
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                    $"- Nome:{baseDeDados[i, 1]} " +
                    $"- Ano:{baseDeDados[i, 2]}");

           
            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();
        }

        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {

            Console.WriteLine("Area de remoção de registro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID:{baseDeDados[i, 0]} " +
                    $"- Nome:{baseDeDados[i, 1]} " +
                    $"- Ano:{baseDeDados[i, 2]}");

            Console.WriteLine("Informe o id do registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 0] = null;
                    baseDeDados[i, 1] = null;
                    baseDeDados[i, 2] = null;
                }
            }

            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();
        }
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
           
            var limiteDaLista = true;
           
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
               
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }

            
            if (limiteDaLista)
            {
               
                var listaCopia = baseDeDados;
                
                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 3];
                
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                  
                    baseDeDados[i, 0] = listaCopia[i, 0];

                    baseDeDados[i, 1] = listaCopia[i, 1];
                  
                    baseDeDados[i, 2] = listaCopia[i, 2];
                }
               
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }
        }
    }
}


