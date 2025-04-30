namespace JogoDaForca.ConsoleApp;
public class JogoDaForca
{
    char[] letrasEncontradas;
    int quantidadeErros;
    string palavraSecreta;

    public bool JogadorAcertou(char chute)
    {
        bool letraFoiEncontrada = false;
        bool jogadorAcertou = false;
        bool jogadorEnforcou = false;

        for (int contador = 0; contador < palavraSecreta.Length; contador++)
        {
            char letraAtual = palavraSecreta[contador];

            if (chute == letraAtual)
            {
                letrasEncontradas[contador] = letraAtual;
                letraFoiEncontrada = true;
            }
        }

        if (letraFoiEncontrada == false)
            quantidadeErros++;

        jogadorAcertou = String.Join("", letrasEncontradas) == palavraSecreta;
        jogadorEnforcou = quantidadeErros > 5;

        if (jogadorAcertou)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Você acertou a palavra secreta! Era: " + palavraSecreta);
            Console.WriteLine("-------------------------------------");
        }
        else if (jogadorEnforcou)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |         o        ");
            Console.WriteLine(" |        /x\\      ");
            Console.WriteLine(" |         x        ");
            Console.WriteLine(" |        / \\      ");
            Console.WriteLine(" |        ---       ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Que azar, tente novamente! A palavra era: " + palavraSecreta);
            Console.WriteLine("-------------------------------------");
        }

        return jogadorAcertou;
    }

    public bool JogadorPerdeu()
    {
        return quantidadeErros > 5;
    }

    public void ExibirForca()
    {
        string dicaDaPalavra = String.Join("", letrasEncontradas);

        Console.Clear();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Jogo da Forca");
        Console.WriteLine("-------------------------------------");

        if (quantidadeErros == 0)
        {
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/                 ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
        }
        else if (quantidadeErros == 1)
        {
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/                 ");
            Console.WriteLine(" |         o        ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
        }
        else if (quantidadeErros == 2)
        {
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/                 ");
            Console.WriteLine(" |         o        ");
            Console.WriteLine(" |         x        ");
            Console.WriteLine(" |         x        ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
        }
        else if (quantidadeErros == 3)
        {
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/                 ");
            Console.WriteLine(" |         o        ");
            Console.WriteLine(" |        /x\\      ");
            Console.WriteLine(" |         x        ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
        }
        else if (quantidadeErros == 4)
        {
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/                 ");
            Console.WriteLine(" |         o        ");
            Console.WriteLine(" |        /x\\      ");
            Console.WriteLine(" |         x        ");
            Console.WriteLine(" |        / \\      ");
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
        }
        else if (quantidadeErros == 5)
        {
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/                 ");
            Console.WriteLine(" |         o        ");
            Console.WriteLine(" |        /x\\      ");
            Console.WriteLine(" |         x        ");
            Console.WriteLine(" |        / \\      ");
            Console.WriteLine(" |        ---       ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
        }
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Quantidade de erros: " + quantidadeErros);
        Console.WriteLine("-------------------------------------");

    }

    public void DefinirPalavraSecreta()
    {
        string categoria = "";

        string[] palavrasFrutas =
        [
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
        ];

        string[] palavrasPaises =
        [
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
        ];

        string[] palavrasAnimais =
        [
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
        ];

        if (Convert.ToInt32(categoria) == 1)
        {
            categoria = "frutas";

            palavraSecreta = palavrasFrutas[i];
            
        }

        else if (Convert.ToInt32(categoria) == 2)
        {
            categoria = "países";

            palavraSecreta = palavrasPaises[i];
        }



        else if (Convert.ToInt32(categoria) == 3)
        {
            categoria = "animais";

            palavraSecreta = palavrasAnimais[i];
        }
    }

    public void PreencherLetrasEncontradas()
    {
        letrasEncontradas = new char[palavraSecreta.Length];

        for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
            letrasEncontradas[caractere] = '_';
    }

    public char ObterChute()
    {
        Console.Write("Digite uma letra: ");
        char chute = Console.ReadLine()!.ToUpper()[0];

        return chute;
    }
}