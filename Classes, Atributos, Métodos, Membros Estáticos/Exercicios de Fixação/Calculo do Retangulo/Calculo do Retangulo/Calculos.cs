using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_do_Retangulo
{
    internal class Calculos
    {

        public double Largura;
        public double Altura;


        public double CalcArea()
        {

             return Largura * Altura;

        }
        public double Perimetro()
        {
            return Altura + Altura + Largura + Largura;
        }
    }

   

}
