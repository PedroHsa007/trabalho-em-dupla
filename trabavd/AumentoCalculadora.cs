using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace trabavd
{
    public class AumentoCalculadora
    {
        public double CalcularAumento(double valorOriginal , double taxaAumento)
        {
            double aumento = valorOriginal * (taxaAumento / 100);
            return aumento;
        }
        public double CalcularNovoValor(double valorOriginal,double aumento)
        {
            double novoValor = valorOriginal + aumento;
            return novoValor;
        }
    }
}
