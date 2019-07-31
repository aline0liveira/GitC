using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAluno.Classes
{
    public class Aluno
    {
        public string Nome { get; set; }

        public string Idade { get; set; }

        public DateTime DatInc { get; set; } = DateTime.Now;
    }
}
