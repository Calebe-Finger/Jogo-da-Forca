namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
        public class ChutarPalavraInteira
        {
            public void UsuarioQuerChutar(char chute, string stgChute, string palavraSecreta, bool jogadorAcertou)
            {
                if (chute == 49)
                {
                    Console.Write("Digite qual palavra você acha que é: ");
                    stgChute = Console.ReadLine();

                    if (stgChute.ToUpper() == palavraSecreta)
                    {
                        jogadorAcertou = true;
                    }
                }
            }
        }
    }
}
