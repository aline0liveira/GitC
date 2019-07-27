using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostraCoisasAleatorias
{
    public class Mostra
    {
        public void MostraNome()
        {
            Console.WriteLine("Aline");
        }

        public void MostraDia( bool sextou)
        {
            
            if (sextou)

            Console.WriteLine("Hoje é sexta!!");

            else

             Console.WriteLine("Opps ainda é quinta");

        }
            public void MostraIdade(bool minhaIdade)
            {
                if(minhaIdade)
                Console.WriteLine(" 18 ANOS");

                else

                Console.WriteLine("IDADE ERRADA");
            }
        
    }
}
