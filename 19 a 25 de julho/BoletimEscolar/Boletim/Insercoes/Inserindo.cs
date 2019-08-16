using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Boletim.Insercoes
{
    public class Inserindo
    {
        string[,] arrayAluno = new string[5, 5];
        GerarBoletim boletim = new GerarBoletim();    

        public void InsereAluno()
        {

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Informe o nome do Aluno");
                var nome = Console.ReadLine();
                arrayAluno[i, 0] = i.ToString();
                arrayAluno[i, 1] = nome;
                var media = digitaNotas();
                arrayAluno[i, 2] = media.ToString();
                
                // Frequencia
                Console.WriteLine("Informe o numero de aulas");
                int.TryParse(Console.ReadLine(), out int totalDias);

                Console.WriteLine("Informe o numero de faltas");
                int.TryParse(Console.ReadLine(), out int faltas);
                var frequencia = boletim.RecebeFrequencia(totalDias, faltas);
                arrayAluno[i, 3] = frequencia.ToString();
                arrayAluno[i, 4] = boletim.RetornaSituacao(media, frequencia);


            }


        }
        public void ListarAlunos()
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                Console.WriteLine($"Id: {arrayAluno[i, 0]} Nome Aluno: {arrayAluno[i, 1]} Media: {arrayAluno[i, 2]} Frequencia:{arrayAluno[i, 3] }% Situacao:{arrayAluno[i, 4]}");
            }
        }

        public void ExcluirRegistro(int pId)
        {

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == pId.ToString())
                {
                    arrayAluno[i, 1] = "";
                    arrayAluno[i, 2] = "";
                    arrayAluno[i, 3] = "";
                    arrayAluno[i, 4] = "";
                    break;
                }
            }


        }

        public void AlterarRegistro(int pId)
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == pId.ToString())
                {
                    var media = digitaNotas();
                    arrayAluno[i, 2] = media.ToString();
                    var frequencia = Convert.ToInt32(arrayAluno[i, 3]);
                    arrayAluno[i, 4] = boletim.RetornaSituacao(media, frequencia);
                }
            }
        }

        public int digitaNotas()
        {
            Console.WriteLine("Informe o nota do Aluno");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Informe o nota do Aluno");
            int.TryParse(Console.ReadLine(), out int nota2);


            Console.WriteLine("Informe o nota do Aluno");
            int.TryParse(Console.ReadLine(), out int nota3);

            // calculando media
            return boletim.RecebeNota(nota1, nota2, nota3);
        }


    }
}
