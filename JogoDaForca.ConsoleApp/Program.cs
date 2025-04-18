namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //Versão 2: Exibir palavra oculta com traços

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

                string dicaDaPalavra = String.Join(" ", letrasEncontradas);

                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Palavra Secreta: " + dicaDaPalavra);

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0];        //Obtém apenas um caractere do que o usuário digita
            }
        }
    }
}
