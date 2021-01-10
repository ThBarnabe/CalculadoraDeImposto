using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeImposto
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double resultado = imposto.Calcula(orcamento);
           Console.WriteLine(resultado);
        }
 
    }
}
