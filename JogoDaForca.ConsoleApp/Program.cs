using System.Security.Cryptography.X509Certificates;

namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
        //Versão 8: Implementando Orientação a Objeto

        static void Main(string[] args)
        {
            while (true)
            {
                string categoria = ExibirCabecalho();
                if (categoria == "S")
                    break;

                DefinirPalavras DefPalavras = new DefinirPalavras();
                string[] palavras = new string[DefPalavras.RetornaPalavra(categoria).Length];
                palavras = DefPalavras.RetornaPalavra(categoria);

                Random geradorNumeros = new Random();
                int indicePalavraEscolhida = geradorNumeros.Next(palavras.Length);
                string palavraSecreta = palavras[indicePalavraEscolhida];
                char[] letrasEncontradas = new char[palavraSecreta.Length];
                for (int i = 0; i < letrasEncontradas.Length; i++)
                {
                    //acessar o array no indice 0
                    letrasEncontradas[i] = '_';
                }

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;
                string[] letrasChutadas = new string[20];
                bool letraRepetida = false;
                int contLetrasChutadas = 0;
                char chute = '\0';
                string stgChute = "";
                bool letraFoiEncontrada = false;
                string dicaDaPalavra = String.Join("", letrasEncontradas);

                while (jogadorAcertou == false && jogadorEnforcou == false)
                {

                    ExibirForcaECabecalho ExForcCab = new ExibirForcaECabecalho();

                    ExForcCab.Exibir(quantidadeErros, dicaDaPalavra, categoria, letrasChutadas);

                    do
                    {
                        chute = ChutarLetra();

                        ChutarPalavraInteira ChutPalaInt = new ChutarPalavraInteira();
                        jogadorAcertou = ChutPalaInt.UsuarioQuerChutar(chute, stgChute, palavraSecreta);

                        VerificarLetrasChutadas VerfLetrChut = new VerificarLetrasChutadas();
                        letraRepetida = VerfLetrChut.Verficar(letrasChutadas, chute);

                    } while (letraRepetida == true);

                    letrasChutadas[contLetrasChutadas] = Convert.ToString(chute);

                    if (letrasChutadas[contLetrasChutadas] == "1")
                    {
                        letrasChutadas[contLetrasChutadas] = "";
                    }
                    contLetrasChutadas++;

                    letraFoiEncontrada = false;

                    VerificarLetraEncontrada VerfLetrEncont = new VerificarLetraEncontrada();
                    quantidadeErros = VerfLetrEncont.FazerVerificacao(palavraSecreta, chute, 
                        letrasEncontradas, letraFoiEncontrada, quantidadeErros);

                    dicaDaPalavra = String.Join("", letrasEncontradas);

                    if (dicaDaPalavra == palavraSecreta)
                    {
                        jogadorAcertou = true;
                    }


                    else if (quantidadeErros >= 5)
                    {
                        jogadorEnforcou = true;
                    }

                    if (jogadorAcertou)
                    {
                        ExibirVitoria(palavraSecreta, categoria, quantidadeErros);
                    }

                    else if (jogadorEnforcou)
                    {
                        ExibirDerrota(palavraSecreta);
                    }
                }
            }
        }
        static string ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Escolha uma categoria: ");
            Console.WriteLine("1 - Frutas ");
            Console.WriteLine("2 - Países ");
            Console.WriteLine("3 - Animais ");
            Console.WriteLine("S - Sair ");
            Console.WriteLine("------------------------------------------------");

            string categoria = Console.ReadLine().ToUpper();

            return categoria;
        }

        static char ChutarLetra()
        {
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Digite uma letra: ");
            Console.WriteLine("1 - Chutar a palavra inteira ");

            char chute = Console.ReadLine().ToUpper()[0];        //Obtém apenas um caractere do que o usuário digita
            return chute;
        }

        static void ExibirVitoria(string palavraSecreta, string categoria, int quantidadeErros)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("  ____________                    ");
            Console.WriteLine("  |/         |                    ");
            Console.WriteLine("  |                               ");
            Console.WriteLine("  |                    vencemo!   ");
            Console.WriteLine("  |                  0´           ");
            Console.WriteLine("  |                 \\|/          ");
            Console.WriteLine("  |                  |            ");
            Console.WriteLine(" _|____             / \\          ");
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Palavra Secreta: " + palavraSecreta);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Categoria: " + categoria);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Quantidade de Erros: " + quantidadeErros);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Parabéns você descobriu a palavra secreta!");

            Console.ReadLine();
        }

        static void ExibirDerrota(string palavraSecreta)
        {
            Console.Clear();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("  ____________      ");
            Console.WriteLine("  |/         |      ");
            Console.WriteLine("  |          0      ");
            Console.WriteLine("  |                 ");
            Console.WriteLine("  |         /|\\    ");
            Console.WriteLine("  |          |      ");
            Console.WriteLine("  |         / \\    ");
            Console.WriteLine(" _|____             ");
            Console.WriteLine("\n");
            Console.WriteLine("Que azar! Você perdeu, tente novamente...");
            Console.WriteLine("Palavra Secreta: " + palavraSecreta);

            Console.ReadLine();
        }
    }
}
