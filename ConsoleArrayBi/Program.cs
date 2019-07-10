using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrayBi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivros = new string[2, 2]
                {{ "Alice no país das maravilhas", "sim" },{"Pinóquio", "não"} };
            for (int i = 0; i < listaDeLivros.GetLength(0); i++)

            {
                var Nomedolivro = listaDeLivros[i, 0];
                var disponivel = listaDeLivros[i, 1];
                Console.WriteLine($"Nome do livro:{Nomedolivro} disponivel: {disponivel}.");
            }
            Console.ReadKey();
            }
                }
                    
                
    }

