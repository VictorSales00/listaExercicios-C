using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class QuantidadeDeVogaisEConsoantes
    {
        private string NomeUser { get; set; }
        private int Contador { get; set; }
        private char Vogal { get; set; }

        public int ContarVogais(string nome)
        {
            NomeUser = nome;
            Contador = 0;

            NomeUser = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentNullException(nameof(nome)) : nome;

            for (int i = 0; i < NomeUser.Length; i++)
            {
                Vogal = NomeUser.ToLower()[i];
                if ("aeiou".Contains(Vogal))
                {
                    Contador++;
                }
            }

            Console.WriteLine("| Quantidade Vogais: " + Contador);
            return Contador;
        }

        public int ContarConsantes(string nome)
        {
            NomeUser = nome;
            Contador = 0;

            NomeUser = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentNullException(nameof(nome)) : nome;

            for (int i = 0; i < NomeUser.Length; i++)
            {
                Vogal = NomeUser.ToLower()[i];
                if ("bcdfghjklmnpqrstvwxyz".Contains(Vogal))
                {
                    Contador++;
                }
            }

            Console.WriteLine("| Quantidade Consoantes: " + Contador);
            return Contador;
        }
    }
}
