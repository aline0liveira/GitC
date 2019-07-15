using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivo = new string[3, 3];

            int Id = 0;

            Inserindo(ref listaDeLivo, ref Id);

            Console.ReadKey();

            Inserindo(ref listaDeLivo, ref Id);

             Console.ReadKey();

        }

        public static void Inserindo(ref string[,] listaDeLivro, ref int Id)
        { 
            for (int i = 0; i < listaDeLivro.GetLength(0); i++)
            {
                Console.WriteLine("Insira o nome do Livro a ser registrado:");
                var nomeDoLivro = Console.ReadLine();

                Console.WriteLine("Insira o ano do Livro:");
                var anoDoLivro = Console.ReadLine();

                listaDeLivro[i, 0] = (Id++).ToString();

                listaDeLivro[i, 1] = nomeDoLivro;

                listaDeLivro[i, 2] = anoDoLivro;

                Console.WriteLine("Deseja inserir um novo registro? sim(1) ou não(0)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;

                AumentaLista(ref listaDeLivro);
            }
                    Console.WriteLine("Registro Adicionado segue lista:");

                    for (int i = 0; i < listaDeLivro.GetLength(0); i++)
                     

                Console.WriteLine(string.Format("Registro ID {0} - Nome do Livro:{1}   -  Ano do livro:{2}", listaDeLivro[i, 0], listaDeLivro[i, 1], listaDeLivro[i, 2]));
        }
                public static void AumentaLista(ref string[,] listaDeLivro)
                {
                    var limiteDaLista = true;

                    for (int i = 0; i < listaDeLivro.GetLength(0); i++)
                    {
                        if (listaDeLivro[i, 0] == null)
                            limiteDaLista = false;
                    }
                    if (limiteDaLista)
                    {
                       
                        var listaCopia = listaDeLivro;
                       
                        listaDeLivro = new string[listaDeLivro.GetLength(0) + 5, 3];
                     
                        for (int i = 0; i < listaCopia.GetLength(0); i++)
                        {
                            
                            listaDeLivro[i, 0] = listaCopia[i, 0];
                         
                            listaDeLivro[i, 1] = listaCopia[i, 1];

                            listaDeLivro[i, 2] = listaCopia[i, 2];

                        }
                       
                        Console.WriteLine("O tamanho da lista foi atualizada.");
                    }
                }

    }
}
    

