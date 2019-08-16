using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCsharp.Classes
{
   public class Conta
   {
        double saldo = 0;

        //Proprieda que contém o valor do saldo
        public double Saldo { get { return saldo; } }
        public Conta()
        {
            // Bonus de mil reais para iniciar 
            saldo = 1000;
        }


        /// <summary>
        /// Metodo para sacar dinheiro de acordo com o saldo disponivel 
        /// </summary>
        /// <param name="valor"> valor a ser sacado</param>
        /// <returns>Retorna se o saque foi feio ou não</returns>
        public bool Sacar(double valor)
        {

            if(valor <= saldo)
            {
                //Desconta valor daconta
                saldo -= valor;

                return true;
            }

            // Retorna false em caso de não conter saldo disponível
            return false;
           
        }


        /// <summary>
        /// Método que mostra o saldo em conta disponível
        /// </summary>
        /// <returns></returns>
        public double MostrarSlado()
        {
            return saldo;
        }
   }

    
}
