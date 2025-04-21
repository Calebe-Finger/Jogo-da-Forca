namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //Versão 7: Mais opções de palavras

        static void Main(string[] args)
        {

            string[] palavras = new string[40];

            string[] palavrasFrutas =
            {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "AÇAI",
                "ARAÇA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUAÇU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MAÇA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            string[] palavrasPaises =
            {
                "ALEMANHA",
                "ARGENTINA", 
                "AUSTRALIA", 
                "BRASIL", 
                "CANADA", 
                "CHINA", 
                "COREIA DO SUL", 
                "EGITO", 
                "ESPANHA", 
                "ESTADOS UNIDOS", 
                "FRANÇA", 
                "INDIA", 
                "INDONESIA", 
                "ITALIA", 
                "JAPAO", 
                "MEXICO", 
                "NIGERIA", 
                "PAQUISTAO", 
                "REINO UNIDO", 
                "RUSSIA", 
                "TURQUIA", 
                "AFRICA DO SUL"
            };

            string[] palavrasAnimais =
            {
                "ABELHA",
                "BALEIA",
                "BORBOLETA",
                "CACHORRO",
                "CAVALO",
                "COELHO",
                "COBRA",
                "ELEFANTE",
                "FORMIGA",
                "GALINHA",
                "GATO",
                "GIRAFA",
                "GOLFINHO",
                "HAMSTER",
                "JACARE",
                "LEAO",
                "MACACO",
                "OVELHA",
                "PANDA",
                "PASSARINHO",
                "PATO",
                "PEIXE",
                "PERU",
                "PORCO",
                "RATO",
                "TARTARUGA",
                "TIGRE",
                "URSO",
                "VACA",
                "ZEBRA"
            };

            while (true)
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

                if (categoria == "S")
                    break;

                if (Convert.ToInt32(categoria) == 1)
                {
                    categoria = "frutas";
                    palavras = new string[palavrasFrutas.Length];

                    for (int i = 0; i < palavrasFrutas.Length; i++)
                    {
                        palavras[i] = palavrasFrutas[i];
                    }
                }

                else if (Convert.ToInt32(categoria) == 2)
                {
                    categoria = "países";
                    palavras = new string[palavrasPaises.Length];

                    for (int i = 0; i < palavrasPaises.Length; i++)
                    {
                        palavras[i] = palavrasPaises[i];
                    }
                }

                else if (Convert.ToInt32(categoria) == 3)
                {
                    categoria = "animais";
                    palavras = new string[palavrasAnimais.Length];

                    for (int i = 0; i < palavrasAnimais.Length; i++)
                    {
                        palavras[i] = palavrasAnimais[i];
                    }
                }

                else
                {
                    Console.WriteLine("O número inserido não é valido!");
                    Console.WriteLine("Por favor, tente novamente");
                    Console.ReadLine();
                }

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
                string[] letrasChutadas = new string [20];
                bool letraRepetida = false;
                int contLetrasChutadas = 0;
                char chute = '\0';
                bool letraFoiEncontrada = false;
                string dicaDaPalavra = String.Join("", letrasEncontradas);

                while (jogadorAcertou == false && jogadorEnforcou == false)
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

                    do
                    {
                        Console.WriteLine("\n--------------------------------------");
                        Console.Write("Digite uma letra: ");

                        chute = Console.ReadLine().ToUpper()[0];        //Obtém apenas um caractere do que o usuário digita


                        for (int i = 0; i < letrasChutadas.Length; i++)
                        {
                            if (letrasChutadas[i] == Convert.ToString(chute))
                            {
                                Console.WriteLine("Você já chutou essa letra, tente novamente: ");
                                Console.ReadLine();

                                letraRepetida = true;
                                break;
                            }
                        }
                    } while (letraRepetida == true);

                    letrasChutadas[contLetrasChutadas] = Convert.ToString(chute);
                    contLetrasChutadas++;

                    letraFoiEncontrada = false;

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
                        Console.WriteLine("Palavra Secreta: " + dicaDaPalavra);
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Categoria: " + categoria);
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Quantidade de Erros: " + quantidadeErros);
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Parabéns você descobriu a palavra secreta!");

                        Console.ReadLine();
                    }

                    else if (jogadorEnforcou)
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
        }
    }
}
