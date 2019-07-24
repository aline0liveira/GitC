using BibliotecaCalculadora.ProjetoCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsandoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
          var bbCalc = new Calculadora();

            Console.WriteLine($"A soma resulta : {bbCalc.Adicao(5, 5)}");

            Console.WriteLine($"A subtracao resulta : {bbCalc.Subtracao(5, 5)}");

            Console.WriteLine($"A multiplicacao resulta : {bbCalc.Multiplicacao(5, 5)}");

            Console.WriteLine($"A divisao resulta : {bbCalc.Divisao(5, 5)}");

            Console.ReadKey();
        }
    }
}
