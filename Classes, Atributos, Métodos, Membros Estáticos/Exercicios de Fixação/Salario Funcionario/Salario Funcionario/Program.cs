using System;
using System.Globalization;

namespace Salario_Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Fazer um programa para ler os dados de um funcionário(nome,
            //salário bruto e imposto). Em seguida, mostrar os dados do
            //funcionário(nome e salário líquido).Em seguida, aumentar o salário
            //do funcionário com base em uma porcentagem dada(somente o
            //salário bruto é afetado pela porcentagem) e mostrar novamente os
            //dados do funcionário.Use a classe projetada abaixo.

            Calc CalculoSalario = new Calc();

            Calc infoSalario = new Calc();
            
            Console.WriteLine("Informações do Funcionário: \r\n");           

            Console.Write("Nome: ");
            infoSalario.Nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            infoSalario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Impostos: ");
            infoSalario.Imposto = double.Parse(Console.ReadLine());
            Console.Write("\r\n");
            

            Console.WriteLine(infoSalario.ToString());

            Console.Write($"Deseja adicionar um aumento para: {infoSalario.Nome} y/n ");
            string aumento = Console.ReadLine();

            if (aumento == "y" || aumento == "Y")
            {
                Console.WriteLine("");
                Console.Write("Deseja aumentar o salário em qual porcentagem? ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                infoSalario.AumentarSalario(porcent);

                Console.WriteLine(infoSalario.ToString());
            }
            else
            {
                Console.WriteLine(infoSalario.ToString());
            }
            


        }

    }
}
