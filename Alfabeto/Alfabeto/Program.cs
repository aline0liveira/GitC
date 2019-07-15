using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfabeto
{
    class Program
    {
        static string[,] baseDeLetras;
        static void Main(string[] args)
        {
            baseDeDados();




            Console.ReadKey();

       }

         public static void baseDeDados()
        {
            baseDeLetras = new string [7,1]
            {
                { "A" },
                { "B" },
                { "C" },
                { "D" },
                { "E" },
                { "F" },
                { "G" }






            };
            Console.WriteLine(" Alfabeto\n");
            for (int i = 0; i <baseDeLetras.GetLength(0); i++)
            {
                Console.WriteLine($"As letras o sao  :{baseDeLetras  [i,0]}");
                Console.ReadKey();
            }
            Console.ReadKey();
            }
        }
         
    }

