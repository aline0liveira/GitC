using BibliotecaCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 calculo = new Class1();


            Console.WriteLine($"A soma resulta : {calculo.Adicao(5, 5)}");

            Console.WriteLine($"A subtracao resulta : {calculo.Subtracao(5, 5)}");

            Console.WriteLine($"A multiplicacao resulta : {calculo.Multiplicacao(5, 5)}");

            Console.WriteLine($"A divisao resulta : {calculo.Divisao(5, 5)}");

            Console.WriteLine($"A area do retangulo resulta : {calculo.AreaRetangulo(5, 5)}");

            Console.WriteLine($"A area triangulo equilatero resulta : {calculo.AreaTrianguloEsquilatero(5, 5)}");

            Console.WriteLine($"O raio do circulo resulta : {calculo.RaioDoCirculo(5)}");


            Console.ReadKey();
        }
    }
}
