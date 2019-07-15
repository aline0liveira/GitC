using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensao
            string[,] listaDeNome = new string[5, 2];

            //Usando um laco simples para colocar valores mas no mesmo agora utilizando o getlenght com parametro 0 para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i <listaDeNome.GetLength(0); i++)
            {
                // carregando o que podemos chamar de ID identificador do nosso registro unico
                listaDeNome[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informacao extra para deixar legal
                listaDeNome[i, 1] = $"Aline_{i}";
            }

            // lembrando que getlength é um metodo e usamos "(parametro)" com parametro ou as vezes sem para realizar a chamada do mesmo
            for (int i = 0; i <listaDeNome.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam aprsentados
                Console.WriteLine($"ID:{listaDeNome[i,0]} Nome{listaDeNome[i,1]}");

               
            }
            Console.ReadKey();
        }
    }
}
