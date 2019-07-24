using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Carrega
{
    class CarregarLista
    {

        string[,] listaDeNome;

        /// <summary>
        /// Retorna a lista de  nome apenas como leitura
        /// </summary>
        public string[,] ListaNome { get { return listaDeNome; } }

        /// <summary>
        /// Nosso metodo construtor que sempre recebe o nome da classe
        /// </summary>
        /// <param name="arrayBi">Array que ja deve estar assinada</param>
        public CarregarLista()
        {
            // Assinamos nossa lista no metodo cnstrutor com isso ja deixamos a lista pronta para uso nos demais metodods sem precisar de um 
            // parametro para isso
            listaDeNome = new string [10,2];
        }

        /// <summary>
        /// Metodo que carrega as informacoes dentro da nossa lista criada no metodo MAIN
        /// </summary>
        /// <param name="arraybi"> Nossa Lista a ser caarregada</param>
        public void CarregaInformacoesEListaElasEmTela()
        {
            //Usando um laco simples para colocar valores mas no mesmo agora utilizando o getlenght com parametro 0 para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                // carregando o que podemos chamar de ID identificador do nosso registro unico
                listaDeNome[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informacao extra para deixar legal
                listaDeNome[i, 1] = $"Aline_{i}";
            }

            // lembrando que getlength é um metodo e usamos "(parametro)" com parametro ou as vezes sem para realizar a chamada do mesmo
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam aprsentados
                Console.WriteLine($"ID:{listaDeNome[i, 0]} Nome{listaDeNome[i, 1]}");


            }
        }

    }
}
