using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = { "André", "Bruna", "Carla", "Daniel" };

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
