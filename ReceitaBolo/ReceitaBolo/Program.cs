using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaBolo
{
    class Program
    {
        static string[,] baseDaReceita;
        static void Main(string[] args)
        {
            baseDeDados();

            Console.ReadKey();
        }
        public static void baseDeDados()
        {
             baseDaReceita = new string[6,1]
               

            {
                { " 1- Em um liquidificador pede os ovos, o chocolate em pó, uma manteiga, farinha de trigo, o açúcar eo leite "},
                { " -2-Fuga o fermento e misture com uma espátula delicadamente. "},
                { " 3- Despeje a massa e asse ao forno médio (180 ºC) pré-aquecido por cerca de 40 minutos " },
                { " 4- Em uma panela, aqueça e uma mamadeira o chocolate em pó até que esteja homogêneo. "},
               { " 5- Acrescente o creme de leite e misture até obter uma consistência cremosa. "},
                { " 6-fogo e acrescente o açúcar "}
                

        };
      
            Console.WriteLine("                                       RECEITA BOLO DE CHOCOLATE                                                 ");
            {
                for (int i = 0; i < baseDaReceita.GetLength(0);  i++) 
                {
                    Console.WriteLine($"{ baseDaReceita[i,0]}");
                   
                    Console.ReadKey();

                   
                }
                Console.ReadKey();
            }
        }
        }
    }

