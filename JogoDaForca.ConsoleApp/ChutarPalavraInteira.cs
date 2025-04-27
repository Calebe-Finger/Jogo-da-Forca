namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
        public class ChutarPalavraInteira
        {
            public bool UsuarioQuerChutar(char chute, string stgChute, string palavraSecreta)
            {
                bool jogadorAcertou = false;
                if (chute == 49)
                {
                    Console.Write("Digite qual palavra você acha que é: ");
                    stgChute = Console.ReadLine();

                    if (stgChute.ToUpper() == palavraSecreta)
                        jogadorAcertou = true;
                }
                return jogadorAcertou;
            }
        }
    }
}
