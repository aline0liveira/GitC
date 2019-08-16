using BoletimEscolar.Boletim;
using BoletimEscolar.Boletim.Insercoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoBoletim
{
    class Program
    {
        static void Main(string[] args)
        {
            Inserindo cadastros = new Inserindo();

            MenuInicial();

            cadastros.InsereAluno();
            Console.Clear();
            cadastros.ListarAlunos();

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Informe registro que deseja excluir");
            int.TryParse(Console.ReadLine(), out int reg);

            cadastros.ExcluirRegistro(reg);
            cadastros.ListarAlunos();

            Console.WriteLine("Informe registro que deseja alterar");
            int.TryParse(Console.ReadLine(), out int registros);
            cadastros.AlterarRegistro(registros);
            cadastros.ListarAlunos();


            //Console.ReadKey();


            //  GerarBoletim notas = new GerarBoletim();
            //
            //
            //  Console.WriteLine($" Digite a primeira nota");
            //    var nota1 = Convert.ToInt32(Console.ReadLine());
            //
            //  Console.WriteLine($" Digite a segunda nota");
            //  var nota2 = Convert.ToInt32(Console.ReadLine());
            //
            //  Console.WriteLine($" Digite a terceira nota");
            //  var nota3 = Convert.ToInt32(Console.ReadLine());
            //
            //  var media = notas.RecebeNota(nota1, nota2, nota3);
            //  var presenca = notas.RecebeFrequencia(100, 10);
            //
            //  notas.MostraBoletim(media, presenca);
            //Console.ReadKey();

            var escolha = MenuInicial();

            while (true)

            {
                switch (escolha)
                {
                    case "1": { cadastros.InsereAluno(); } break;
                    case "2": { cadastros.ListarAlunos(); } break;
                    case "3": {
                            Console.WriteLine("Informe o registto a exclir");
                            int.TryParse(Console.ReadLine(), out int registrinhos);
                            cadastros.ExcluirRegistro(registrinhos);
                        } break;
                    case "4": {
                            Console.WriteLine("Informe o registto a exclir");
                            int.TryParse(Console.ReadLine(), out int regist);
                            cadastros.AlterarRegistro(reg);
                           } break;
                    case "5": { return; }


                }
                escolha = MenuInicial();
            }

        }
            public static string MenuInicial()
            {
                Console.Clear();
                Console.WriteLine("               Menu de Opções  \n          ");
                Console.WriteLine("1 - Inseir um novo registro.");
                Console.WriteLine("2 - Listar informações.");
                Console.WriteLine("3 - Excluir Registro.");
                Console.WriteLine("4 - Alterar Registro.");
                Console.WriteLine("5 - Sair ");
                Console.WriteLine("Digite o número da opção que corresponde ao que dejesa:");
                return Console.ReadLine();
            }

        }
    
}
