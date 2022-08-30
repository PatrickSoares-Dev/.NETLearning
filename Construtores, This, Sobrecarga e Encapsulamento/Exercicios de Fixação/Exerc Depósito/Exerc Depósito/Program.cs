using System;
using System.Globalization;

namespace Exerc_Depósito
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DepositoClass account = new DepositoClass();           

            Console.Write
               ("Entre com o número da conta: ");
            account.Conta = int.Parse(Console.ReadLine());

            Console.Write
                ("Entre com o titular da conta: ");
            account.Nome = Console.ReadLine();

            Console.Write
                ("Haverá um depósito inicial (s/n)? ");
            string SN = Console.ReadLine();


            if (SN == "s" || SN == "S")
            {
                Console.WriteLine("");
                Console.WriteLine
                    ("Entre o valor de depósito inicial: ");
                account.Saldo = double.Parse(Console.ReadLine());                

            }

            Console.WriteLine("");
            Console.WriteLine(account.ToString());

            Console.WriteLine("");

            Console.Write
                ("Entre com um valor para depósito: ");
            double Deposito =  double.Parse(Console.ReadLine());
            account.Soma(Deposito, account.Saldo);

            Console.WriteLine("");
            Console.WriteLine(account.ToString());


            Console.WriteLine("");
            Console.Write
                ("Entre com um valor para saque: ");
            double Saque = double.Parse(Console.ReadLine());
            account.Menos(Saque);


            Console.WriteLine(account.ToString());
        }
    }
}
