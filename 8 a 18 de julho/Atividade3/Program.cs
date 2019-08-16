using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static string[,] baseDeInformacoes;
        static void Main(string[] args)
        
            {
                baseDeDados();



                Console.ReadKey();


            }
            public static void baseDeDados()
            {
                baseDeInformacoes = new string[20, 3]
            {
                { "Aline   ", "18",   "Feminino"},
                { "Ana     ",   "27", "Feminino"},
                { "Joana   ", "17",   "Feminino"},
                { "Rodolfo ","45", "Masculino"},
                { "Alice   ",  "23", "Feminino"},
                { "Amanda  ", "76", "Feminino"},
                { "Paulo   ", "113",  "Masculino"},
                { "Sabrina ","14",  "Feminino"},
                { "Jonatan ","02", "Masculino"},
                { "Samuel  ", "67", "Masculino"},
                { "Samira  ", "24", "Feminino "},
                { "Joana   ",  "54", "Feminino "},
                { "João    ",   "48", "Masculino"},
                { "Jamil   ",  "35", "Masculino"},
                { "Lucas   ",  "98", "Masculino"},
                { "Joelson ","14", "Masculino"},
                { "Jair    ",   "03", "Masculino"},
                { "Jelson  ", "08", "Masculino"},
                { "Joelson ","11", "Masculino"},
                { "Samanta ","34", "Feminino "}



            };
            Console.WriteLine("             Lista de Informações              ");
            for (int i = 0; i < baseDeInformacoes.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeInformacoes[i, 0]} Idade:{baseDeInformacoes[i, 1]} Sexo: {baseDeInformacoes[i, 2]}");
            }


            Console.ReadKey();
        }
    }
}
