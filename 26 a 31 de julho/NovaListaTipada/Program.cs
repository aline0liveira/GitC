using NovaListaTipada.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaListaTipada
{
    class Program
    {
        static void Main(string[] args)

        {

            List<Lanchinhos> minhaLista = new List<Lanchinhos>();


            for (int i = 0; i < 2; i++)
            {
                minhaLista.Add(new Lanchinhos()
                {
                    Nome =RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))

                });

            }

            foreach (Lanchinhos item in minhaLista)
                Console.WriteLine($"Nome:{item.Nome} Quantidade: {item.Quantidade} Valor: {item.Valor}");

            Console.ReadKey();  
           

        }

        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();
        }
    }
}
