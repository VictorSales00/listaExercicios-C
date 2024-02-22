using UMFG.ProgramacaoIV.Dominio.Entidades;
using UMFG.ProgramacaoIV.Dominio.Interfaces;
using UMFG.ProgramacaoIV.Dominio.Servicos;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Program
    {
        private const string C_USUARIO_PADRAO = "teste@teste.com";

        private static ILivroServico _servico = new LivroServico();

        static void Main(string[] args)
        {
            var opUser = 0;

            do
            {
                Console.WriteLine("+-------------------------------------+");
                Console.WriteLine("|                MENU                 |");
                Console.WriteLine("+-------------------------------------+");
                Console.WriteLine("|        [1] - Cadastrar Livro        |");
                Console.WriteLine("|        [2] - Consultar Livros       |");
                Console.WriteLine("+-------------------------------------+");
                Console.WriteLine("|        [0] - Sair                   |");
                Console.WriteLine("+-------------------------------------+");
                Console.WriteLine("Digite a opção desejada: ");
                int.TryParse(Console.ReadLine(), out opUser);

                switch (opUser)
                {
                    case 1:
                        CadastrarLivro();
                        break;
                    case 2:
                        ListarLivros();
                        break;
                    case 9:

                        Console.WriteLine("|            Desligando...          |");

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("**         Opção Inválida          **");
                        break;
                }

            } while (opUser != 0);
        }

        public static void CadastrarLivro()
        {
            try
            {
                Console.WriteLine("+-----------------------------------+");
                Console.WriteLine("|          Cadastrar Livro          |");
                Console.WriteLine("+-----------------------------------+");

                Console.WriteLine("Nome do Livro:");
                string nomeLivro = Console.ReadLine();

                Console.WriteLine("Autor:");
                string autorLivro = Console.ReadLine();

                Console.WriteLine("Valor:");
                var valorLivro = Console.ReadLine();

                decimal valorLivroConvertido = Convert.ToDecimal(valorLivro);

                Console.Clear();
                var novoLivro = new Livro(nomeLivro, autorLivro, valorLivroConvertido, C_USUARIO_PADRAO, C_USUARIO_PADRAO);
                _servico.AdicionarLivro(novoLivro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ListarLivros()
        {
            try
            {
                var sair = "c";
                do
                {
                    Console.WriteLine("+-----------------------------------+");
                    Console.WriteLine("|        Livros Cadastrados         |");
                    Console.WriteLine("+-----------------------------------+");
                    Console.WriteLine("|      [1] - Listar livros          |");
                    Console.WriteLine("|      [2] - Voltar ao Menu         |");
                    Console.WriteLine("+-----------------------------------+");
                    Console.WriteLine("Digite a opção desejada:");
                    sair = Console.ReadLine();

                    switch (sair.ToLower())
                    {
                        case "l":
                            Console.Clear();
                            Console.WriteLine("+-----------------------------------+");
                            foreach (var item in _servico.obterLivros())
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;
                        default:
                            Console.Clear();

                            Console.WriteLine("**        Opção Inválida         **");
                            break;
                    }
                } while (sair.ToLower() != "v");
                Console.Clear();
            }
            catch (Exception ex)
            {

                Console.WriteLine("**          Falha na busca          **");
            }
        }


    }
}