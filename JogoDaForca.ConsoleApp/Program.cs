namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //Versão 4: Exibir mensagens de acerto/erro

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
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Palavra Secreta: " + dicaDaPalavra);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Quantidade de Erros: " + quantidadeErros);
                    Console.WriteLine("------------------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0];        //Obtém apenas um caractere do que o usuário digita

                    bool letraFoiEncontrada = false;

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

                    dicaDaPalavra = String.Join (" ", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavraSecreta;

                    jogadorEnforcou = quantidadeErros > 5;

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Parabéns você descobriu a palavra secreta!");
                    }

                    else if (jogadorEnforcou)
                    {
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Que azar! Tente novamente...");
                    }
                }
                while (jogadorAcertou == false || jogadorEnforcou == false);        // || = OU

                Console.ReadLine();
            }
        }
    }
}
