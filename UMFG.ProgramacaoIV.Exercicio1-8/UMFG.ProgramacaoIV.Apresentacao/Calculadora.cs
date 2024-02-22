using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Calculadora
    {
        private double Valor_Um { set; get; }
        private double Valor_Dois { set; get; }
        private double Resultado { set; get; }
        private string TipoConta { set; get; }

        public void Somar(double valorUm, double valorDois)
        {
            Valor_Um = valorUm;
            Valor_Dois = valorDois;
            Resultado = Valor_Um + Valor_Dois;
            Console.WriteLine("Resultado = " + Resultado);
        }

        public void Subtrair(double valorUm, double valorDois)
        {
            Valor_Um = valorUm;
            Valor_Dois = valorDois;
            Resultado = Valor_Um - Valor_Dois;
            Console.WriteLine("Resultado = " + Resultado);
        }

        public void Dividir(double valorUm, double valorDois)
        {
            Valor_Um = valorUm;
            Valor_Dois = valorDois;
            Resultado = Valor_Um / Valor_Dois
            Console.WriteLine("Resultado = " + Resultado);
        }

        public void Multiplicar(double valorUm, double valorDois)
        {
            Valor_Um = valorUm;
            Valor_Dois = valorDois;
            Resultado = Valor_Um * Valor_Dois;
            Console.WriteLine("Resultado = " + Resultado);
        }

        public void RestoDivisao(double valorUm, double valorDois)
        {
            Valor_Um = valorUm;
            Valor_Dois = valorDois;
            Resultado = Valor_Um % Valor_Dois;
            Console.WriteLine("Resultado = " + Resultado);
        }

    }
}