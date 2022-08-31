using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Numbers = Calculadora.Sum();

            string[] vect = new string[] { "Maria", "Bob", "Marcos" };

            // Foreach é uma maneira simplificada do FOR

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
