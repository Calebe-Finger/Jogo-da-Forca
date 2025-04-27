namespace JogoDaForca.ConsoleApp
{
    public class ExibirForcaECabecalho
    {
        public void Exibir(int quantidadeErros, string dicaDaPalavra, string categoria, string[] letrasChutadas)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("------------------------------------------------");

            if (quantidadeErros == 0)
            {
                Console.WriteLine("  ____________      ");
                Console.WriteLine("  |/         |      ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine(" _|____             ");
            }

            else if (quantidadeErros == 1)
            {
                Console.WriteLine("  ____________      ");
                Console.WriteLine("  |/         |      ");
                Console.WriteLine("  |          0      ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine(" _|____             ");
            }

            else if (quantidadeErros == 2)
            {
                Console.WriteLine("  ____________      ");
                Console.WriteLine("  |/         |      ");
                Console.WriteLine("  |          0      ");
                Console.WriteLine("  |          |      ");
                Console.WriteLine("  |                ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine(" _|____             ");
            }

            else if (quantidadeErros == 3)
            {
                Console.WriteLine("  ____________      ");
                Console.WriteLine("  |/         |      ");
                Console.WriteLine("  |          0      ");
                Console.WriteLine("  |          |      ");
                Console.WriteLine("  |          |     ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine(" _|____             ");
            }

            else if (quantidadeErros == 4)
            {
                Console.WriteLine("  ____________      ");
                Console.WriteLine("  |/         |      ");
                Console.WriteLine("  |          0      ");
                Console.WriteLine("  |         /|\\    ");
                Console.WriteLine("  |          |      ");
                Console.WriteLine("  |                 ");
                Console.WriteLine("  |                 ");
                Console.WriteLine(" _|____             ");
            }

            else if (quantidadeErros == 5)
            {
                Console.WriteLine("  ____________      ");
                Console.WriteLine("  |/         |      ");
                Console.WriteLine("  |          0      ");
                Console.WriteLine("  |         /|\\    ");
                Console.WriteLine("  |          |      ");
                Console.WriteLine("  |         / \\    ");
                Console.WriteLine("  |        ------   ");
                Console.WriteLine(" _|____             ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Palavra Secreta: " + dicaDaPalavra);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Categoria: " + categoria);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Quantidade de Erros: " + quantidadeErros);
            Console.WriteLine("------------------------------------------------");

            Console.Write("Letras já chutadas: ");

            for (int i = 0; i < letrasChutadas.Length; i++)
            {
                if (letrasChutadas[i] != null)
                    Console.Write(letrasChutadas[i] + " ");
            }
        }
    }
}

