using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
                    {
            var listas = new GetFiles();

          var listaDeArquvivosDosMeusDocumentos = listas.RetornaArquivosDoMeuDocumentos();

            for (int i = 0; i < listaDeArquvivosDosMeusDocumentos.Length; i++)
            {
                Console.WriteLine(listaDeArquvivosDosMeusDocumentos [i]);
            }
            Console.ReadKey();
            Console.Clear();




            var listaDeArquivos = listas.RetornaArquivosImagesFiles();
            for (int i = 0; i < listaDeArquivos.Length; i++)
            {
                Console.WriteLine(listaDeArquivos[i]);
            }

            Console.ReadKey();
            Console.Clear();


            var listaDeArquivosGit = listas.RetornaArquivosGit();
            for (int i = 0; i <listaDeArquivosGit.Length; i++)
            {
                Console.WriteLine(listaDeArquivosGit [i]);
            }
            Console.ReadKey();
            Console.Clear();


        }

    }
}
