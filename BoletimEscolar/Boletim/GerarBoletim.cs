using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Boletim
{
   public class GerarBoletim
    {



        public int RecebeNota(int nota1, int nota2 , int nota3)
        {
           
           return (nota1 + nota2 + nota3) /3 ;
           
        }

        public int RecebeFrequencia( int totalDias, int faltas)
        {
             return ((totalDias - faltas) * 100) / totalDias;
        }

        public  void MostraBoletim(int media , int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
            {
                Console.WriteLine($" Aprovado com media :{media} e frequencia de: {frequencia}%");
            }
            else
            {
                Console.WriteLine($" Reprovado com media:{media} e frequencia de:{frequencia}%");
            }
        }

        public string RetornaSituacao(int media, int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
            
                return "Aprovado";

            else

                return "Reprovado";
            

        }
    }
}
