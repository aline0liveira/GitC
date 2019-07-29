using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantina.Classes
{

    public class Cantina
    {
        public string Aluno { get; set; } = "Aline";

        double saldo = 0;

        

        public double Saldo { get { return saldo; } }
        public Cantina()
        {
            saldo = 20;

        }

        public bool Comprar(double valorLanche)
        {
            if(valorLanche <= saldo)
            {
                saldo -= valorLanche;

                return true;
            }

            return false;
        }

        public double saldoAtual()
        {
            return saldo;
        }
       
    }

}
