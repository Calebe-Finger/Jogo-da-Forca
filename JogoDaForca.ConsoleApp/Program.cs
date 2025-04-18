namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //Versão 3: Verifivação das entradas do usuário

        static void Main(string[] args)
        {
            while (true)
            {
                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int i = 0; i < letrasEncontradas.Length; i++)
                {
                    //acessar o array no indice 0
                    letrasEncontradas[i] = '_';
                }

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string dicaDaPalavra = String.Join(" ", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Palavra Secreta: " + dicaDaPalavra);

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0];        //Obtém apenas um caractere do que o usuário digita

                    for (int i = 0; i < palavraSecreta.Length; i++)
                    {
                        char letraAtual = palavraSecreta[i];

                        if (chute == letraAtual)
                            letrasEncontradas[i] = letraAtual;
                    }

                    Console.ReadLine();

                }
                while (jogadorAcertou == false || jogadorEnforcou == false);        // || = OU


            }
        }
    }
}
