using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculo_de_Media
{
    internal class Media
    {

        public string Nome;
        public double N1;
        public double N2;
        public double N3;
        public double NotaRestante;

        public double MediaAnual()
        {
            double somaMedia = (N1 + N2 + N3) / 3;
            return somaMedia;
        }

        public void notaRestante(double Nota)
        {

            if (Nota < 60)
            {

                NotaRestante = Nota;

                
                Console.WriteLine($"Aluno Reprovado. \r\n" +
                    $"Faltam {60 - NotaRestante}");               
            }
            else{
                Console.WriteLine("");
                Console.WriteLine("Aluno Aprovado");
            }
        }

    }

}
