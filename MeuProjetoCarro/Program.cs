using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjetoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carros> minhaLista = new List<Carros>();




            while (true)
            {

                switch (MenuInicial())
                {
                    case "1":
                        {
                            foreach (Carros item in minhaLista)
                                Console.WriteLine($"Modelo: {item.Modelo} Ano: {item.Ano} Placa: {item.Placa} Cv{item.Cv}");

                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        {
                            minhaLista.Add(new Carros()
                            {
                                Modelo = RetornaValores("modelo"),
                                Ano = int.Parse(RetornaValores("Ano")),
                                Placa = (RetornaValores("Placa")),
                                Cv = int.Parse(RetornaValores("Cv"))

                            });
                        }
                        break;


                }

            }








        }

        public static string MenuInicial()
        {
            Console.WriteLine("1- Listar Carros");
            Console.WriteLine("2-Adicionar Carros");
            return Console.ReadLine();
        }

        public static string RetornaValores(string modelo)
        {
            Console.WriteLine($"Informe o valor para o campo:{modelo}");
            return Console.ReadLine();
        }

    }
}

