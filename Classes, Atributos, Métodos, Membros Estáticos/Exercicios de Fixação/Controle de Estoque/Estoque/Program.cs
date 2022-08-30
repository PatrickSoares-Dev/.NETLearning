using System;
using System.Globalization;

namespace Estoque
{
    internal class Program
    {
        static Estoque produto;
        static void Main(string[] args)
        {
            Estoque InfoEstoques = new Estoque();

            produto = new Estoque();

            Estoque info;
            info = new Estoque();

            Console.WriteLine("Insira os dados do produto:\r\n");

            Console.Write("Produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = produto.ValorEmEstoque();

            Console.WriteLine("");
            Console.Write(info.Info = produto.ToString());

            Console.WriteLine("");
            Console.Write($"Deseja adicionar ou remover produtos? y/n: ");
            string again = Console.ReadLine();


            if ((again == "n" || again == "N"))
            {
                Console.WriteLine("");
                Console.Write(produto.ToString());
            }

            while ((again == "y" || again == "Y"))
            {
                Console.WriteLine("");
                Console.WriteLine("Selecione uma opção \r\n" +
                    "(1) Adicionar \r\n" +
                    "(2) Remover \r\n" +
                    "(3) Sair \r\n");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Inserir();
                } else if(option == "2")
                {
                    Remover();
                }
                else
                {
                    break;
                }
                
            }      

        }

        public static void Inserir()
        {
            Console.WriteLine("");
            Console.Write("Quantidade a ser adicionada: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarEstoque(qtd);

            Console.WriteLine("");
            Console.Write(produto.ToString());
            Console.WriteLine("");


            Console.Write($"Deseja adicionar ou remover produtos?? y/n ");
            string again = Console.ReadLine();

            if ((again == "n" || again == "N"))
            {
                Console.WriteLine("");
                Console.Write(produto.ToString());
            }

            while ((again == "y" || again == "Y"))
            {
                Console.WriteLine("");
                Console.WriteLine("Selecione uma opção \r\n" +
                    "(1) Adicionar \r\n" +
                    "(2) Remover \r\n" +
                    "(3) Sair \r\n");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Inserir();
                }
                else if (option == "2")
                {
                    Remover();
                }
                else
                {
                    break;
                }

            }

        }
        public static void Remover()
        {
            Console.WriteLine("");
            Console.Write("Quantidade a ser Removida: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.RemoverEstoque(qtd);

            Console.WriteLine("");
            Console.Write(produto.ToString());


            Console.Write($"Deseja adicionar ou remover produtos? y/n ");
            string again = Console.ReadLine();

            if ((again == "n" || again == "N"))
            {
                Console.WriteLine("");
                Console.Write(produto.ToString());
            }

            while ((again == "y" || again == "Y"))
            {
                Console.WriteLine("");
                Console.WriteLine("Selecione uma opção \r\n" +
                    "(1) Adicionar \r\n" +
                    "(2) Remover \r\n" +
                    "(3) Sair \r\n");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Inserir();
                }
                else if (option == "2")
                {
                    Remover();
                }
                else
                {
                    break;
                }

            }
        }
    }
}
