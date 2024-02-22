using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class CalculoDeFaixaEtaria
    {
        private DateTime Date { get; set; }
        private DateTime BirthUserDate { get; set; }
        private string NameUser { get; set; }
        private int Age { get; set; }

        public void CalcularFaixaEtaria(DateTime dataNascimentoUsuario, string nome)
        {
            BirthUserDate = dataNascimentoUsuario;
            Date = DateTime.Today;
            NameUser = nome;

            NameUser = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentNullException(nameof(nome)) : nome;

            Console.WriteLine("+----------------------------------------------+");

            Age = Date.Year - DataNascimentoUsuario.Year;


            if (Date.Year < DataNascimentoUsuario.Year)
            {
                Console.WriteLine("* Ano de Nascimento Inválido *");
            }
            else if (Age <= 19)
            {
                Console.WriteLine("Nome: " + NameUser + " | Faixa Etaria: Jovem");
            }
            else if (Age >= 20 && Age <= 59)
            {
                Console.WriteLine("Nome: " + NameUser + " | Faixa Etaria : Adulto");
            }
            else
            {
                Console.WriteLine("Nome: " + NameUser + " | Faixa Etaria : Idoso");
            }

        }

    }
}
