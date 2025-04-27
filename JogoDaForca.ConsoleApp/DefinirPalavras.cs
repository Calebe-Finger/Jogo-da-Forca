namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
        public class DefinirPalavras
        {
            public string categoria = "";

            public string[] palavrasFrutas =
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

            public string[] palavrasPaises =
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

            public string[] palavrasAnimais =
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

            public string[] RetornaPalavra(string categoria)
            {
                string[] palavras = new string[40];

                if (Convert.ToInt32(categoria) == 1)
                {
                    palavras = new string[palavrasFrutas.Length];

                    categoria = "frutas";

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

                return palavras;
            }
        }
    }
}
