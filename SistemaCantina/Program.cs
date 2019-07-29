using SistemaCantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantina
{
    class Program
    {
        static void Main(string[] args)
        {

            Cantina aluno = new Cantina();

            Console.WriteLine($"Aluno: {aluno.Aluno}");

            while (aluno.Saldo > 0.00)
            {

                Console.WriteLine("Menu - Lanches");
                Console.WriteLine("1 - Pizaa 2,00.");
                Console.WriteLine("2 - Hamburguer 5,00.");
                Console.WriteLine("3 - HotDog  3,50.");
                Console.WriteLine("Que lanche você deseja comprar?");



                var escolha = Console.ReadLine();
                var preco = 0.00;

                switch (escolha)
                {
                    case "1": { preco = 2.00; } break;
                    case "2": { preco = 5.00; } break;
                    case "3": { preco = 3.50; } break;

                }



                if (preco > 0 && aluno.Comprar(preco))

                    Console.WriteLine("Compra da merenda feita com sucesso!");

                else
                    Console.WriteLine("Vai ficar sem a merenda");


                Console.WriteLine($"Atualmente seu saldo disponível pra merenda é: {aluno.Saldo.ToString("N2")}");

                Console.ReadKey();
            }
        }
    }
}