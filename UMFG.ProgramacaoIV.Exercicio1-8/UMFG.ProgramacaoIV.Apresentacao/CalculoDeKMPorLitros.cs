using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class CalculoDeKMPorLitros
    {
        private double DistaciaPercorrida { set; get; }
        private double QuantLGastos { set; get; }
        private double MediaKML { set; get; }

        public void CalcularMedia(double distaciaPercorrida, double QuantLGastos)
        {
            DistaciaPercorrida = distaciaPercorrida;
            QuantLGastos = QuantLGastos;
            MediaKML = distaciaPercorrida / QuantLGastos;
            MediaKML = Math.Round(MediaKML, 2);
            Console.WriteLine("| A média é de " + MediaKML + " KMs/Litro");
        }
    }
}
