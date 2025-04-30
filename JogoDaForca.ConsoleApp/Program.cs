using System.Security.Cryptography.X509Certificates;

namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
        //Versão 8: Implementando Orientação a Objeto   

        static void Main(string[] args)
        {
            JogoDaForca jogo = new JogoDaForca();

            while (true)
            {
                jogo.DefinirPalavraSecreta();
                jogo.PreencherLetrasEncontradas();

                while (true)
                {
                    jogo.ExibirForca();

                    char chute = jogo.ObterChute();

                    if (jogo.JogadorAcertou(chute) || jogo.JogadorPerdeu())
                        break;
                }

                Console.Write("Deseja sair do programa? S/N: ");
                string opcaoSair = Console.ReadLine().ToUpper();

                if (opcaoSair == "S") break;

                Console.ReadLine();
            }
        }
    }
}