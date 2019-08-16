using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRotina
{
    class Rotina
    {
        public string Nome { get; set; } = "Gato";

        public int Idade { get; set;} = 7;

        

        

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
            return "Dormindo";
        }


    }

}
