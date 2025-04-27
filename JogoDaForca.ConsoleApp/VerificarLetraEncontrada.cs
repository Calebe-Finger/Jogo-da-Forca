namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
        public class VerificarLetraEncontrada
        {
            public int FazerVerificacao(string palavraSecreta, char chute, char[] letrasEncontradas,
                bool letraFoiEncontrada, int quantidadeErros)
            {
                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    char letraAtual = palavraSecreta[i];

                    if (chute == letraAtual)
                    {
                        letrasEncontradas[i] = letraAtual;
                        letraFoiEncontrada = true;
                    }
                }
                if (letraFoiEncontrada == false)
                    quantidadeErros++;

                return quantidadeErros;
            }
        }
    }
}
