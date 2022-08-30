using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estoque
{
    internal class Estoque
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public string Info;

        public double ValorEmEstoque()
        {

            return Preco * Quantidade;

        }

        public void AdicionarEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do produto:\r\n \r\n" +
                $"Produto: {Nome} \r\n" +
                $"Total de unidades: {Quantidade} Unidades \r\n" +
                $"Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture )} \r\n \r\n" +
                $"Valor total: R$ {ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture )} \r\n";
        }
    }
}
