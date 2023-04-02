using System;

namespace idade_para_carta_de_condução
{
    class Program
    {
        static void Main(string[] args)
        {
            //exibe no console a mensagem "-----Verificador de idade para obtenção de carteira de motorista.-----".
            Console.WriteLine("-----Verificador de idade para obtenção de carteira de motorista.-----");

            //exibe no console a mensagem "Introduza a idade: ".
            Console.WriteLine("Introduza a idade: ");
            //Lê uma entrada do usuário e armazena o valor digitado na variável idade, convertendo o valor para o tipo int.
            int idade = int.Parse(Console.ReadLine()!);

            if (idade >= 18)//Verifica se a idade é maior ou igual a 18.
            {
                Console.WriteLine("Pode tirar a carta!"); //Exibe no console a mensagem "Pode tirar a carta".
            }
            else  //Caso a idade seja menor que 18.
            {
                // Imprime no console a mensagem "Não pode tirar a carta. Anos que faltam = (18 - idade)", onde (18 - idade) 
                //é o resultado da subtração entre 18 e a idade digitada.
                Console.WriteLine("Não pode tirar a carta! Anos que faltam =" + (18 - idade));
            }
        }
    }
}

