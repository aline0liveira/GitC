using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Mostrar
{
    class MostarLista
    {
        public void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)
                {// Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida Id:{arrayBi[i, 0]} Nome{arrayBi[i, 1]}");
                    // Aqui saimos da nossa lista mas retornamos vazio return; pois estamos em um metodo vazio void que nao espera retornar algo
                    return;
                }
            }
            //Caso ele passe por esta linha identificamos que ele ao encontrou resultados compatíveis
            Console.WriteLine("Infelizmente a busca pelo id nao resultou em nenhuma informacao.");
        }

    }
}

