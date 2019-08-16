using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostraCoisasAleatorias;

namespace UsandoMostra
{
    class Program
    {
        static void Main(string[] args)
        {
            Mostra mostrando = new Mostra();

            {
                mostrando.MostraNome();

                mostrando.MostraDia(true);

                mostrando.MostraIdade(true);

                Console.ReadKey();
            }
        }
    }
}
