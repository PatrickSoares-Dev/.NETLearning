using System;
using System.Globalization;

namespace Produto_em_um_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Defina um número de produtos: ");

            int n = int.Parse(Console.ReadLine());

            Product []  vectProdutos = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Insira o produto: ");
                string nome = Console.ReadLine();
                Console.Write("Insira o preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vectProdutos[i] = new Product { Nome = nome, Preco = preco};

            }
        
        }
    }
}
