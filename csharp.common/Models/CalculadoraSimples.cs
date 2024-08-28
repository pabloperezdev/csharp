using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class CalculadoraSimples
    {
        public void Somar (int valor1, int valor2)
        {
            Console.WriteLine ($"{valor1} + {valor2} = {valor1 + valor2}");
        }

        public void Subtrair (int valor1, int valor2)
        {
            Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}") ;
        }

        public void Multiplicar (int valor1, int valor2)
        {
            Console.WriteLine($"{valor1} x {valor2} = {valor1 * valor2}");
        }

        public void Dividir (int valor1, int valor2){
            Console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}") ;
        }
    }
}