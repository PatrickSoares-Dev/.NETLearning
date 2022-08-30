using System;
using System.Globalization;

namespace Calculo_do_Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Fazer um programa para ler os valores da largura e altura de um retângulo. Em
            //seguida, mostrar na tela o valor de sua área, perímetro e diagonal.

            Calculos Calc = new Calculos();
            
            Calc = new Calculos();

            Console.WriteLine("Entre com a largura de altura do retângulo: \r\n");

            Console.Write("Largura: ");
            Calc.Largura = double.Parse(Console.ReadLine());

            Console.Write("Altura: \r\n");
            Calc.Altura = double.Parse(Console.ReadLine());

            Console.Write($"Area do Retângulo: {Calc.CalcArea()} \r\n");
            Console.Write($"Perimetro do Retângulo: {Calc.Perimetro()}\r\n"); 

            

        }
    }
}
