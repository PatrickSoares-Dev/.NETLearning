using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_Depósito
{
    internal class DepositoClass
    {

        public int Conta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }


        public override string ToString()
        {
            return $"Dados da conta: \r\n" +
                $"Conta: {Conta} \r\n" +
                $"Titular: {Nome} \r\n" +
                $"Saldo: R$ {Saldo.ToString(CultureInfo.InvariantCulture)}";
        }

        public double Soma(double x, double y)
        {
            Saldo = y + x;
            return Saldo;
        }

        public double Menos(double Saque)
        {
            Saldo = Saldo - Saque;
            return Saldo;
        }

    }
}
