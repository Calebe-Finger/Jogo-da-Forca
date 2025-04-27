namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
        public class VerificarLetrasChutadas
        {
            public bool Verficar(string[] letrasChutadas, char chute)
            {
                bool letraRepetida = false;
                for (int i = 0; i < letrasChutadas.Length; i++)
                {
                    if (letrasChutadas[i] == Convert.ToString(chute) && letrasChutadas[i] != "1")
                    {
                        Console.WriteLine("Você já chutou essa letra, tente novamente: ");
                        Console.ReadLine();

                        letraRepetida = true;
                        break;
                    }
                    else
                        letraRepetida = false;
                }
                return letraRepetida;
            }
        }
    } 
}
