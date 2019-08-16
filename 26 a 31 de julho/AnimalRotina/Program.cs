using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRotina
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal status = new Animal();



            Console.WriteLine($"Nome: {status.Nome} \r\n");

            Console.WriteLine($"{status.Acordar()}\r\n");

            Console.WriteLine($"{status.Comer()}\r\n");

            Console.WriteLine($"{status.Dormir()}\r\n");

            Console.ReadKey();

            Rotina status1 = new Rotina();

            Console.WriteLine($"Nome:  {status1.Nome} \r\n");

            Console.WriteLine($"Idade: {status1.Idade} \r\n");

            Console.WriteLine($"{status1.Acordar()}\r\n");

            Console.WriteLine($"{status1.Comer()}\r\n");

            Console.WriteLine($"{status1.Dormir()}\r\n");

            Console.ReadKey();
        }
    }
}
