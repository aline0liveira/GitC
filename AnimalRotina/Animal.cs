using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRotina
{
   public class Animal 
   {

        public string Nome { get; set; } = "Cachorro";

       


        public string Acordar()
        {
            return "Acordando";
        }


        public string Comer()
        {
            return "Comendo";
        }

        public string Dormir()
        {
            return "Indo dormir Novamente";
        }
   }
}
