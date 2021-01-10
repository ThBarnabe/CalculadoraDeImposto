using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeImposto
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
