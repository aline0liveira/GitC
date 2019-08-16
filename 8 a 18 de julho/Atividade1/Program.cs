using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Informe seu nome:");
                var nome = Console.ReadLine();
                Console.WriteLine("Agora informe sua idade:");


                var idade = int.Parse(Console.ReadLine());


                if (idade > 18)
                {
                    Console.WriteLine("Você pode beber!!!");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode beber");
                }
                Console.ReadKey();

            }
        }
    }
}
