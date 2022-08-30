using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Salario_Funcionario
{
    internal class Calc
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double Aumento;

        public double SalarioLiquido()
        {

            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return $"" +
                $"Funcionário: {Nome} \r\n" +
                $"Salário BRUTO: R${SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)} \r\n \r\n" +
                $"Imposto sobre o Salário: R${Imposto.ToString("F2", CultureInfo.InvariantCulture)} \r\n" +
                $"Salário LIQUIDO: R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)} \r\n";
        }

    }
}
