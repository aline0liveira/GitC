using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[,] livros = new string[2, 2] {
            { " Alice no País das maravilhas", // Nome do Livro
                "sim" }, // Disponível
        { "Pinóquio", // Nome do Livro
           "não" //Disponível     
                } };

        Console.ReadKey();
            }
}
}




#region Exercicio pronto 
/* string[] stringListInfo = new string[2];
 for (int i = 0; i < stringListInfo.Length; i++)
 {

     stringListInfo[i] =
         $"Nome: {IsValid("", "Nome")} " +
         $"Idade: {IsNumberFormat(IsValid("", "idade"), "00")} " +
         $"Peso: {IsNumberFormat(IsValid("", "Peso"), "n2")} kg";

 }

 for (int i = 0; i < stringListInfo.Length; i++)
     Console.WriteLine(stringListInfo[i]);
 Console.ReadKey();
}


public static string IsValid(string value, string fieldName)
{
 var retorno = value;

 while (string.IsNullOrEmpty(retorno) || string.IsNullOrWhiteSpace(retorno))
 {
     Console.Clear();
     Console.WriteLine($"Informe um valor para o campo {fieldName}:");
     retorno = Console.ReadLine();
 }
 return retorno;
}
private  static string IsNumberFormat(object values, string format)
{
 int.TryParse(values.ToString(), out int retorno);

 return retorno.ToString(format);
}
}
} */
#endregion
#region Comentarios
//var count = 0;
//while(count < 10)
//{
//    Console.WriteLine("Teste");
//    count++;
//
//}
//int[] teste = new int[5] { 0, 1, 2, 3, 4 };
//for (int i=0; i< teste.Length; i++)
//{
//    teste[i] = i;
//}
//for (int i = 0; i < teste.Length; i++)
//{
//    Console.WriteLine(teste[i]);
//}
#endregion
#region Exercício completo

/*  string[] arrayStringContent = new string[3];


for (int i = 0; i <arrayStringContent.Length; i++)
{
Console.WriteLine("Informe seu nome e idade:");
arrayStringContent[i] = Console.ReadLine();
Console.Clear();
}
for(int i = 0; i< arrayStringContent.Length; i++)
{
Console.WriteLine($"Nome e Idade: {arrayStringContent[i]}");
}*/
#endregion
#region Exercicio modificado
/*
string[] listaDeNomes = new string[3];


for (int i = 0; i < listaDeNomes.Length; i++)
{
 Console.WriteLine("Informe seu nome, idade e cor favorita:");
 listaDeNomes[i] += Console.ReadLine();
 Console.Clear();
}
for (int i = 0; i < listaDeNomes.Length; i++)
{
 Console.WriteLine($"Cadastrado: {listaDeNomes[i]}");
}
{

 Console.WriteLine(" \n Cadastro Concluído com Sucesso!!!");
}
*/
#endregion