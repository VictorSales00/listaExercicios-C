using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class ConversaoDeMoeda
    {
        public double ValorReal { get; set; }
        public double ValorDolar { get; set; }
        public double ValorUser { get; set; }
        public double ValorCovertido { get; set; }

        public void ConverterRealDolar(double ValorUser)
        {
            ValorDolar = 0.193259;
            ValorUser = ValorUser;
            ValorCovertido = ValorUser * ValorDolar;
            ValorCovertido = Math.Round(ValorCovertido, 2);
            Console.WriteLine("Valor = R$" + ValorUser);
            Console.WriteLine("Conversão = US$" + ValorCovertido);
        }

        public void ConverterDolarReal(double ValorUser)
        {
            ValorReal = 5.22;
            ValorUser = ValorUser;
            ValorCovertido = ValorUser * ValorReal;
            ValorCovertido = Math.Round(ValorCovertido, 2);
            Console.WriteLine("Valor = $" + ValorUser);
            Console.WriteLine("Conversão = R$" + ValorCovertido);
        }
    }
}
