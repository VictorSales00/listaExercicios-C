using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class CalculoDeIdade
    {
        private int AnoAtual { get; set; }
        private int AnoNascimento { get; set; }
        private int IdadeUser { get; set; }

        public void CalcularIdade(int anoNascimento)
        {

            AnoAtual = 2024;
            AnoNascimento = anoNascimento;

            IdadeUser = AnoAtual - anoNascimento;

            if (IdadeUser == 0)
            {
                Console.WriteLine("Nascido neste ano");
            }
            else if (AnoNascimento > AnoAtual)
            {
                Console.WriteLine("* Ano Inválido *");
            }
            else
            {
                Console.WriteLine("Sua idade é: " + IdadeUser + " ano(s)");
            }

        }
    }
}

