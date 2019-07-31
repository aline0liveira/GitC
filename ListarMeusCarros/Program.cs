using ListarMeusCarros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarMeusCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carros> minhaLista = new List<Carros>();




            while(true)
            {
               
                switch (MenuInicial())
                {
                    case "1": {
                            foreach (Carros item in minhaLista)
                                Console.WriteLine($"Modelo:{item.Modelo} Ano:{item.Ano} Placa:{item.Placa} Cv{item.Cv}");

                            Console.ReadKey();
                        } break;
                    case "2": {
                            minhaLista.Add(new Carros()
                            {
                                Modelo = RetornaValores("modelo"),
                                Ano = int.Parse(RetornaValores("Ano")),
                                Placa = int.Parse(RetornaValores("Placa")),
                                Cv = RetornaValores("Cv")

                            });
                        } break;
                   

                }

            }








        }

        public static string MenuInicial()
        {
            Console.WriteLine("1- Listar Carros");
            Console.WriteLine("2-Adicionar Carros");
           return Console.ReadLine();
        }

        /*   public static void AdicionaCarro(ref var listacarros)
           {

               listacarros.Add(new Carros()
                   {
                       Modelo = RetornaValores("modelo"),
                       Ano = int.Parse(RetornaValores("Ano")),
                       Placa = int.Parse(RetornaValores("Placa")),
                       Cv = RetornaValores("Cv")

                   });


           }

           public static void Listar()
           {
               foreach (Carros item in minhaLista)
                   Console.WriteLine($"Modelo:{item.Modelo} Ano:{item.Ano} Placa:{item.Placa} Cv{item.Cv}");

               Console.ReadKey();
           }
           */

        public static string RetornaValores(string modelo)
        {
            Console.WriteLine($"Informe o valor para o campo:{modelo}");
            return Console.ReadLine();
        }


    }
}
