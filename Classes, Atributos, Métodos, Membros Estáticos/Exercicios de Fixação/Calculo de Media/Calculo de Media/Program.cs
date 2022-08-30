using System;
using System.Globalization;

namespace Calculo_de_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            //(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).Ao final, mostrar qual a nota final do aluno no
            //ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            //para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver
            //este problema.


            Media CalcMedia = new Media();

            Console.WriteLine("----- Historico escolar ----- \r\n");

            Console.Write("Nome do aluno: ");
            CalcMedia.Nome = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Insira as notas do aluno: \r\n");

            Console.Write("Nota do Primeiro Trimestre: ");
            CalcMedia.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota do Segundo Trimestre: ");
            CalcMedia.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota do Terceiro Trimestre: ");
            CalcMedia.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double nota = CalcMedia.MediaAnual();
            CalcMedia.notaRestante(nota);


            Console.WriteLine("");
            Console.WriteLine($"Nota final: {CalcMedia.MediaAnual().ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}
