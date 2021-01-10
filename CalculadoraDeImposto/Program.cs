using System;

namespace CalculadoraDeImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);
            
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            Console.WriteLine("Imposto ICMS sobre o Orçamento:");
            calculador.RealizaCalculo(orcamento, icms);

            Console.WriteLine("");

            Console.WriteLine("Imposto ISS sobre o Orçamento:");
            calculador.RealizaCalculo(orcamento, iss);


            Console.ReadKey();

        }
    }
}
