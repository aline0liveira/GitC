using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBiblioteca
{
    public class Operacoes
    {
        public double Adicao(double x, double y)
        {
            return x + y;

        }
        public double Subtracao(double x, double y)
        {
            return x - y;

        }

        public double Multiplicacao(double x, double y)
        {
            return x * y;

        }
        public double Divisao(double x, double y)
        {
            return x / y;

        }

        public double AreaRetangulo(double Base, double Altura )
        {
            return Base * Altura;
        }

        public double TrianguloEquilatero( double Base, double Altura )
        {
           return  (Base * Altura /2) ;
        }

        public double RaioCirculo(double Circulo)
        {
            return Math.Sqrt(Circulo / Math.PI);
        }

    }
}
